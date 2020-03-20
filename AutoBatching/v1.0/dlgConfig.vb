Imports System.Windows.Forms
Imports System.Text
Imports System.IO
Imports AutoBatchingLibrary.Automation

Public Class dlgConfig

    Private Sub btnTruncateLogs_Click(sender As Object, e As EventArgs) Handles btnTruncateLogs.Click
        If MsgBox("Are You sure you want to Truncate? All logs will be cleared.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            executeQRY(String.Format("DELETE FROM {0}", Logs_TableName), Main_Connection)
        End If
    End Sub

    Private Sub dlgConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.daystobatch = numDays.Value
        My.Settings.threadcount = numThread.Value
        My.Settings.Save()

    End Sub

    Private Sub dlgConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstItems.Items.Clear()
        lstItems.Items.AddRange(SystemConfig.Items.ToArray)
        If lstItems.Items.Count > 0 Then
            lstItems.SelectedIndex = 0
        End If
        numDays.Value = My.Settings.daystobatch
        numThread.Value = My.Settings.threadcount

        collectExeFile()

        If Directory.Exists(My.Settings.SavedTemplatePath) Then
            collectTemplate(My.Settings.SavedTemplatePath)
        End If
    End Sub

    Private Sub collectExeFile()
        Dim exes As List(Of String) = (From res As String In Directory.GetFiles(ExeDirectory, "*.exe") Select Path.GetFileName(res)).ToList
        tbTemplateExeLoc.AutoCompleteCustomSource.AddRange(exes.ToArray)
        tbBatchingLoc.AutoCompleteCustomSource.AddRange(exes.ToArray)

    End Sub

#Region "Batch Items"
    Private Property currentItem As BatcherInfo
        Get
            If lstItems.SelectedItem IsNot Nothing Then
                Return DirectCast(lstItems.SelectedItem, BatcherInfo)
            Else : Return Nothing
            End If
        End Get
        Set(value As BatcherInfo)
            lstItems.SelectedItem = value
        End Set
    End Property

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        refreshVars()
        tbClient.Select()
    End Sub

    Private Sub refreshVars()
        dgv.Rows.Clear()
        ListedBatchFiles = New List(Of String)

        tbType.Text = ""
        tbTargetDir.Text = ""
        tbRootDir.Text = ""
        tbJob.Text = ""
        tbClient.Text = ""
        tbBatchingLoc.Text = ""
        tbBatchCount.Text = ""
    End Sub


    Private Sub btnSelectDir_Click(sender As Object, e As EventArgs) Handles btnSelectRootDir.Click, btnSelectTargetDir.Click
        If FBD1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select Case DirectCast(sender, Button).Name
                Case "btnSelectRootDir"
                    tbRootDir.Text = ConvertToUNCPath(FBD1.SelectedPath)
                Case "btnSelectTargetDir"
                    tbTargetDir.Text = ConvertToUNCPath(FBD1.SelectedPath)
            End Select
        End If
    End Sub

    Private Sub lstItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItems.SelectedIndexChanged
        If lstItems.SelectedItem IsNot Nothing Then
            With currentItem
                tbClient.Text = .Client
                tbJob.Text = .Job
                tbType.Text = .Type.Replace("|", Chr(13))
                tbRootDir.Text = .RootDirectory
                tbTargetDir.Text = .TargetDirectory
                tbBatchCount.Text = .BatchCount
                tbBatchingLoc.Text = .ExeName
                cbFileType.Text = .FileType

                dgv.Rows.Clear()
                listedTypes.Clear()
                For Each basis As BatchItemBasis1 In .Basis
                    dgv.Rows.Add(basis.Type, basis.Keystring, basis.Substring)
                    listedTypes.Add(basis.Type)
                Next
                fillBasis()
            End With
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '\\DELETE QUERY
        If MsgBox("Are you sure to delete the current item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim _item As BatcherInfo = DirectCast(lstItems.SelectedItem, BatcherInfo)
            Dim condition As String = String.Format("WHERE client='{0}' AND job='{1}' AND type='{2}'", _item.Client, _item.Job, _item.Type)
            executeQRY(String.Format("DELETE FROM {0} {1}", Settings_TableName, condition), Main_Connection)

            lstItems.Items.Remove(lstItems.SelectedItem)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim _item As New BatcherInfo
        With _item
            .Client = tbClient.Text
            .Job = tbJob.Text
            .Type = tbType.Text.Replace(Chr(13), "|")
            .RootDirectory = tbRootDir.Text
            .TargetDirectory = tbTargetDir.Text
            .ExeName = tbBatchingLoc.Text
            .BatchCount = tbBatchCount.Text
            .FileType = cbFileType.Text

            executeQRY(String.Format("DELETE FROM {0} WHERE client='{1}' AND job='{2}'", Settings_Basis_TableName, .Client, .Job), Main_Connection)
            For i As Integer = 0 To dgv.RowCount - 1
                Dim _basis As New BatchItemBasis1
                With dgv.Rows(i)
                    _basis.Type = .Cells(0).Value
                    _basis.Keystring = .Cells(1).Value
                    _basis.Substring = .Cells(2).Value
                End With

                If .Basis.Find(Function(x As BatchItemBasis1) x.Type = _basis.Type) Is Nothing Then '(currentItem Is Nothing OrElse (currentItem IsNot Nothing AndAlso Not currentItem.Types.Contains(_basis.Type)))   Then
                    mdbInsert(Settings_Basis_TableName, Settings_Basis_Fields, New Object() _
                              {_item.Client, _item.Job, _basis.Type, _basis.Keystring, _basis.Substring, _basis.IsValid}, Main_Connection)
                Else
                    Dim condition As String = String.Format("WHERE client='{0}' AND job='{1}' AND type='{2}'", _item.Client, _item.Job, _basis.Type)
                    mdbUpdate(Settings_Basis_TableName, Settings_Basis_Fields, New Object() _
                             {_item.Client, _item.Job, _basis.Type, _basis.Keystring, _basis.Substring, _basis.IsValid}, condition, Main_Connection)
                End If
                If _basis.IsValid Then _item.Basis.Add(_basis)
            Next

            If .isValid Then
                If SystemConfig.Items.Exists(Function(x) x.Client = _item.Client And x.Job = _item.Job) Then
                    '\\UPDATE
                    Dim condition As String = String.Format("WHERE client='{0}' AND job='{1}'", .Client, .Job)
                    mdbUpdate(Settings_TableName, Settings_Fields, _item.toArray, condition, Main_Connection)
                Else
                    '\\INSERT
                    mdbInsert(Settings_TableName, Settings_Fields, _item.toArray, Main_Connection)
                    lstItems.Items.Add(_item)
                End If

                SystemConfig = New clsConfig
                lstItems.Items.Clear()
                lstItems.Items.AddRange(SystemConfig.Items.ToArray)
                MsgBox("Saved.")
            End If
        End With
    End Sub

    Private Sub tbType_KeyDown(sender As Object, e As KeyEventArgs) Handles tbType.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = (fillBasis() = False)
        End If
    End Sub

    Private Sub tbType_LostFocus(sender As Object, e As EventArgs) Handles tbType.LostFocus
        fillBasis()
    End Sub

    Private listedTypes As New List(Of String)
    Private Function fillBasis() As Boolean

        Dim types As List(Of String) = tbType.Text.Split(Chr(13)).ToList
        If Not types.Count = 0 AndAlso Not types(0) = "" Then
            For i As Integer = 0 To dgv.Rows.Count - 1
                If i < dgv.Rows.Count - 1 Then
                    If Not types.Contains(dgv.Rows(i).Cells(0).Value) Then
                        dgv.Rows.RemoveAt(i)
                        listedTypes.Remove(types(i))
                    End If
                End If
            Next

            For i As Integer = 0 To types.Count - 1
                If (currentItem Is Nothing OrElse Not currentItem.Types.Contains(types(i))) And Not listedTypes.Contains(types(i)) Then
                    dgv.Rows.Add(types(i), "", "")
                    listedTypes.Add(types(i))
                End If
            Next
            Return True
        Else 'MsgBox("Invalid Types")
            Return False
        End If
    End Function


#End Region

#Region "Template Tab"
    Private Property CurrentTemplate As Batching.Template
        Get
            If lstTemplates.SelectedItem IsNot Nothing Then
                Return DirectCast(lstTemplates.SelectedItem, Batching.Template)
            Else : Return Nothing
            End If
        End Get
        Set(value As Batching.Template)
            lstTemplates.SelectedItem = value
        End Set
    End Property

    Private Sub collectTemplate(templateFolder As String)
        lstTemplates.Items.Clear()
        lbTemplateDir.Text = templateFolder

        If Not Directory.GetFiles(templateFolder, "*" & Batching.Template.Extension).Length = 0 Then
            lstTemplates.Items.AddRange(Batching.CollectTemplate(templateFolder).ToArray)
            lstTemplates.SelectedIndex = lstTemplates.Items.Count - 1
        End If
    End Sub

    Private Sub btnSaveTemplate_Click(sender As Object, e As EventArgs) Handles btnSaveTemplate.Click
        CurrentTemplate.ExeLocation = tbTemplateExeLoc.Text
        CurrentTemplate.TargetLocation = tbTemplateTargetDir.Text
        CurrentTemplate.SourceLocation = tbTemplateRootDir.Text
        CurrentTemplate.Use = cbUse.Checked
        CurrentTemplate.WriteToFile()
        MsgBox("Saved.")
    End Sub

    Private Sub btnSelectTemplateTargetDir_Click(sender As Object, e As EventArgs) Handles btnSelectTemplateTargetDir.Click, btnSelectTemplateRootDir.Click, btnSelectTemplateDir.Click
        If FBDtemplate.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select Case DirectCast(sender, Button).Name
                Case btnSelectTemplateRootDir.Name
                    tbTemplateRootDir.Text = ConvertToUNCPath(FBDtemplate.SelectedPath)
                Case btnSelectTemplateTargetDir.Name
                    tbTemplateTargetDir.Text = ConvertToUNCPath(FBDtemplate.SelectedPath)
                Case btnSelectTemplateDir.Name
                    lbTemplateDir.Text = ConvertToUNCPath(FBDtemplate.SelectedPath)
                    collectTemplate(lbTemplateDir.Text)

                    My.Settings.SavedTemplatePath = FBDtemplate.SelectedPath
                    My.Settings.Save()
            End Select
        End If
    End Sub

    Private Sub lstTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTemplates.SelectedIndexChanged
        tbTemplateTargetDir.Text = CurrentTemplate.TargetLocation
        tbTemplateRootDir.Text = CurrentTemplate.SourceLocation
        tbTemplateExeLoc.Text = CurrentTemplate.ExeLocation
        cbUse.Checked = CurrentTemplate.Use
    End Sub
#End Region

    Declare Function WNetGetConnection Lib "mpr.dll" Alias "WNetGetConnectionA" (ByVal lpszLocalName As String, _
           ByVal lpszRemoteName As String, ByRef cbRemoteName As Integer) As Integer
    ''' <summary>
    ''' THIS CONVERTS DRIVE LETTER TO UNCPATH
    ''' </summary>
    ''' <param name="sFilePath"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConvertToUNCPath(ByVal sFilePath As String) As String
        If sFilePath.Trim = "" Or Not sFilePath.Length >= 3 Then Return ""
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim d As DriveInfo
        Dim DriveType, Ctr As Integer
        Dim DriveLtr, UNCName As String
        Dim StrBldr As New StringBuilder
        If sFilePath.StartsWith("\\") Then Return sFilePath
        UNCName = Space(160)
        ConvertToUNCPath = ""
        DriveLtr = sFilePath.Substring(0, 3)
        For Each d In allDrives
            If d.Name = DriveLtr Then
                DriveType = d.DriveType
                Exit For
            End If
        Next
        If DriveType = 4 Then
            Ctr = WNetGetConnection(sFilePath.Substring(0, 2), UNCName, UNCName.Length)
            If Ctr = 0 Then
                UNCName = UNCName.Trim
                For Ctr = 0 To UNCName.Length - 1
                    Dim SingleChar As Char = UNCName(Ctr)
                    Dim asciiValue As Integer = Asc(SingleChar)
                    If asciiValue > 0 Then
                        StrBldr.Append(SingleChar)
                    Else
                        Exit For
                    End If
                Next
                StrBldr.Append(sFilePath.Substring(2))
                ConvertToUNCPath = StrBldr.ToString
            Else
                MsgBox("Cannot Retrieve UNC path" & vbCrLf & "Must Use Mapped Drive of SQLServer", MsgBoxStyle.Critical)
            End If
        Else
            Return sFilePath
        End If
    End Function
End Class
