Imports System.Windows.Forms
Imports System.Text
Imports System.IO
Imports AutoBatchingLibrary.Automation
Imports AutoBatchingLibrary
Public Class dlgConfig
    Implements IDisposable
    'Private Sub btnTruncateLogs_Click(sender As Object, e As EventArgs) Handles btnTruncateLogs.Click
    '    If MsgBox("Are You sure you want to Truncate? All logs will be cleared.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        executeQRY(String.Format("DELETE FROM {0}", Logs_TableName), Main_Connection)
    '    End If
    'End Sub
    Public _systemConfig As New clsConfig
    Sub New(Optional _sysConfig As clsConfig = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If _sysConfig IsNot Nothing Then
            numDays.Value = _sysConfig.DaysToBatch
            numThread.Value = _sysConfig.ThreadCount
            _systemConfig = _sysConfig
        End If
    End Sub
    Private Sub dlgConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _systemConfig.DaysToBatch = numDays.Value
        _systemConfig.ThreadCount = numThread.Value
    
        XmlSerialization.WriteToFile(SettingDirectory & SettingFileName, _systemConfig)
    End Sub

    Private Sub dlgConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        onBrowse = True
        collectExeFile()
        displayTemplates()
    End Sub

    Private Sub collectExeFile()
        Dim exes As List(Of String) = (From res As String In Directory.GetFiles(ExeDirectory, "*.exe") Select Path.GetFileName(res)).ToList
        tbTemplateExeLoc.AutoCompleteCustomSource.AddRange(exes.ToArray)
     End Sub

    Private onBrowse As Boolean
    Private Sub displayTemplates()
        dgvTemplates.Rows.Clear()
        For i As Integer = 0 To _systemConfig.Templates.Count - 1
            dgvTemplates.Rows.Add(_systemConfig.Templates(i))
        Next
         SyncSelectedTemplates()
    End Sub

    Private Sub btnSaveTemplate_Click(sender As Object, e As EventArgs) Handles btnSaveTemplate.Click
        save(dgvTemplates.SelectedCells.Count = 1)
        MsgBox("Saved.")
    End Sub

    Private Sub save(one As Boolean, Optional idx As Short = -1)
        If one Then
            Dim CurrentTemplate As Batching.Template
            If idx = -1 Then
                CurrentTemplate = DirectCast(dgvTemplates.CurrentCell.Value, Batching.Template)
            Else : CurrentTemplate = DirectCast(dgvTemplates.Rows(idx).Cells(0).Value, Batching.Template)
            End If
            CurrentTemplate.ExeLocation = tbTemplateExeLoc.Text
            CurrentTemplate.TargetLocation = tbTemplateTargetDir.Text
            CurrentTemplate.SourceLocation = tbTemplateRootDir.Text
            CurrentTemplate.DownloadDateFormat = tbDateFormat.Text
            CurrentTemplate.Use = cbUse.Checked
            CurrentTemplate.BatchSize = IIf(tbBatchSize.Text = "", 0, tbBatchSize.Text)
            XmlSerialization.WriteToFile(TemplateDirectory & CurrentTemplate.ToString & Batching.Template.Extension, CurrentTemplate)
        Else
            For i As Integer = 0 To dgvTemplates.SelectedCells.Count - 1
                Dim CurrentTemplate As Batching.Template = DirectCast(dgvTemplates.SelectedCells(i).Value, Batching.Template)
                If tbTemplateExeLoc.Text <> "" Then CurrentTemplate.ExeLocation = tbTemplateExeLoc.Text
                If tbTemplateTargetDir.Text <> "" Then CurrentTemplate.TargetLocation = tbTemplateTargetDir.Text
                If tbTemplateRootDir.Text <> "" Then CurrentTemplate.SourceLocation = tbTemplateRootDir.Text
                If tbDateFormat.Text <> "" Then CurrentTemplate.DownloadDateFormat = tbDateFormat.Text
                If tbBatchSize.Text <> "" Then CurrentTemplate.BatchSize = tbBatchSize.Text
                CurrentTemplate.Use = cbUse.Checked
                XmlSerialization.WriteToFile(TemplateDirectory & CurrentTemplate.ToString & Batching.Template.Extension, CurrentTemplate)
            Next
        End If
        onBrowse = True
    End Sub

    Private Sub btnSelectTemplateTargetDir_Click(sender As Object, e As EventArgs) Handles btnSelectTemplateTargetDir.Click, btnSelectTemplateRootDir.Click
        If FBDtemplate.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select Case DirectCast(sender, Button).Name
                Case btnSelectTemplateRootDir.Name
                    tbTemplateRootDir.Text = Methods.ConvertToUNCPath(FBDtemplate.SelectedPath)
                Case btnSelectTemplateTargetDir.Name
                    tbTemplateTargetDir.Text = Methods.ConvertToUNCPath(FBDtemplate.SelectedPath)
                    'Case btnSelectTemplateDir.Name
                    '    lbTemplateDir.Text = Methods.ConvertToUNCPath(FBDtemplate.SelectedPath)
                    '    _systemConfig.Templates = Batching.CollectTemplate(lbTemplateDir.Text)
                    '    displayTemplates()
            End Select
            validateFields()
        End If
    End Sub

    Private Sub SyncSelectedTemplates()
        If dgvTemplates.SelectedCells.Count = 0 Then Exit Sub

        Dim CurrentTemplate As Batching.Template = DirectCast(dgvTemplates.SelectedCells(0).Value, Batching.Template)
        Dim p_target As String = CurrentTemplate.TargetLocation
        Dim p_Source As String = CurrentTemplate.SourceLocation
        Dim p_exe As String = CurrentTemplate.ExeLocation
        Dim p_dt As String = CurrentTemplate.DownloadDateFormat
        Dim p_Use As Boolean = CurrentTemplate.Use
        Dim p_bt As Integer = CurrentTemplate.BatchSize

        For i As Integer = 1 To dgvTemplates.SelectedCells.Count - 1
            CurrentTemplate = DirectCast(dgvTemplates.SelectedCells(i).Value, Batching.Template)

            If Not p_target = CurrentTemplate.TargetLocation Then
                p_target = ""
            End If
            If Not p_Source = CurrentTemplate.SourceLocation Then
                p_Source = ""
            End If
            If Not p_exe = CurrentTemplate.ExeLocation Then
                p_exe = ""
            End If

            If Not p_dt = CurrentTemplate.DownloadDateFormat Then
                p_dt = ""
            End If

            If Not p_bt = CurrentTemplate.BatchSize Then
                p_bt = 0
            End If

            If Not p_Use = CurrentTemplate.Use Then
                p_Use = False
            End If
        Next

        tbBatchSize.Text = IIf(p_bt = 0, "", p_bt)
        tbTemplateTargetDir.Text = p_target
        tbTemplateRootDir.Text = p_Source
        tbTemplateExeLoc.Text = p_exe
        tbDateFormat.Text = p_dt
        cbUse.Checked = p_Use
    End Sub

    Private prevIdx As Short


    Private Sub dgvTemplates_LostFocus(sender As Object, e As EventArgs) Handles dgvTemplates.LostFocus
        onBrowse = False
    End Sub

    Private Sub dgvTemplates_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTemplates.SelectionChanged
        If Not dgvTemplates.SelectedCells.Count = 0 And Not onBrowse Then
            If dgvTemplates.SelectedCells.Count = 1 Then
                save(True, prevIdx)
             End If
        End If
        prevIdx = dgvTemplates.CurrentRow.Index
        SyncSelectedTemplates()
        validateFields()
    End Sub

    Private Sub validateFields()
        If Directory.Exists(tbTemplateRootDir.Text) Then
            tbTemplateRootDir.BackColor = Color.FromArgb(183, 221, 145)
          Else
            tbTemplateRootDir.BackColor = Color.FromArgb(255, 145, 145)
        End If
        If Directory.Exists(tbTemplateTargetDir.Text) Then
            tbTemplateTargetDir.BackColor = Color.FromArgb(183, 221, 145)
         Else
            tbTemplateTargetDir.BackColor = Color.FromArgb(255, 145, 145)
        End If
    End Sub

 
End Class
