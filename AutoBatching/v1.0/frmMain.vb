Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports AutoBatchingLibrary.Automation
Public Class frmMain

#Region "Initialization"
    Private Sub mainInit()

        reloadBGW()

        QueueList = New List(Of BatchInfo)
        ListedBatchFiles = New List(Of String)
    End Sub

    Private Sub reloadBGW()
        bgBatcher = New List(Of BackgroundWorker)
        For i As Integer = 0 To SystemConfig.ThreadCount - 1
            Dim _bg As New System.ComponentModel.BackgroundWorker
            _bg.WorkerReportsProgress = True
            _bg.WorkerSupportsCancellation = True
            bgBatcher.Add(_bg)

            AddHandler bgBatcher(i).DoWork, AddressOf bgBatcher_Dowork
            AddHandler bgBatcher(i).RunWorkerCompleted, AddressOf bgBatcher_RunworkerCompleted
        Next
    End Sub
    'Private Sub init1()
    '    QueueList = Nothing
    '    NextListing = Nothing
    '    lstBatches.Items.Clear()
    '    lstLogs.Items.Clear()
    'End Sub

#End Region

    Private Sub disposeVars()
        Cancelled = False
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Main_Connection.State = System.Data.ConnectionState.Open Then Main_Connection.Close()
        If Logs_Connection.State = System.Data.ConnectionState.Open Then Logs_Connection.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " (" & Application.ProductVersion & ")"
        Dim settingsDir As String = String.Format("{0}\Data\MDB\{1}.mdb", Application.StartupPath, Main_MDBName)
        Dim logsDir As String = String.Format("{0}\Data\MDB\{1}.mdb", Application.StartupPath, Logs_MDBName)

        If Not Directory.Exists(Application.StartupPath & "\Data") Then
            Directory.CreateDirectory(StatusDirectory)
            Directory.CreateDirectory(MDBDirectory)
            Directory.CreateDirectory(ExeDirectory)
        End If

        If Not IO.File.Exists(settingsDir) Then
            mdbCreate(settingsDir)
            mdbOpen(settingsDir, Main_Connection)
            mdbCreateTable(Settings_TableName, Settings_Fields, Settings_Types, Main_Connection)
            mdbCreateTable(Settings_Basis_TableName, Settings_Basis_Fields, Settings_Basis_Types, Main_Connection)
        Else : mdbOpen(settingsDir, Main_Connection)
        End If

        If Not IO.File.Exists(logsDir) Then
            mdbCreate(logsDir)
            mdbOpen(logsDir, Logs_Connection)
            mdbCreateTable(Logs_TableName, Logs_Fields, Logs_Types, Logs_Connection)
        Else : mdbOpen(logsDir, Logs_Connection)
        End If

        Dim pi As PropertyInfo = Nothing
        pi = lstBatches.GetType.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        pi.SetValue(lstBatches, True, Nothing)
        pi = lstLogs.GetType.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        pi.SetValue(lstLogs, True, Nothing)

        Main_Connection.Open()
        Control.CheckForIllegalCrossThreadCalls = False

        SystemConfig = New clsConfig
        If SystemConfig.Items.Count = 0 Then mnSettings.PerformClick() Else mainInit()
    End Sub

    Private Sub mnSettings_Click(sender As Object, e As EventArgs) Handles mnSettings.Click
        dlgConfig.ShowDialog()
        reloadBGW()
    End Sub

    Private Sub mnExit_Click(sender As Object, e As EventArgs) Handles mnExit.Click
        Me.Close()
    End Sub

    Private Sub mnStart_Click(sender As Object, e As EventArgs) Handles mnStart.Click
        tmMain.Enabled = True
    End Sub

    Private Sub mnPause_Click(sender As Object, e As EventArgs) Handles mnPause.Click
        Cancelled = True
    End Sub

    Private Sub tmMain_Tick(sender As Object, e As EventArgs) Handles tmMain.Tick
        tmMain.Enabled = False
        If Not Cancelled Then
            'RUN
            If Not bgListing.IsBusy Then
                If NextListing >= Now Then
                    lbListing.Text = String.Format("{0,00}sec. Before Listing", NextListing.Subtract(Now).Seconds)
                Else
                    lbListing.Text = "LISTING..."
                    bgListing.RunWorkerAsync()
                End If
            End If
            'Allocation
            If QueueList IsNot Nothing AndAlso Not QueueList.Count = 0 Then
                For i As Integer = 0 To SystemConfig.ThreadCount - 1
                    If Not bgBatcher(i).IsBusy Then
                        bgBatcher(i).RunWorkerAsync(QueueList(0))

                        QueueList.RemoveAt(0)
                        lbRemainingBatches.Text = QueueList.Count
                        If QueueList.Count = 0 Then
                            Exit For
                        End If
                    End If
                Next
                lbStatus.Text = "RUNNING"
            Else : lbStatus.Text = "STAND BY"
            End If
        Else
            lbStatus.Text = "CANCELLING"
            If bgBatcher.Find(Function(x As BackgroundWorker) x.IsBusy) Is Nothing Then
                'disable vars
                lbStatus.Text = "CANCELLED" 'cancelled
                disposeVars()
            End If
        End If

        tmMain.Enabled = True
    End Sub

