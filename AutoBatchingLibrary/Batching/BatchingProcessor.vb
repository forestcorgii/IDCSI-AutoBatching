Imports System.IO
Imports System.Windows.Forms
Imports AutoBatchingLibrary.BatchState

Public Class BatchingProcessor
    Inherits Batching.Template
    Private argument As New TemplateArgumentManager

    Public Images As New List(Of String)

    Public ZippedFile As String
    Public BatchFile_Subfolder As String

    Private BatchLog As New Batching.Log
    Private params As New BasicParameters

#Region "Properties"
    Public ReadOnly Property BatchFile As String
        Get
            Return String.Format("{0}\{1}", Path.GetDirectoryName(ZippedFile), Path.GetFileNameWithoutExtension(ZippedFile))
        End Get
    End Property

    Public ReadOnly Property BatchFileInfo As DirectoryInfo
        Get
            Return New DirectoryInfo(BatchFile)
        End Get
    End Property

    Public ReadOnly Property BatchFileName As String
        Get
            Return Path.GetFileNameWithoutExtension(BatchFile)
        End Get
    End Property

    Public ReadOnly Property DataPath(Optional additionalFolder As String = "") As String
        Get
            Select Case DataDirectoryFormat
                Case DataDirectoryFormatType.ClientOnly
                    Return String.Format("{0}\{1}\{2}\{3}\{4}\", TargetLocation, Client, Now.ToString(BatchDateFolderName), BatchFileName, additionalFolder)
                Case DataDirectoryFormatType.Client_Job
                    Return String.Format("{0}\{1}\{2}\{3}\{4}\{5}", TargetLocation, Client, Job, Now.ToString(BatchDateFolderName), BatchFileName, additionalFolder)
                Case DataDirectoryFormatType.Client_Job_Type
                    Return String.Format("{0}\{1}\{2}\{3}\{4}\{5}\{6}", TargetLocation, Client, Job, Type, Now.ToString(BatchDateFolderName), BatchFileName, additionalFolder)
                Case DataDirectoryFormatType.Custom
                    Dim value As String = ""
                    Dim codes As String() = CustomDataDirectory.Split("\")
                    For Each code As String In codes
                        value &= "\" & getDefaultValue(code)
                    Next
                    Return String.Format("{0}\{1}\{2}\{3}\{4}\", TargetLocation, value, Now.ToString(BatchDateFolderName), BatchFileName, additionalFolder)
            End Select
        End Get
    End Property

    Public ReadOnly Property LogPath As String
        Get
            '    If Etc1 Then
            'Return String.Format("{0}\CBATCH\{1}\{2}\{3}\", Application.StartupPath, Client, Now.ToString("yyyyMMdd"), BatchFileName)
            '   Else
            '    Return String.Format("{0}\CBATCH\{1}\{2}\{3}\{4}\{5}\", Application.StartupPath, Client, Job, Type, Now.ToString("yyyyMMdd"), BatchFileName)
            '   End If

            Select Case DataDirectoryFormat
                Case DataDirectoryFormatType.ClientOnly
                    Return String.Format("{0}\CBATCH\{1}\{2}\{3}\", Application.StartupPath, Client, Now.ToString(BatchDateFolderName), BatchFileName)
                Case DataDirectoryFormatType.Client_Job
                    Return String.Format("{0}\CBATCH\{1}\{2}\{3}\{4}\", Application.StartupPath, Client, Job, Now.ToString(BatchDateFolderName), BatchFileName)
                Case DataDirectoryFormatType.Client_Job_Type
                    Return String.Format("{0}\CBATCH\{1}\{2}\{3}\{4}\{5}\", Application.StartupPath, Client, Job, Type, Now.ToString(BatchDateFolderName), BatchFileName)
                Case DataDirectoryFormatType.Custom
                    Dim value As String = ""
                    Dim codes As String() = CustomDataDirectory.Split("\")
                    For Each code As String In codes
                        value &= "\" & getDefaultValue(code)
                    Next
                    Return String.Format("{0}\CBATCH\{1}\{2}\{3}\", Application.StartupPath, value, Now.ToString(BatchDateFolderName), BatchFileName)
            End Select
        End Get
    End Property

    Public ReadOnly Property CbatchPath As String
        Get
            Return String.Format("{0}\CBATCH\", Application.StartupPath)
        End Get
    End Property

    Public ReadOnly Property JobCode As String
        Get
            '  If Etc1 Then Return Client

            If Type = "" Then
                If Job = "" Then
                    Return Client
                Else : Return Job
                End If
            Else : Return Type
            End If
        End Get
    End Property

#End Region

    Sub New()

    End Sub

    Sub New(_zippedFile As String, _temp As Batching.Template, _argument As TemplateArgumentManager)
        ZippedFile = _zippedFile
        argument = _argument
        _temp.ExportTemplateData(Me)
    End Sub

    Sub New(_zippedFile As String, _temp As Batching.Template)
        ZippedFile = _zippedFile
        _temp.ExportTemplateData(Me)
    End Sub

    Public Function Execute() As Boolean
        Select Case AllIn
            Case False
                Return mainProcess()
            Case True
                Return process1()
            Case Else
                argument.writeLog(BatchStates.ErrorFound, "No available process.")
                Return False
        End Select
    End Function

#Region "Main Process"
    Private Function mainProcess() As Boolean
        argument.writeLog(BatchStates.Started)
        If Not setup_MP() Then
            Return False
        Else
            argument.writeLog(BatchStates.Batching)
            If Not start_MP() Then
                Return False
            Else
                If Not wrapUp_MP() Then
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Function setup_MP() As Boolean
        Try
            'extract batchfile
            IO.Compression.ZipFile.ExtractToDirectory(ZippedFile, BatchFile)
            'dig subfolders from extracted batchfile
            BatchFile_Subfolder = digSubfolder(BatchFile)
            'create directories
            Directory.CreateDirectory(DataPath)
            Directory.CreateDirectory(CbatchPath)
            Directory.CreateDirectory(LogPath)
            'create database needed
            CBatch.Fullpath = Path.Combine(CbatchPath, JobCode & ".mdb")
            Log.Fullpath = Path.Combine(LogPath, BatchFileInfo.Name & ".mdb")

            CBatch.Create(False)
            Log.Create()

            BatchLog.BatchName = BatchFileInfo.Name
            BatchLog.JobName = Me.ToString

            Directory.CreateDirectory(DataPath(ImageFolderName & "\"))
            Directory.CreateDirectory(DataPath(Entry1FolderName))
            BatchLog.Entry1Folder = DataPath(Entry1FolderName)
            If Not EntryOnly Then
                Directory.CreateDirectory(DataPath(Entry2FolderName))
                Directory.CreateDirectory(DataPath(CompareFolderName))

                BatchLog.Entry2Folder = DataPath(Entry2FolderName)
                BatchLog.CompareFolder = DataPath(CompareFolderName)
            End If

            params.BatchName = BatchFileInfo.Name
            params.DvdName = BatchFileInfo.Parent.Name

            params.BatchPath = TargetLocation
            params.BatchDate = Now
            params.BatchingStart = Now
            BatchLog.BatchDate = Now

            Return True
        Catch ex As Exception
            argument.writeLog(BatchStates.ErrorFound, "Error on Setup: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function start_MP() As Boolean
        Try
            Dim entry1 As New Batching.Database(Data)
            Dim entry2 As New Batching.Database(Data)
            Dim compare As New Batching.Database(Data)

            params.ImagePath = BatchFile_Subfolder

            'get images
            For Each ext As String In SourceImageType.Split("|")
                Images.AddRange(Directory.GetFiles(BatchFile_Subfolder, "*" & ext).ToList)
            Next

            Images.Sort()

            Dim headerCount As Integer
            If HasHeader Then headerCount = 1 * ImagesPerRecord

            params.ImageCount = Images.Count
            params.RecordCount = ((Images.Count - headerCount) * RecordsPerImage) \ ImagesPerRecord

            Dim mdb As Integer = 1
            Dim img As Integer = 1
            For i As Integer = 0 To Images.Count - 1 Step ImagesPerRecord
                'copy image
                getImages(img, i, Images, DataPath(ImageFolderName & "\"))

                'insert process
                If BatchSize * RecordsPerImage = BatchLog.RecordCount Or i = 0 Then

                    'log
                    If Not mdb = 1 Then
                        BatchLog.Log(HasHeader, ImagesPerRecord)
                    End If

                    'create new mdb
                    params.BatchCount = mdb
                    BatchLog.BatchNo = mdb.ToString(DBName)
                    CreateMdb(DataPath(Entry1FolderName & "\"), mdb, entry1)
                    If Not EntryOnly Then
                        CreateMdb(DataPath(Entry2FolderName & "\"), mdb, entry2)
                        CreateMdb(DataPath(CompareFolderName & "\"), mdb, compare)
                    End If
                    mdb += 1

                    If Not ContinousRecordCounting Then
                        params.Record = 0
                    End If
                End If

                params.Record += 1
                BatchLog.RecordCount += RecordsPerImage

                'insert
                insertRecord(entry1)
                If Not EntryOnly Then
                    insertRecord(entry2)
                    insertRecord(compare)
                End If

                insertRecord(Log, Log.Connection)
            Next

            params.DBType = Entry1FolderName
            insertRecord(entry1, True)
            If Not EntryOnly Then
                params.DBType = Entry2FolderName
                insertRecord(entry2, True)
                params.DBType = CompareFolderName
                insertRecord(compare, True)
            End If

            BatchLog.Log(HasHeader, ImagesPerRecord)

            entry1.Dispose()
            entry2.Dispose()
            compare.Dispose()
            Return True
        Catch ex As Exception
            argument.writeLog(BatchStates.ErrorFound, "Error on Batching Process: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function wrapUp_MP() As Boolean
        'insert log
        Try
            params.BatchingEnd = Now

            CBatch.Tables(0).Insert(DefaultValues((From res In CBatch.Tables(0).Fields Where res.DefaultValue <> "" Select res).ToList _
                                                    , params), CBatch.Connection)
            If CreateCSV Then CreateCSVLog(CBatch.Connection)

            BatchLog.Print(LogPath & "\" & BatchLog.BatchName & ".log", EntryOnly)

            'Release Resources
            Data.Dispose()
            CBatch.Dispose()
            Log.Dispose()

            Return True
        Catch ex As Exception
            argument.writeLog(BatchStates.ErrorFound, "Error on Finalizing: " & ex.Message)
            Return False
        Finally
            GC.WaitForPendingFinalizers()
            GC.Collect()

            Dim tries As Integer = 10
            Do Until tries = 0
                Try
                    Threading.Thread.Sleep(1000)
                    Directory.Delete(BatchFile, True)
                    Exit Do
                Catch
                    tries -= 1
                End Try
            Loop
        End Try

    End Function

    Private Sub insertRecord(db As Batching.Database, con As OleDbConnection)
        For t As Short = 0 To db.Tables.Count - 1
            If Not db.Tables(t).Excluded Then
                Dim values As List(Of Batching.Cell) = DefaultValues((From res In db.Tables(t).Fields Where res.DefaultValue <> "" Select res).ToList, params)
                If values.Count > 0 Then
                    db.Tables(t).Insert(values, con)
                End If
            End If
        Next
    End Sub

    Private Sub insertRecord(db As Batching.Database, Optional exclude As Boolean = False)
        For t As Short = 0 To db.Tables.Count - 1
            If db.Tables(t).Excluded = exclude Then
                Dim values As List(Of Batching.Cell) = DefaultValues((From res In db.Tables(t).Fields Where res.DefaultValue <> "" Select res).ToList, params)
                If values.Count > 0 Then
                    Dim nullFlds As List(Of Batching.Field) = (From res In db.Tables(t).Fields Where res.DefaultValue = "" And res.Type = "TEXT" Select res).ToList
                    Dim nullCells As New List(Of Batching.Cell)
                    db.Tables(t).Insert(values, db.Connection)
                    For i As Integer = 0 To nullFlds.Count - 1
                        nullCells.Add(New Batching.Cell(nullFlds(i).Name, ""))
                    Next
                    db.Tables(t).Update(nullCells, values(0).Name & "=" & params.Record, db.Connection)
                End If
            End If
        Next
    End Sub
#End Region

#Region "Process No. 1"
    ''' <summary>
    ''' Specifically for KANTAR-Self Scan
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function process1() As Boolean
        argument.writeLog(BatchStates.Started)
        If Not setup_P1() Then
            Return False
        Else
            argument.writeLog(BatchStates.Batching)
            If Not start_P1() Then
                Return False
            Else
                If Not wrapUp_MP() Then
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Function setup_P1() As Boolean
        Try
            'extract batchfile
            IO.Compression.ZipFile.ExtractToDirectory(ZippedFile, BatchFile)
            'dig subfolders from extracted batchfile
            BatchFile_Subfolder = digSubfolder(BatchFile)
            'create directories
            If Directory.Exists(DataPath) Then Directory.Delete(DataPath, True)
            Directory.CreateDirectory(DataPath)
            Directory.CreateDirectory(CbatchPath)
            Directory.CreateDirectory(LogPath)
            'create database needed
            CBatch.Fullpath = Path.Combine(CbatchPath, JobCode & ".mdb")
            Log.Fullpath = Path.Combine(LogPath, BatchFileInfo.Name & ".mdb")

            CBatch.Create(False)
            Log.Create()

            BatchLog.DataFolder = DataPath
            BatchLog.BatchName = BatchFileInfo.Name
            BatchLog.JobName = Me.ToString

            params.BatchName = BatchFileInfo.Name
            params.DvdName = BatchFileInfo.Parent.Name

            params.BatchPath = TargetLocation
            params.BatchDate = Now
            params.BatchingStart = Now
            BatchLog.BatchDate = Now

            Return True
        Catch ex As Exception
            argument.writeLog(BatchStates.ErrorFound, "Error on Setup: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function start_P1() As Boolean
        Try
            params.ImagePath = BatchFile_Subfolder

            'get images
            For Each ext As String In SourceImageType.Split("|")
                Images.AddRange(Directory.GetFiles(BatchFile_Subfolder, "*" & ext).ToList)
            Next

            Images.Sort()

            params.ImageCount = Images.Count
            params.RecordCount = ((Images.Count - 1) * RecordsPerImage) \ ImagesPerRecord

            Dim mdb As Integer = 1
            Dim img As Integer = 1
            Dim bat As Integer = 1
            Dim primaryImage As String = Nothing
            For i As Integer = 0 To Images.Count - 1 Step ImagesPerRecord
                'insert process
                If (BatchSize <= BatchLog.RecordCount And (primaryImage Is Nothing OrElse Not continuation(primaryImage, Images(i)))) Or i = 0 Then
                    'log
                    If Not bat = 1 Then
                        BatchLog.Log(HasHeader, ImagesPerRecord)
                    End If

                    BatchLog.BatchNo = bat.ToString(BatchesFolderName)
                    params.BatchCount = bat
                    Directory.CreateDirectory(DataPath(BatchLog.BatchNo)) : bat += 1
                End If

                'copy image
                getImages(img, i, Images, DataPath(BatchLog.BatchNo) & "\")

                '  If primaryImage Is Nothing OrElse Not continuation(primaryImage, Images(i)) Then
                primaryImage = Images(i)
                CreateMdb(DataPath(BatchLog.BatchNo & "\"), mdb, Data) : mdb += 1
                BatchLog.RecordCount += 1
                ' End If

                'update counts
                params.Record += 1

                'insert
                For t As Int32 = 0 To Data.Tables.Count - 1
                    If Not Data.Tables(t).Excluded Then
                        Data.Tables(t).Insert(DefaultValues((From res In Data.Tables(t).Fields Where res.DefaultValue <> "" Select res).ToList _
                                                   , params), Data.Connection)
                    End If
                Next

                For t As Int32 = 0 To Log.Tables.Count - 1
                    If Not Log.Tables(t).Excluded Then
                        Log.Tables(t).Insert(DefaultValues((From res In Log.Tables(t).Fields Where res.DefaultValue <> "" Select res).ToList _
                                                       , params), Log.Connection)
                    End If
                Next
            Next

            For t As Int32 = 0 To Data.Tables.Count - 1
                If Data.Tables(t).Excluded Then
                    Data.Tables(t).Insert(DefaultValues((From res In Data.Tables(t).Fields Where res.DefaultValue <> "" Select res).ToList _
                                               , params), Data.Connection)
                End If
            Next

            BatchLog.Log(HasHeader, ImagesPerRecord)
            Return True
        Catch ex As Exception
            argument.writeLog(BatchStates.ErrorFound, "Error on Proccess: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function continuation(primaryImage As String, currentImage As String) As Boolean
        Dim prim As String() = Path.GetFileNameWithoutExtension(primaryImage).Split("_")
        Dim curr As String() = Path.GetFileNameWithoutExtension(currentImage).Split("_")

        If Not prim(0) = curr(0) Then Return False
        If Not prim(1) = curr(1) Then Return False
        If Not prim(3) = curr(3) Then Return False

        Return True
    End Function
#End Region

    Private Function getImages(ByRef imgidx As Integer, loopidx As Integer, images As List(Of String), destFolderName As String) As Boolean
        Try
            If ImagesPerRecord >= 1 Then
                params.Image001 = imgidx.ToString(ImageFileName) & TargetImageType
                params.OImage001 = Path.GetFileName(images(loopidx))
                File.Copy(images(loopidx), destFolderName & params.Image001, True) : imgidx += 1
            End If
            If ImagesPerRecord >= 2 Then
                params.Image002 = imgidx.ToString(ImageFileName) & TargetImageType
                params.OImage002 = Path.GetFileName(images(loopidx + 1))
                File.Copy(images(loopidx + 1), destFolderName & params.Image002, True) : imgidx += 1
            End If
            If ImagesPerRecord >= 3 Then
                params.Image003 = imgidx.ToString(ImageFileName) & TargetImageType
                params.OImage003 = Path.GetFileName(images(loopidx + 2))
                File.Copy(images(loopidx + 2), destFolderName & params.Image003, True) : imgidx += 1
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function CreateMdb(path As String, ByRef mdb As Integer, dt As Batching.Database)
        Try
            dt.Dispose()
            params.DBname = mdb.ToString(DBName)
            params.DBFullName = path & params.DBname & ".mdb"

            dt.Fullpath = params.DBFullName
            dt.Create()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function digSubfolder(dir As String) As String
        Dim valid As Boolean
        While Not valid
            Dim filecount As Integer = 0
            For Each ext As String In SourceImageType.Split("|")
                filecount += Directory.GetFiles(dir, "*" & ext).Length
            Next

            If Not filecount = 0 Then
                valid = True
            Else : dir = Directory.GetDirectories(dir)(0)
            End If
        End While
        Return dir
    End Function

    Private Function DefaultValues(fields As List(Of Batching.Field), parameters As BasicParameters) As List(Of Batching.Cell)
        Dim p_cell As Batching.Cell = Nothing
        Dim p_cells As New List(Of Batching.Cell)

        For i As Integer = 0 To fields.Count - 1
            p_cell = New Batching.Cell(fields(i).Name)
            p_cell.Value = getDefaultValue(fields(i).DefaultValue, parameters)
            p_cells.Add(p_cell)
        Next
        Return p_cells
    End Function

    Private Function getDefaultValue(defaultValue As String, parameters As BasicParameters) As String
        Dim result As String = defaultValue
        Dim splittedString As String() = defaultValue.Split("/")
        Dim code As String = splittedString(0)
        Dim frmt As String = ""
        Dim mustEncrypt As Boolean
        If splittedString.Length > 2 Then
            frmt = splittedString(1)
            mustEncrypt = True
        ElseIf splittedString.Length > 1 Then
            frmt = splittedString(1)
        End If
        Select Case code
            '-------------INTEGERS----------------
            Case "i0000", "i000" 'record
                result = parameters.Record
            Case "i0001", "i001" 'Image count
                result = parameters.ImageCount.ToString(frmt)
            Case "i0002", "i002" 'Record Count
                result = parameters.RecordCount.ToString(frmt)
            Case "i0003", "i003" ' Batch Size
                result = BatchSize.ToString(frmt)
            Case "i0004", "i004" 'Batch Count
                result = parameters.BatchCount.ToString(frmt)
            Case "i0005", "i005" 'page
                result = countPage(Path.Combine(parameters.ImagePath, parameters.OImage001))

                '------------PROPERTIES---------------
            Case "p0000", "p000" 'Client    
                result = Client
            Case "p0001", "p001" 'Job
                result = Job
            Case "p0002", "p002" 'Type 
                result = JobCode

                '-----------------------DATE/TIME/DATETIME----------
            Case "d0001", "d001" 'batch date
                If Not frmt = "" Then
                    result = parameters.BatchDate.ToString(frmt)
                Else
                    result = parameters.BatchDate.ToString("yyyyMMdd")
                End If
            Case "d0002", "d002" 'batching start
                result = parameters.BatchingStart.ToString("G")
            Case "d0003", "d003" 'batching end
                result = parameters.BatchingEnd.ToString("G")
            Case "d0004", "d004" 'elapse time
                result = parameters.ElapseTime

                '-----------------CHARACTERS----------------
            Case "c0001", "c0001-1", "c001", "c001-1" 'original image 001
                result = parameters.OImage001
            Case "c0001f", "c0001f-1", "c001f", "c001f-1" 'image 001
                result = parameters.Image001
            Case "c0001r", "c0001r-1", "c001r", "c001r-1" 'refimage 001
                result = parameters.OImage001.Substring(parameters.OImage001.Length - 11) 'parameters.Image001
            Case "c0001-2", "c001-2" 'original image 002
                result = parameters.OImage002
            Case "c0001f-2", "c001f-2" 'image 002
                result = parameters.Image002
            Case "c0001r-2", "c001r-2" 'refimage 002
                result = parameters.OImage002.Substring(parameters.OImage002.Length - 11)
            Case "c0001-3", "c001-3" 'original image 003
                result = parameters.OImage003
            Case "c0001f-3", "c001f-3" 'image 003
                result = parameters.Image003
            Case "c0001r-3", "c001r-3" 'refimage 003
                result = parameters.OImage003.Substring(parameters.OImage003.Length - 11)
            Case "c0002", "c002" 'DB
                result = parameters.DBname
            Case "c002f" 'DB fullname
                result = parameters.DBFullName
            Case "c0003", "c003" 'Zipfile
                result = parameters.BatchName
            Case "c0004", "c004" 'dvdName
                result = parameters.DvdName
            Case "c005" 'Batch Path
                result = parameters.BatchPath
            Case "c006" 'Image Path
                result = parameters.ImagePath
            Case "c007" ' DB type ex. Entry1, Entry2, Compare
                result = parameters.DBType
            Case Else
                result = code
        End Select

        'Special Codes
        If code(0) = "s" Then
            Dim splitter As String = code(1)
            Dim idx As String = code(2)
            Dim otherFormat As String = ""
            If code.Length > 6 Then
                otherFormat = code.Substring(6, code.Length - 6)
            End If
            Select Case code.Substring(3, 3)
                Case "001" 'Barcode
                    result = parameters.OImage001.Split(splitter)(idx)
                Case "002" 'Shipment Date
                    Dim p_date As Date = Nothing
                    If splitter = "_" Then
                        If Date.TryParseExact(parameters.BatchName.Split(splitter)(idx), frmt, New CultureInfo("en-US"), DateTimeStyles.None, p_date) Then
                            result = p_date.ToString("MMdd")
                        End If
                    ElseIf splitter = "." Then
                        Dim p_values As String() = parameters.BatchName.Split(splitter)
                        If frmt = "0" Then
                            result = p_values(2) & p_values(1)
                        End If
                    ElseIf splitter = "," Then
                        Dim p_values As String() = otherFormat.Split(splitter)
                        If p_values.Length = 2 Then
                            If Date.TryParseExact(parameters.BatchName.Substring(p_values(0), p_values(1)), frmt, New CultureInfo("en-US"), DateTimeStyles.None, p_date) Then
                                result = p_date.ToString(frmt)
                            End If
                        End If
                    End If
                Case "003"
                Case Else
                    result = code
            End Select
        End If

        If mustEncrypt Then
            Return Encrypt(result, keyStr)
        Else
            Return result
        End If
    End Function
    Private Function getDefaultValue(defaultValue As String) As String
        Dim result As String = defaultValue
        Dim splittedString As String() = defaultValue.Split("/")
        Dim code As String = splittedString(0)
        Dim frmt As String = ""
        Dim mustEncrypt As Boolean
        If splittedString.Length > 2 Then
            frmt = splittedString(1)
            mustEncrypt = True
        ElseIf splittedString.Length > 1 Then
            frmt = splittedString(1)
        End If
        Select Case code
            Case "p0000", "p000" 'Client    
                result = Client
            Case "p0001", "p001" 'Job
                result = Job
            Case "p0002", "p002" 'Type 
                result = JobCode

            Case Else
                result = code
        End Select

        If mustEncrypt Then
            Return Encrypt(result, keyStr)
        Else
            Return result
        End If
    End Function

    Private Function countPage(imgpath As String) As Integer
        Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(imgpath)
        Dim pageCount As Integer = img.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page)
        img.Dispose()

        Return pageCount
    End Function

    Public Sub CreateCSVLog(conn As OleDbConnection)
        Dim cbatName As String = CBatch.Tables(0).Name
        Dim dbCommand As OleDb.OleDbCommand
        Dim dbAdapter As OleDb.OleDbDataAdapter
        dbCommand = New OleDb.OleDbCommand("SELECT * FROM [" & cbatName & "]", conn)
        dbAdapter = New OleDb.OleDbDataAdapter
        dbAdapter.SelectCommand = dbCommand
        Dim dbTable As New DataTable
        dbAdapter.Fill(dbTable)

        Dim sw As New System.IO.StreamWriter(CbatchPath & "\" & cbatName & ".csv")
        Dim columnHeaders As New System.Text.StringBuilder
        For Each col As DataColumn In dbTable.Columns
            If columnHeaders.ToString.Length > 0 Then columnHeaders.Append(",")
            columnHeaders.Append("""" & col.ColumnName & """")
        Next
        sw.WriteLine(columnHeaders.ToString)
        Dim dataValues As New System.Text.StringBuilder
        For Each row As DataRow In dbTable.Rows
            For Each col As DataColumn In dbTable.Columns
                If dataValues.ToString.Length > 0 Then dataValues.Append(",")
                dataValues.Append("""" & row(col.ColumnName).ToString & """")
            Next
            sw.WriteLine(dataValues.ToString)
            dataValues = New System.Text.StringBuilder
        Next
        sw.Close()
    End Sub

    Private Class BasicParameters
        Public Record As Integer

        Public BatchCount As Integer
        Public ImageCount As Integer
        Public RecordCount As Integer

        Public DBname As String
        Public DBFullName As String
        Public DBType As String

        Public BatchDate As Date
        Public BatchingStart As Date
        Public BatchingEnd As Date
        Public ReadOnly Property ElapseTime As String
            Get
                Dim ts As TimeSpan = (BatchingEnd - BatchingStart)
                Return String.Format("{0}:{1}:{2}", ts.Hours, ts.Minutes, ts.Seconds)
            End Get
        End Property

        Public BatchName As String
        Public DvdName As String

        Public ImagePath As String
        Public BatchPath As String

        Public Image001 As String
        Public OImage001 As String
        Public Image002 As String
        Public OImage002 As String
        Public Image003 As String
        Public OImage003 As String


    End Class


#Region "Methods from customized jobs"
    Public Const keyStr As String = "KI VERSION 1.0"
    Public Function Encrypt(ByVal str As String, ByVal key As String)
        Encrypt = ToHexDump(CryptRC4(str, key))
    End Function

    Public Function Decrypt(ByVal encrypted As String, ByVal key As String)
        Decrypt = CryptRC4(FromHexDump(encrypted), key)
    End Function

    Public Function CryptRC4(sText As String, sKey As String) As String
        CryptRC4 = ""
        Dim baS(0 To 255) As Byte
        Dim baK(0 To 255) As Byte
        Dim bytSwap As Byte
        Dim lI As Long
        Dim lJ As Long
        Dim lIdx As Long

        For lIdx = 0 To 255
            baS(lIdx) = lIdx
            baK(lIdx) = Asc(Mid$(sKey, 1 + (lIdx Mod Len(sKey)), 1))
        Next
        For lI = 0 To 255
            lJ = (lJ + baS(lI) + baK(lI)) Mod 256
            bytSwap = baS(lI)
            baS(lI) = baS(lJ)
            baS(lJ) = bytSwap
        Next
        lI = 0
        lJ = 0
        For lIdx = 1 To Len(sText)
            lI = (lI + 1) Mod 256
            lJ = (lJ + baS(lI)) Mod 256
            bytSwap = baS(lI)
            baS(lI) = baS(lJ)
            baS(lJ) = bytSwap
            CryptRC4 &= Chr((pvCryptXor(baS((CLng(baS(lI)) + baS(lJ)) Mod 256), Asc(Mid$(sText, lIdx, 1)))))
        Next
    End Function

    Private Function pvCryptXor(ByVal lI As Long, ByVal lJ As Long) As Long
        If lI = lJ Then
            pvCryptXor = lJ
        Else
            pvCryptXor = lI Xor lJ
        End If
    End Function

    Public Function ToHexDump(sText As String) As String
        Dim lIdx As Long
        Dim str As String = ""
        For lIdx = 1 To Len(sText)
            str = str & Microsoft.VisualBasic.Right("0" & Hex(Asc(Mid(sText, lIdx, 1))), 2)
        Next
        Return str
    End Function

    Public Function FromHexDump(sText As String) As String
        Dim lIdx As Long
        Dim str As String = ""
        For lIdx = 1 To Len(sText) Step 2
            str = str & Chr(CLng("&H" & Mid(sText, lIdx, 2)))
        Next
        Return str
    End Function

#End Region
End Class
