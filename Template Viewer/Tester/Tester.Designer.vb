<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tester
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstTemplates = New System.Windows.Forms.ListBox()
        Me.btnSelectTargetDir = New System.Windows.Forms.Button()
        Me.btnSelectSourceFile = New System.Windows.Forms.Button()
        Me.tbTargetDir = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbSourceFile = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectTemplate = New System.Windows.Forms.Button()
        Me.lstStatus = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Templates"
        '
        'lstTemplates
        '
        Me.lstTemplates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstTemplates.FormattingEnabled = True
        Me.lstTemplates.Location = New System.Drawing.Point(12, 31)
        Me.lstTemplates.Name = "lstTemplates"
        Me.lstTemplates.Size = New System.Drawing.Size(133, 316)
        Me.lstTemplates.TabIndex = 10
        '
        'btnSelectTargetDir
        '
        Me.btnSelectTargetDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectTargetDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTargetDir.Location = New System.Drawing.Point(507, 54)
        Me.btnSelectTargetDir.Name = "btnSelectTargetDir"
        Me.btnSelectTargetDir.Size = New System.Drawing.Size(38, 23)
        Me.btnSelectTargetDir.TabIndex = 25
        Me.btnSelectTargetDir.Text = "..."
        Me.btnSelectTargetDir.UseVisualStyleBackColor = True
        '
        'btnSelectSourceFile
        '
        Me.btnSelectSourceFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectSourceFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSourceFile.Location = New System.Drawing.Point(507, 30)
        Me.btnSelectSourceFile.Name = "btnSelectSourceFile"
        Me.btnSelectSourceFile.Size = New System.Drawing.Size(38, 23)
        Me.btnSelectSourceFile.TabIndex = 24
        Me.btnSelectSourceFile.Text = "..."
        Me.btnSelectSourceFile.UseVisualStyleBackColor = True
        '
        'tbTargetDir
        '
        Me.tbTargetDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTargetDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTargetDir.Location = New System.Drawing.Point(255, 55)
        Me.tbTargetDir.Name = "tbTargetDir"
        Me.tbTargetDir.Size = New System.Drawing.Size(246, 23)
        Me.tbTargetDir.TabIndex = 22
        Me.tbTargetDir.Text = "C:\"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(157, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Target Directory"
        '
        'tbSourceFile
        '
        Me.tbSourceFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSourceFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSourceFile.Location = New System.Drawing.Point(255, 31)
        Me.tbSourceFile.Name = "tbSourceFile"
        Me.tbSourceFile.Size = New System.Drawing.Size(246, 23)
        Me.tbSourceFile.TabIndex = 21
        Me.tbSourceFile.Text = "E:\AutoBatching\Root\0509_10052018\tmp\D35240963.zip"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(165, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Batch File"
        '
        'btnRun
        '
        Me.btnRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRun.Location = New System.Drawing.Point(475, 331)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 26
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'btnSelectTemplate
        '
        Me.btnSelectTemplate.Location = New System.Drawing.Point(81, 5)
        Me.btnSelectTemplate.Name = "btnSelectTemplate"
        Me.btnSelectTemplate.Size = New System.Drawing.Size(64, 19)
        Me.btnSelectTemplate.TabIndex = 27
        Me.btnSelectTemplate.Text = "Select"
        Me.btnSelectTemplate.UseVisualStyleBackColor = True
        '
        'lstStatus
        '
        Me.lstStatus.FormattingEnabled = True
        Me.lstStatus.Location = New System.Drawing.Point(151, 102)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Size = New System.Drawing.Size(399, 225)
        Me.lstStatus.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Status"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 358)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstStatus)
        Me.Controls.Add(Me.btnSelectTemplate)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnSelectTargetDir)
        Me.Controls.Add(Me.btnSelectSourceFile)
        Me.Controls.Add(Me.tbTargetDir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbSourceFile)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstTemplates)
        Me.Name = "frmMain"
        Me.Text = "Template Tester"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstTemplates As System.Windows.Forms.ListBox
    Friend WithEvents btnSelectTargetDir As System.Windows.Forms.Button
    Friend WithEvents btnSelectSourceFile As System.Windows.Forms.Button
    Friend WithEvents tbTargetDir As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbSourceFile As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSelectTemplate As System.Windows.Forms.Button
    Friend WithEvents lstStatus As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