#Region "Background Workers Methods"
    'Private Sub bgBatcher_Dowork(sender As Object, e As DoWorkEventArgs)
    '    Dim _batch As BatchInfo = DirectCast(e.Argument, BatchInfo)
    '    Dim _elapse As TimeSpan
    '    Dim idx As Integer = DirectCast(e.Argument, Integer)
    '    Dim _result(5) As Object '0 - Status | 1 - Start Time | 2 - End Time | 3 - Elapse Time | 4 - Error | 5 - BatchInfo
    '    _result(5) = _batch
    '    _result(1) = Now 'Start Time

    '    Try

    '        'CALL BATCHING PROGRAM THEN WAIT UNTIL DONE 

    '        _result(0) = String.Format("Success Batching - {0}", "") 'Success
    '    Catch ex As Exception
    '        _result(4) = ex.Message 'Error
    '    End Try

    '    _result(2) = Now 'End Time
    '    _elapse = (DirectCast(_result(2), Date) - DirectCast(_result(1), Date))
    '    _result(3) = String.Format("{0}:{1}:{2}", _elapse.Hours, _elapse.Minutes, _elapse.Seconds) 'Elapse Time
    '    e.Result = _result
    'End Sub

    Private Sub bgBatcher_Dowork(sender As Object, e As DoWorkEventArgs)
        Dim batch As BatchInfo = DirectCast(e.Argument, BatchInfo)
        Dim triesCounter As Integer = 0
        Try
            batch.ItemHolder.ForeColor = Color.Blue
            batch.StartTime = Now 'Start Time
            Dim batchFile As String = batch.ItemHolder.SubItems(0).Text
            File.Move(batchFile, batch.Batcher.TempDirectory & Path.GetFileName(batchFile))
            batch.ItemHolder.SubItems(0).Text = batch.Batcher.TempDirectory & Path.GetFileName(batchFile)

            Dim statusFilePath As String = StatusDirectory & Path.GetFileNameWithoutExtension(batch.ItemHolder.SubItems(0).Text) & batch.StartTime.ToString("_dd_HHmmss") & ".status"
            Dim newBatchName As String
            Dim dupBatchName As String
            Dim batchFullPath As String = Path.GetDirectoryName(batch.ItemHolder.SubItems(0).Text)
            Dim origBatchName As String = Path.GetFileName(batch.ItemHolder.SubItems(0).Text)
            'GENERATE NEW NAME
            If batch.Batcher.Duplicate Then
                dupBatchName = String.Format("{0}_DUP{1}.zip", origBatchName, New DirectoryInfo(batch.Batcher.DuplicateString).Parent.Name)
                newBatchName = batchFullPath & "\" & dupBatchName
                My.Computer.FileSystem.RenameFile(batch.ItemHolder.SubItems(0).Text, dupBatchName)
            Else
                newBatchName = batch.ItemHolder.SubItems(0).Text
            End If

            'CALL BATCHING PROGRAM THEN WAIT UNTIL DONE 
            Dim reader As StreamReader = Nothing
            Dim state As BatchStates = BatchStates.Started
            Dim p As New Process
            Dim pInfo As New ProcessStartInfo(batch.Batcher.ExeFilePath, String.Format("{0}|{1}|{2}|{3}|{4}|{5}", _
                                            newBatchName, batch.Batcher.TargetDirectory, batch.Batcher.BatchCount, "True", statusFilePath, "").Replace(" ", spaceEncryptor))
            pInfo.WindowStyle = ProcessWindowStyle.Hidden
            p.StartInfo = pInfo
            p.Start()

            While Not (state = BatchStates.Done Or state = BatchStates.ErrorFound)
                If File.Exists(statusFilePath) Then
                    Try : reader = New StreamReader(statusFilePath, False) : Catch : Continue While : End Try
                    Dim l As String = reader.ReadLine()
                    reader.Close()
                    state = changeStatus(l, batch)
                Else : triesCounter += 1
                End If

                If triesCounter >= 20 Then
                    batch.ErrorMsg = "Status file not found."
                    Exit While
                End If
                Threading.Thread.Sleep(300)
            End While
            File.Delete(statusFilePath)

            ' Threading.Thread.Sleep(5000)
            If state = BatchStates.Done Then
                batch.Status = String.Format("Batching Succeed - {0}", newBatchName) 'Success
            ElseIf state = BatchStates.ErrorFound Then
                batch.Status = String.Format("Batching Failed - {0}", newBatchName) 'Success
            End If

            If batch.Batcher.Duplicate Then 'REVERT BACK TO THE ORIGINAL BATCHNAME
                My.Computer.FileSystem.RenameFile(newBatchName, origBatchName)
            End If
        Catch ex As Exception
            batch.ErrorMsg = ex.Message 'Error
            DebugMsgbox(ex.Message, "Do work")
        End Try

        batch.EndTime = Now 'End Time
        batch.ElapseTime = (batch.EndTime - batch.StartTime) 'Elapse Time
        e.Result = batch
    End Sub

    Private Sub bgBatcher_RunworkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim _batch As BatchInfo = DirectCast(e.Result, BatchInfo)
        With _batch
            Try
                Dim itm As ListViewItem = lstLogs.Items.Add(.Status)
                Dim batchFile As String = .ItemHolder.SubItems(0).Text
                itm.SubItems.Add(.StartTime)
                itm.SubItems.Add(.EndTime)
                itm.SubItems.Add(String.Format("{0}:{1}:{2}", .ElapseTime.Hours, .ElapseTime.Minutes, .ElapseTime.Seconds))
                itm.SubItems.Add(.ErrorMsg)

                '     If Not My.Settings.computername = My.Computer.Name Then
                Dim con As OleDb.OleDbConnection = Nothing
                mdbOpen(.Batcher.LogConnectionPath, con)
                con.Open()
                mdbInsert(Logs_TableName, Logs_Fields, New Object() {Path.GetFileName(batchFile), batchFile, .Batcher.Client, .Batcher.Job, .ItemHolder.SubItems(3).Text, _
                                            .StartTime.ToString("G"), .EndTime.ToString("G"), String.Format("{0}:{1}:{2}", .ElapseTime.Hours, .ElapseTime.Minutes, .ElapseTime.Seconds), _
                                            .ErrorMsg.Replace("'", "''") & ""}, con)
                con.Close()

                mdbInsert(Logs_TableName, Logs_Fields, New Object() {Path.GetFileName(batchFile), batchFile, .Batcher.Client, .Batcher.Job, .ItemHolder.SubItems(3).Text, _
                                    .StartTime.ToString("G"), .EndTime.ToString("G"), String.Format("{0}:{1}:{2}", .ElapseTime.Hours, .ElapseTime.Minutes, .ElapseTime.Seconds), _
                                    .ErrorMsg.Replace("'", "''") & ""}, Logs_Connection)

                'File.Move(batchFile, .Batcher.TempDirectory & Path.GetFileName(batchFile))
                'End If
            Catch ex As Exception
                DebugMsgbox(ex.Message, "Run worker complete")
            End Try
        End With

        _batch.ItemHolder.Remove()
        GC.Collect()
    End Sub

    Private Sub bgListing_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgListing.DoWork
        GetList()
    End Sub

    Private Sub bgListing_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgListing.RunWorkerCompleted
        NextListing = Now.AddSeconds(20)
    End Sub

    Public Sub GetList()
        Dim err As String = ""
        DaysToCheck = getValidDays()
        '  ListedBatchFiles.Clear()
        Try
            err = "ITEMS"
            For br As Integer = 0 To SystemConfig.Items.Count - 1
                err = "BATCHER"
                If Directory.Exists(SystemConfig.Items(br).RootDirectory) And Directory.Exists(SystemConfig.Items(br).TargetDirectory) Then
                    err = "DAYS"
                    For Each day As String In DaysToCheck
                        err = "SUBDIR"
                        For Each subDir As String In Directory.GetDirectories(SystemConfig.Items(br).RootDirectory)
                            Dim batcher As New BatcherInfo(SystemConfig.Items(br))
                            If Regex.IsMatch(subDir, String.Format("(\d)+(_)({0})", day)) Then
                                Dim logDir As String = String.Format("{0}\tmp\{1}.mdb", subDir, Path.GetFileName(subDir))
                                Dim batchFiles As New List(Of String)
                                Dim con As OleDb.OleDbConnection = Nothing

                                batchFiles.AddRange(Directory.GetFiles(subDir))
                                If Directory.Exists(subDir & "\RELOADED") Then
                                    batchFiles.AddRange(Directory.GetFiles(subDir & "\RELOADED"))
                                End If

                                If batchFiles.Count > 0 Then 'AND IF ALREADY BATCHED
                                    err = "BATCHFILES"
                                    batcher.TempDirectory = subDir & "\tmp\"
                                    Directory.CreateDirectory(batcher.TempDirectory)
                                    If Not File.Exists(logDir) Then
                                        mdbCreate(logDir)
                                        mdbOpen(logDir, con)
                                        mdbCreateTable(Logs_TableName, Logs_Fields, Logs_Types, con)
                                    Else : mdbOpen(logDir, con) : End If
                                    If con.State = ConnectionState.Closed Then con.Open()

                                    For i As Integer = 0 To batchFiles.Count - 1
                                        Dim bfname As String = Path.GetFileName(batchFiles(i))
                                        err = "BASIS"
                                        If Not ListedBatchFiles.Contains(bfname) AndAlso Not checkLog(batcher.Client, batcher.Job, bfname, con) Then
                                            checkLog(batcher.Client, batcher.Job, bfname, Logs_Connection, batcher.DuplicateString)

                                            For b As Integer = 0 To batcher.Basis.Count - 1
                                                If checkBasis(Path.GetFileNameWithoutExtension(batchFiles(i)), batcher.Basis(b)) Then
                                                    batcher.LogConnectionPath = logDir
                                                    QueueList.Add(fillList(batchFiles(i), batcher, batcher.Basis(b).Type))
                                                    ListedBatchFiles.Add(Path.GetFileName(batchFiles(i)))
                                                    Exit For
                                                End If
                                            Next
                                        End If
                                    Next
                                    If con.State = ConnectionState.Open Then con.Close()
                                End If
                            End If
                        Next
                    Next
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & err, MsgBoxStyle.OkOnly, "Listing")
        End Try

        '    If QueueList.Count = 0 Then QueueList = Nothing
    End Sub

    Private Function checkLog(cl As String, job As String, btfl As String, con As OleDb.OleDbConnection, Optional ByRef result As String = "") As Boolean
        checkLog = False
        Dim logReader As OleDb.OleDbDataReader = mdbRead(String.Format("SELECT * FROM {0} WHERE client='{1}' AND job='{2}' AND batchfile='{3}'", Logs_TableName, cl, job, btfl), con)

        logReader.Read()
        If logReader.HasRows Then
            checkLog = Not logReader.Item("batchfile").ToString = ""
            result = logReader.Item("batchfullpath").ToString
            logReader.Close()
        End If
        Return checkLog
    End Function

    Private Function checkBasis(val As String, basis As BatchItemBasis1) As Boolean
        If Not basis.Substring = "" And basis.IsValid Then
            Return basis.Keystring = val.Substring(basis.SubstringStartIndex, IIf(basis.SubstringLength = 0, val.Length - 1, basis.SubstringLength))
        End If

        Return False
    End Function

    Private Function fillList(batchFile As String, batcher As BatcherInfo, tp As String) As BatchInfo

        Dim item As ListViewItem = Nothing
        Dim newBatch As New BatchInfo

        Try
            newBatch.Batcher = batcher
            newBatch.ListTime = Now
            item = lstBatches.Items.Add(batchFile)
            item.SubItems.Add(newBatch.Batcher.Client)
            item.SubItems.Add(newBatch.Batcher.Job)
            item.SubItems.Add(tp)
            item.SubItems.Add("STAND BY")
            newBatch.ItemHolder = item
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return newBatch
    End Function

    Private Function getValidDays() As List(Of String)
        Dim _days As New List(Of String)
        _days.Add(Now.ToString("ddMMyyyy"))
        For i As Integer = 1 To SystemConfig.DaysToBatch - 1
            _days.Add(Now.AddDays(-i).ToString("ddMMyyyy"))
        Next
        _days.Sort()
        Return _days
    End Function

    Private Function changeStatus(feedback As String, ByRef batch As BatchInfo) As BatchStates
        If Not feedback = Nothing Or Not feedback = "" Then
            Dim items As String() = stateSeparator.Split(feedback)
            batch.ItemHolder.SubItems(4).Text = items(0)

            Select Case items(0).Trim("`")
                Case "DONE"
                    Return BatchStates.Done
                Case "ERROR"
                    batch.ErrorMsg = items(1)
                    Return BatchStates.ErrorFound
                Case Else
                    Return BatchStates.Started
            End Select
        Else : Return BatchStates.Started
        End If
    End Function

#End Region

    Private Sub lbRemainingBatches_Click(sender As Object, e As EventArgs) Handles lbRemainingBatches.Click

    End Sub
End Class
