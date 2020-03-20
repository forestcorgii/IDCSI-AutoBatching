Imports AutoBatchingLibrary.Automation
Imports AutoBatchingLibrary.Automation.Batching
Imports System.IO

Public Class Gestalt

    Public CurrentTemplate As Template
    Public AddingRowInCode As Boolean
    Public OnBrowse As Boolean

    Private currentTableData As String
    Private currentTableLog As String
    Private currentTableCbatch As String


#Region "Properties"
    Public Property DownloadDateFormat As String
        Get
            Return CurrentTemplate.DownloadDateFormat
        End Get
        Set(value As String)
            CurrentTemplate.DownloadDateFormat = value
        End Set
    End Property

    Public Property HasHeader As Boolean
        Get
            Return CurrentTemplate.HasHeader
        End Get
        Set(value As Boolean)
            CurrentTemplate.HasHeader = value
        End Set
    End Property
    Public Property ContinousRecordCounting As Boolean
        Get
            Return CurrentTemplate.ContinousRecordCounting
        End Get
        Set(value As Boolean)
            CurrentTemplate.ContinousRecordCounting = value
        End Set
    End Property
    Public Property SourceImageType As String
        Get
            Return CurrentTemplate.SourceImageType
        End Get
        Set(value As String)
            CurrentTemplate.SourceImageType = value
        End Set
    End Property

    Public Property TargetImageType As String
        Get
            Return CurrentTemplate.TargetImageType
        End Get
        Set(value As String)
            CurrentTemplate.TargetImageType = value
        End Set
    End Property

    Public Property ImageFileName As String
        Get
            Return CurrentTemplate.ImageFileName
        End Get
        Set(value As String)
            CurrentTemplate.ImageFileName = value
        End Set
    End Property

    Public Property DBName As String
        Get
            Return CurrentTemplate.DBName
        End Get
        Set(value As String)
            CurrentTemplate.DBName = value
        End Set
    End Property

    Public Property BatchesName As String
        Get
            Return CurrentTemplate.BatchesFolderName
        End Get
        Set(value As String)
            CurrentTemplate.BatchesFolderName = value
        End Set
    End Property

    Public Property BatchDateFolderName As String
        Get
            If Not CurrentTemplate.BatchDateFolderName = "" Then
                Return CurrentTemplate.BatchDateFolderName
            Else : Return "ddMMyyyy"
            End If
        End Get
        Set(value As String)
            CurrentTemplate.BatchDateFolderName = value
        End Set
    End Property

    Public Property CustomDataDirectoryFormat As String
        Get
            Return CurrentTemplate.CustomDataDirectory
        End Get
        Set(value As String)
            CurrentTemplate.CustomDataDirectory = value
        End Set
    End Property

    Public Property Entry1Name As String
        Get
            Return CurrentTemplate.Entry1FolderName
        End Get
        Set(value As String)
            CurrentTemplate.Entry1FolderName = value
        End Set
    End Property

    Public Property Entry2Name As String
        Get
            Return CurrentTemplate.Entry2FolderName
        End Get
        Set(value As String)
            CurrentTemplate.Entry2FolderName = value
        End Set
    End Property

    Public Property CompareName As String
        Get
            Return CurrentTemplate.CompareFolderName
        End Get
        Set(value As String)
            CurrentTemplate.CompareFolderName = value
        End Set
    End Property

    Public Property ImageFolderName As String
        Get
            Return CurrentTemplate.ImageFolderName
        End Get
        Set(value As String)
            CurrentTemplate.ImageFolderName = value
        End Set
    End Property

    Public Property BatchSize As Integer
        Get
            Return CurrentTemplate.BatchSize
        End Get
        Set(value As Integer)
            CurrentTemplate.BatchSize = value
        End Set
    End Property

    Public Property ImagesPerRecord As Integer
        Get
            Return CurrentTemplate.ImagesPerRecord
        End Get
        Set(value As Integer)
            CurrentTemplate.ImagesPerRecord = value
        End Set
    End Property

    Public Property RecordsPerImage As Integer
        Get
            Return CurrentTemplate.RecordsPerImage
        End Get
        Set(value As Integer)
            CurrentTemplate.RecordsPerImage = value
        End Set
    End Property



    Public Property Client As String
        Get
            Return CurrentTemplate.Client
        End Get
        Set(value As String)
            CurrentTemplate.Client = value
        End Set
    End Property

    Public Property Job As String
        Get
            Return CurrentTemplate.Job
        End Get
        Set(value As String)
            CurrentTemplate.Job = value
        End Set
    End Property

    Public Property RegexValue As String
        Get
            Return CurrentTemplate.Basis.RegexValue
        End Get
        Set(value As String)
            CurrentTemplate.Basis.RegexValue = value
        End Set
    End Property


    Public Property Type As String
        Get
            Return CurrentTemplate.Type
        End Get
        Set(value As String)
            CurrentTemplate.Type = value
        End Set
    End Property

    Public Property BatchNameBasis As Template.BatchNameBasisType
        Get
            Return CurrentTemplate.Basis.BasisType
        End Get
        Set(value As Template.BatchNameBasisType)
            CurrentTemplate.Basis.BasisType = value
        End Set
    End Property

    Public Property AllIn As Boolean
        Get
            Return CurrentTemplate.AllIn
        End Get
        Set(value As Boolean)
            CurrentTemplate.AllIn = value
        End Set
    End Property

    Public Property EntryOnly As Boolean
        Get
            Return CurrentTemplate.EntryOnly
        End Get
        Set(value As Boolean)
            CurrentTemplate.EntryOnly = value
        End Set
    End Property

    Public Property DataDirectoryFormat As Template.DataDirectoryFormatType
        Get
            Return CurrentTemplate.DataDirectoryFormat
        End Get
        Set(value As Template.DataDirectoryFormatType)
            CurrentTemplate.DataDirectoryFormat = value
        End Set
    End Property

    Public Property CreateCSV As Boolean
        Get
            Return CurrentTemplate.CreateCSV
        End Get
        Set(value As Boolean)
            CurrentTemplate.CreateCSV = value
        End Set
    End Property

    Private Property selectedDataDirectoryFormat As Template.DataDirectoryFormatType
        Get
            If rbtnUseClientOnly.Checked Then
                Return Template.DataDirectoryFormatType.ClientOnly
            ElseIf rbtnUseClientJob.Checked Then
                Return Template.DataDirectoryFormatType.Client_Job
            ElseIf rbtnClientJobType.Checked Then
                Return Template.DataDirectoryFormatType.Client_Job_Type
            ElseIf rbtnCustom.Checked Then
                Return Template.DataDirectoryFormatType.Custom
            Else : Return Template.DataDirectoryFormatType.Client_Job_Type
            End If
        End Get
        Set(value As Template.DataDirectoryFormatType)
            Select Case value
                Case Template.DataDirectoryFormatType.ClientOnly
                    rbtnUseClientOnly.Checked = True
                Case Template.DataDirectoryFormatType.Client_Job
                    rbtnUseClientJob.Checked = True
                Case Template.DataDirectoryFormatType.Client_Job_Type
                    rbtnClientJobType.Checked = True
                Case Template.DataDirectoryFormatType.Custom
                    rbtnCustom.Checked = True
            End Select
        End Set
    End Property

    Private Property selectedBatchNameBasis As Template.BatchNameBasisType
        Get
            If rbtnRegexBased.Checked Then
                Return Template.BatchNameBasisType.Regex_based
            Else
                Return Template.BatchNameBasisType.None
            End If
        End Get
        Set(value As Template.BatchNameBasisType)
            Select Case value
                Case Template.BatchNameBasisType.Regex_based
                    rbtnRegexBased.Checked = True
                Case Else
                    rbtnNoBasis.Checked = True
            End Select
        End Set
    End Property
