Imports AutoBatchingLibrary.Automation
Imports System.Windows.Forms
Imports System.IO
Imports System.Text

Public Class Tester

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists(My.Settings.SavedTemplatePath) Then collectTemplate(My.Settings.SavedTemplatePath)
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        '  Try
        '   For i As Integer = lstTemplates.SelectedIndex To lstTemplates.Items.Count - 1
        '   lstTemplates.SelectedIndex = i
        Dim Processor As New BatchingProcessor(tbSourceFile.Text, DirectCast(lstTemplates.SelectedItem, Batching.Template))
        Processor.TargetLocation = tbTargetDir.Text
        If Processor.Execute() Then
            MsgBox("Done")
        Else
            MsgBox("Error found")
        End If
        '   Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub btnSelectTemplateTargetDir_Click(sender As Object, e As EventArgs) Handles btnSelectTargetDir.Click, btnSelectTemplate.Click
        If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select Case DirectCast(sender, Button).Name
                Case btnSelectTargetDir.Name
                    tbTargetDir.Text = ConvertToUNCPath(FBD.SelectedPath)
                Case btnSelectTemplate.Name
                    collectTemplate(FBD.SelectedPath)

                    My.Settings.SavedTemplatePath = FBD.SelectedPath
                    My.Settings.Save()
            End Select
        End If
    End Sub

    Private Sub btnSelectSourceFile_Click(sender As Object, e As EventArgs) Handles btnSelectSourceFile.Click
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            tbSourceFile.Text = ConvertToUNCPath(OFD.FileName)
        End If
    End Sub


    Private Sub collectTemplate(templateFolder As String)
        lstTemplates.Items.Clear()

        If Not Directory.GetFiles(templateFolder, "*" & Batching.Template.Extension).Length = 0 Then
            lstTemplates.Items.AddRange(Batching.CollectTemplate(templateFolder).ToArray)
            lstTemplates.SelectedIndex = lstTemplates.Items.Count - 1
        End If
    End Sub

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