#End Region

#Region "Event Handler"
    Private Sub dgv_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvData.KeyDown
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim idx As Integer = dgv.CurrentRow.Index
        If e.Control And e.KeyCode = Keys.Down Then
            If idx < dgv.Rows.Count - 1 Then
                dgv.Rows.InsertCopy(idx, idx + 1)
            End If
        ElseIf e.Control And e.KeyCode = Keys.Down Then
            If idx > 0 Then
                dgv.Rows.InsertCopy(idx, idx - 1)
            End If
        End If
    End Sub

    Private Sub dgvData_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvData.RowsAdded
        If Not AddingRowInCode Then DirectCast(sender, DataGridView).Rows(e.RowIndex).Cells(1).Value = "TEXT"
    End Sub

    Private Sub Gestalt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not CurrentTemplate.ToString = "" Then
            Dim res As MsgBoxResult = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel)
            If res = MsgBoxResult.Yes Then
                CurrentTemplate.WriteToFile()
            ElseIf res = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

     Private Sub Gestalt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " (" & Application.ProductVersion & ")"
        init()
    End Sub

   Private Sub cb_DropDown(sender As Object, e As EventArgs) Handles cbCbatch.DropDown, cbData.DropDown, cbLog.DropDown
        Select Case DirectCast(sender, ComboBox).Name
            Case cbData.Name
                saveTable(cbData, GenerateTable(cbData.Text, dgvData, chbExData.Checked), CurrentTemplate.Data, currentTableData)
            Case cbCbatch.Name
                saveTable(cbCbatch, GenerateTable(cbCbatch.Text, dgvCbatch, chbExCbatch.Checked), CurrentTemplate.CBatch, currentTableCbatch)
            Case cbLog.Name
                saveTable(cbLog, GenerateTable(cbLog.Text, dgvLog, chbExLog.Checked), CurrentTemplate.Log, currentTableLog)
        End Select
    End Sub

    Private Sub cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCbatch.SelectedIndexChanged, cbData.SelectedIndexChanged, cbLog.SelectedIndexChanged
        Select Case DirectCast(sender, ComboBox).Name
            Case cbData.Name
                currentTableData = cbData.SelectedItem.ToString
                loadTable(DirectCast(cbData.SelectedItem, Table), dgvData, chbExData)
            Case cbCbatch.Name
                currentTableCbatch = cbCbatch.SelectedItem.ToString
                loadTable(DirectCast(cbCbatch.SelectedItem, Table), dgvCbatch, chbExCbatch)
            Case cbLog.Name
                currentTableLog = cbLog.SelectedItem.ToString
                loadTable(DirectCast(cbLog.SelectedItem, Table), dgvLog, chbExLog)
        End Select
    End Sub

    Private Sub lstTemplates_LostFocus(sender As Object, e As EventArgs) Handles lstTemplates.LostFocus
        OnBrowse = False
    End Sub

    Private Sub lstTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTemplates.SelectedIndexChanged
        If Not OnBrowse Then
            copyChanges()
            CurrentTemplate.WriteToFile()
            If CurrentTemplate.TemplateLocation IsNot Nothing And Not CurrentTemplate.TemplateLocation = "" Then
                If Not Path.GetFileNameWithoutExtension(CurrentTemplate.TemplateLocation) = CurrentTemplate.ToString Then
                    FileSystem.Rename(CurrentTemplate.TemplateLocation, Path.GetDirectoryName(CurrentTemplate.TemplateLocation) & _
                    "\" & CurrentTemplate.ToString & ".template.xml")
                End If
            End If
            OnBrowse = True
        End If
        If lstTemplates.SelectedItem IsNot Nothing Then
            CurrentTemplate = DirectCast(lstTemplates.SelectedItem, Template)
            loadTemplate()
        End If

    End Sub

    Private Sub btnSaveTemplate_Click(sender As Object, e As EventArgs) Handles mnSaveTemplate.Click, mnSaveTemplateAs.Click
        OnBrowse = True
        copyChanges()
        If CurrentTemplate IsNot Nothing AndAlso Not lbTemplatePath.Text = "" Then
            If CurrentTemplate.TemplateLocation = "" Or sender.Name = mnSaveTemplateAs.Name Then
                CurrentTemplate.TemplateLocation = Path.Combine(lbTemplatePath.Text, CurrentTemplate.ToString & Template.Extension)
            End If

            CurrentTemplate.WriteToFile()
            collectTemplate(lbTemplatePath.Text)
            MsgBox("Saved.")
        Else : MsgBox("Error in the Current Template or the Template path.")
        End If
    End Sub

    Private Sub lstTables_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstTables.MouseDoubleClick
        If frmPickTable.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim p_cb As ComboBox = DirectCast(frmPickTable.SelectedCB, ComboBox)
            Dim p_tbl As Table = DirectCast(lstTables.SelectedItem, Table)
            saveTable(p_cb, p_tbl, frmPickTable.SelectedDB, p_tbl.Name)
        End If
    End Sub

    Private Sub mnImportTables_Click(sender As Object, e As EventArgs) Handles mnImportTables.Click
        If Not OFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            If Not OFD.FileNames.Length = 0 Then
                lstTables.Items.Clear()
                For Each t_mdb As String In OFD.FileNames
                    Dim t_con As OleDb.OleDbConnection = MDB.Open(t_mdb)
                    t_con.Open()

                    Dim t_tables As List(Of String) = MDB.Tables(t_con)
                    For Each t_tbl As String In t_tables
                        Dim t_dt As DataTable = MDB.ConvertToDT("SELECT * FROM [" & t_tbl & "]", t_con)
                        Dim t_batTable As New Table(t_tbl)
                        For Each dc As DataColumn In t_dt.Columns
                            Dim l As Integer = 0
                            If dc.MaxLength <= 255 And Not dc.MaxLength < 0 Then
                                l = dc.MaxLength
                            End If
                            t_batTable.Fields.Add(New Field(dc.ColumnName, dc.DataType.Name, l, ""))
                        Next
                        lstTables.Items.Add(t_batTable)
                        t_con.Close()
                    Next
                Next
            End If
        End If
    End Sub

    Private Sub mnTemplateDirectory_Click(sender As Object, e As EventArgs) Handles mnTemplateDirectory.Click
        If Not FBD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            collectTemplate(FBD.SelectedPath)

            My.Settings.SavedTemplatePath = FBD.SelectedPath
            My.Settings.Save()
        End If
    End Sub

    Private Sub mnRefresh_Click(sender As Object, e As EventArgs) Handles mnRefresh.Click
        ' CurrentTemplate = New Template

        ' loadTemplate()

        'cbData.Items.Clear()
        'cbCbatch.Items.Clear()
        'cbLog.Items.Clear()

        'dgvData.Rows.Clear()
        'dgvCbatch.Rows.Clear()
        'dgvLog.Rows.Clear()

        collectTemplate(My.Settings.SavedTemplatePath)
    End Sub

    Private Sub mnDeleteTable_Click(sender As Object, e As EventArgs) Handles mnDeleteTable.Click
        If frmPickTable.ShowDialog() = Windows.Forms.DialogResult.OK _
         AndAlso MsgBox("Are you sure you want to proceed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim p_cb As ComboBox = frmPickTable.SelectedCB
            Dim tblCollection As Database = frmPickTable.SelectedDB
            Dim tbl As Table = DirectCast(p_cb.SelectedItem, Table)

            tblCollection.Tables.Remove(tbl)
            p_cb.Items.Clear()
            p_cb.Items.AddRange(tblCollection.Tables.ToArray)

            If Not p_cb.Items.Count = 0 Then
                p_cb.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub mnDeleteTemplate_Click(sender As Object, e As EventArgs) Handles mnDeleteTemplate.Click
        If MsgBox("Current Template will be moved to the deleted folder, Continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Directory.CreateDirectory(lbTemplatePath.Text & "\Deleted Template")
            File.Copy(CurrentTemplate.TemplateLocation, lbTemplatePath.Text & "\Deleted Template\" & Path.GetFileName(CurrentTemplate.TemplateLocation), True)
            File.Delete(CurrentTemplate.TemplateLocation)

            CurrentTemplate = New Template
            Dim tmpIdx As Integer = lstTemplates.SelectedIndex
            lstTemplates.Items.Remove(lstTemplates.SelectedItem)
            If lstTemplates.Items.Count - 1 < tmpIdx Then tmpIdx -= 1
            lstTemplates.SelectedIndex = tmpIdx
        End If
    End Sub
#End Region

    Public Sub init()
        OnBrowse = True
        CurrentTemplate = New Template
        If Directory.Exists(My.Settings.SavedTemplatePath) Then
            collectTemplate(My.Settings.SavedTemplatePath)
        Else
            mnTemplateDirectory.PerformClick()
        End If
    End Sub

    Private Sub collectTemplate(templateFolder As String)
        Dim tmpidx As Integer = lstTemplates.SelectedIndex
        lstTemplates.Items.Clear()
        lbTemplatePath.Text = templateFolder

        If Not Directory.GetFiles(templateFolder, "*" & Template.Extension).Length = 0 Then
            lstTemplates.Items.AddRange(Batching.CollectTemplate(templateFolder).ToArray)

            If lstTemplates.SelectedItem IsNot Nothing Then
                lstTemplates.SelectedIndex = tmpidx
            End If
        End If
    End Sub

    Private Sub saveTable(cb As ComboBox, tbl As Table, ByRef tblCollection As Database, Optional currentTableName As String = "NONE")
        If tbl IsNot Nothing AndAlso tbl.Fields.Count > 1 Then
            If tblCollection.Tables.Find(Function(x As Table) x.Name = currentTableName) IsNot Nothing Then
                For i As Integer = 0 To cb.Items.Count - 1
                    If cb.Items(i).ToString = currentTableName Then
                        cb.Items(i) = tbl
                        cb.SelectedIndex = i
                    End If
                Next
                For i As Integer = 0 To tblCollection.Tables.Count - 1
                    If tblCollection.Tables(i).Name = currentTableName Then
                        tblCollection.Tables(i) = tbl
                    End If
                Next
            Else
                cb.Items.Add(tbl)
                tblCollection.Tables.Add(tbl)
                cb.SelectedIndex = cb.Items.Count - 1
            End If
            cb_SelectedIndexChanged(cb, Nothing)
        End If
    End Sub

    Private Sub loadTemplate()
        dgvData.Rows.Clear()
        dgvCbatch.Rows.Clear()
        dgvLog.Rows.Clear()

        cbData.Items.Clear()
        cbCbatch.Items.Clear()
        cbLog.Items.Clear()

        With CurrentTemplate
            cbSourceImageType.Text = SourceImageType
            cbTargetImageType.Text = TargetImageType

            tbClient.Text = Client
            tbJob.Text = Job
            tbType.Text = Type

            tbImgFileName.Text = .ImageFileName
            tbDBFileName.Text = .DBName

            tbBatFolderName.Text = .BatchesFolderName
            tbBatchDateFolderName.Text = BatchDateFolderName
            tbE1FolderName.Text = .Entry1FolderName
            tbE2FolderName.Text = .Entry2FolderName
            tbComFolderName.Text = .CompareFolderName
            tbImgFolderName.Text = .ImageFolderName
            tbCustDtDir.Text = CustomDataDirectoryFormat

            numDefBatchSize.Value = .BatchSize
            numImgPerRec.Value = .ImagesPerRecord
            numRecPerImg.Value = .RecordsPerImage

            selectedDataDirectoryFormat = .DataDirectoryFormat
            chbE1Only.Checked = .EntryOnly
            chbHasCSV.Checked = .CreateCSV
            chbAllin.Checked = .AllIn
            chbHasHeader.Checked = .HasHeader
            selectedBatchNameBasis = .Basis.BasisType
            tbRegex.Text = .Basis.RegexValue
            chbConRecCount.Checked = .ContinousRecordCounting

            tbDateFormat.Text = .DownloadDateFormat

            loadTables(.Data.Tables, cbData)
            loadTables(.CBatch.Tables, cbCbatch)
            loadTables(.Log.Tables, cbLog)
        End With
    End Sub

    Private Sub loadTable(tbl As Table, dgv As DataGridView, chb As CheckBox)
        dgv.Rows.Clear()
        If tbl IsNot Nothing Then
            chb.Checked = tbl.Excluded
            AddingRowInCode = True
            For i As Integer = 0 To tbl.Fields.Count - 1
                dgv.Rows.Add(tbl.Fields(i).ToDatagridviewRow(dgv)) '.Name, tbl.Fields(i).Type)
            Next
            AddingRowInCode = False
        End If
    End Sub


    Private Sub loadTables(tables As List(Of Table), cb As ComboBox)
        cb.Items.Clear()
        cb.Text = ""
        If Not tables.Count = 0 Then
            cb.Items.AddRange(tables.ToArray)
            cb.SelectedIndex = 0
        End If
    End Sub

    Private Sub copyChanges()
        saveTable(cbCbatch, GenerateTable(cbCbatch.Text, dgvCbatch, chbExCbatch.Checked), CurrentTemplate.CBatch, currentTableCbatch)
        saveTable(cbData, GenerateTable(cbData.Text, dgvData, chbExData.Checked), CurrentTemplate.Data, currentTableData)
        saveTable(cbLog, GenerateTable(cbLog.Text, dgvLog, chbExLog.Checked), CurrentTemplate.Log, currentTableLog)

        BatchSize = numDefBatchSize.Value
        ImagesPerRecord = numImgPerRec.Value
        RecordsPerImage = numRecPerImg.Value
        SourceImageType = cbSourceImageType.Text
        TargetImageType = cbTargetImageType.Text

        Client = tbClient.Text
        Job = tbJob.Text
        Type = tbType.Text

        RegexValue = tbRegex.Text

        ImageFileName = tbImgFileName.Text
        DBName = tbDBFileName.Text
        BatchesName = tbBatFolderName.Text
        BatchDateFolderName = tbBatchDateFolderName.Text
        Entry1Name = tbE1FolderName.Text
        Entry2Name = tbE2FolderName.Text
        CompareName = tbComFolderName.Text
        ImageFolderName = tbImgFolderName.Text
        CustomDataDirectoryFormat = tbCustDtDir.Text

        DataDirectoryFormat = selectedDataDirectoryFormat
        EntryOnly = chbE1Only.Checked
        CreateCSV = chbHasCSV.Checked
        AllIn = chbAllin.Checked
        BatchNameBasis = selectedBatchNameBasis
        HasHeader = chbHasHeader.Checked
        ContinousRecordCounting = chbConRecCount.Checked

        DownloadDateFormat = tbDateFormat.Text
    End Sub

    Private Sub mnHelp_Click(sender As Object, e As EventArgs) Handles mnHelp.Click
        frmReminders.Show()
    End Sub

    Private Sub chbAllin_CheckedChanged(sender As Object, e As EventArgs) Handles chbAllin.CheckedChanged
        With chbAllin
            tbE1FolderName.Enabled = Not .Checked
            tbE2FolderName.Enabled = Not .Checked
            tbComFolderName.Enabled = Not .Checked
            tbImgFolderName.Enabled = Not .Checked
            tbBatFolderName.Enabled = .Checked
        End With
    End Sub

    Private Sub rbtnCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCustom.CheckedChanged
        tbCustDtDir.Enabled = rbtnCustom.Checked
    End Sub

    Private Sub rbtnNoBasis_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNoBasis.CheckedChanged
        tbRegex.Enabled = Not rbtnNoBasis.Checked
    End Sub
End Class
