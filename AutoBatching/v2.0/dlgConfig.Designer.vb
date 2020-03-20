<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConfig
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
        Me.FBD1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FBDtemplate = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnTruncateLogs = New System.Windows.Forms.Button()
        Me.numDays = New System.Windows.Forms.NumericUpDown()
        Me.numThread = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.tbDateFormat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTemplates = New System.Windows.Forms.DataGridView()
        Me.clTemplates = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbTemplateExeLoc = New System.Windows.Forms.TextBox()
        Me.tbTemplateTargetDir = New System.Windows.Forms.TextBox()
        Me.tbTemplateRootDir = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbUse = New System.Windows.Forms.CheckBox()
        Me.btnSaveTemplate = New System.Windows.Forms.Button()
        Me.btnSelectTemplateTargetDir = New System.Windows.Forms.Button()
        Me.btnSelectTemplateRootDir = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbTemplateDir = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbBatchSize = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2.SuspendLayout()
        CType(Me.numDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numThread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvTemplates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnTruncateLogs)
        Me.TabPage2.Controls.Add(Me.numDays)
        Me.TabPage2.Controls.Add(Me.numThread)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(560, 456)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Misc."
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnTruncateLogs
        '
        Me.btnTruncateLogs.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTruncateLogs.Location = New System.Drawing.Point(11, 138)
        Me.btnTruncateLogs.Name = "btnTruncateLogs"
        Me.btnTruncateLogs.Size = New System.Drawing.Size(146, 23)
        Me.btnTruncateLogs.TabIndex = 23
        Me.btnTruncateLogs.Text = "Truncate Logs Table"
        Me.btnTruncateLogs.UseVisualStyleBackColor = True
        Me.btnTruncateLogs.Visible = False
        '
        'numDays
        '
        Me.numDays.Location = New System.Drawing.Point(323, 22)
        Me.numDays.Name = "numDays"
        Me.numDays.Size = New System.Drawing.Size(56, 20)
        Me.numDays.TabIndex = 22
        Me.numDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numThread
        '
        Me.numThread.Location = New System.Drawing.Point(122, 22)
        Me.numThread.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numThread.Name = "numThread"
        Me.numThread.Size = New System.Drawing.Size(56, 20)
        Me.numThread.TabIndex = 21
        Me.numThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numThread.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(203, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 15)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Days to Download :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(8, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Maximum Thread :"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.tbBatchSize)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.tbDateFormat)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.dgvTemplates)
        Me.TabPage5.Controls.Add(Me.tbTemplateExeLoc)
        Me.TabPage5.Controls.Add(Me.tbTemplateTargetDir)
        Me.TabPage5.Controls.Add(Me.tbTemplateRootDir)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.cbUse)
        Me.TabPage5.Controls.Add(Me.btnSaveTemplate)
        Me.TabPage5.Controls.Add(Me.btnSelectTemplateTargetDir)
        Me.TabPage5.Controls.Add(Me.btnSelectTemplateRootDir)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.lbTemplateDir)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(560, 456)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Templates"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'tbDateFormat
        '
        Me.tbDateFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDateFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbDateFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbDateFormat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDateFormat.Location = New System.Drawing.Point(314, 95)
        Me.tbDateFormat.Name = "tbDateFormat"
        Me.tbDateFormat.Size = New System.Drawing.Size(221, 23)
        Me.tbDateFormat.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Date Format"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dgvTemplates
        '
        Me.dgvTemplates.AllowUserToAddRows = False
        Me.dgvTemplates.AllowUserToDeleteRows = False
        Me.dgvTemplates.AllowUserToResizeColumns = False
        Me.dgvTemplates.AllowUserToResizeRows = False
        Me.dgvTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTemplates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clTemplates})
        Me.dgvTemplates.Location = New System.Drawing.Point(13, 29)
        Me.dgvTemplates.Name = "dgvTemplates"
        Me.dgvTemplates.RowHeadersVisible = False
        Me.dgvTemplates.Size = New System.Drawing.Size(185, 424)
        Me.dgvTemplates.TabIndex = 28
        '
        'clTemplates
        '
        Me.clTemplates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clTemplates.HeaderText = "Templates"
        Me.clTemplates.Name = "clTemplates"
        Me.clTemplates.ReadOnly = True
        '
        'tbTemplateExeLoc
        '
        Me.tbTemplateExeLoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTemplateExeLoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbTemplateExeLoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbTemplateExeLoc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTemplateExeLoc.Location = New System.Drawing.Point(314, 71)
        Me.tbTemplateExeLoc.Name = "tbTemplateExeLoc"
        Me.tbTemplateExeLoc.Size = New System.Drawing.Size(221, 23)
        Me.tbTemplateExeLoc.TabIndex = 23
        '
        'tbTemplateTargetDir
        '
        Me.tbTemplateTargetDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTemplateTargetDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTemplateTargetDir.Location = New System.Drawing.Point(314, 47)
        Me.tbTemplateTargetDir.Name = "tbTemplateTargetDir"
        Me.tbTemplateTargetDir.Size = New System.Drawing.Size(183, 23)
        Me.tbTemplateTargetDir.TabIndex = 16
        '
        'tbTemplateRootDir
        '
        Me.tbTemplateRootDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTemplateRootDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTemplateRootDir.Location = New System.Drawing.Point(314, 23)
        Me.tbTemplateRootDir.Name = "tbTemplateRootDir"
        Me.tbTemplateRootDir.Size = New System.Drawing.Size(183, 23)
        Me.tbTemplateRootDir.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(205, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 15)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Batching Program"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbUse
        '
        Me.cbUse.AutoSize = True
        Me.cbUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUse.Location = New System.Drawing.Point(314, 183)
        Me.cbUse.Name = "cbUse"
        Me.cbUse.Size = New System.Drawing.Size(104, 17)
        Me.cbUse.TabIndex = 22
        Me.cbUse.Text = "Use Template"
        Me.cbUse.UseVisualStyleBackColor = True
        '
        'btnSaveTemplate
        '
        Me.btnSaveTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTemplate.Location = New System.Drawing.Point(426, 179)
        Me.btnSaveTemplate.Name = "btnSaveTemplate"
        Me.btnSaveTemplate.Size = New System.Drawing.Size(109, 23)
        Me.btnSaveTemplate.TabIndex = 20
        Me.btnSaveTemplate.Text = "Save"
        Me.btnSaveTemplate.UseVisualStyleBackColor = True
        '
        'btnSelectTemplateTargetDir
        '
        Me.btnSelectTemplateTargetDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectTemplateTargetDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTemplateTargetDir.Location = New System.Drawing.Point(497, 47)
        Me.btnSelectTemplateTargetDir.Name = "btnSelectTemplateTargetDir"
        Me.btnSelectTemplateTargetDir.Size = New System.Drawing.Size(38, 23)
        Me.btnSelectTemplateTargetDir.TabIndex = 19
        Me.btnSelectTemplateTargetDir.Text = "..."
        Me.btnSelectTemplateTargetDir.UseVisualStyleBackColor = True
        '
        'btnSelectTemplateRootDir
        '
        Me.btnSelectTemplateRootDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectTemplateRootDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTemplateRootDir.Location = New System.Drawing.Point(497, 23)
        Me.btnSelectTemplateRootDir.Name = "btnSelectTemplateRootDir"
        Me.btnSelectTemplateRootDir.Size = New System.Drawing.Size(38, 23)
        Me.btnSelectTemplateRootDir.TabIndex = 18
        Me.btnSelectTemplateRootDir.Text = "..."
        Me.btnSelectTemplateRootDir.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(216, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Target Directory"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(224, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Root Directory"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbTemplateDir
        '
        Me.lbTemplateDir.AutoSize = True
        Me.lbTemplateDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTemplateDir.Location = New System.Drawing.Point(10, 10)
        Me.lbTemplateDir.Name = "lbTemplateDir"
        Me.lbTemplateDir.Size = New System.Drawing.Size(69, 13)
        Me.lbTemplateDir.TabIndex = 3
        Me.lbTemplateDir.Text = "Templates:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 8)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(568, 482)
        Me.TabControl1.TabIndex = 9
        '
        'tbBatchSize
        '
        Me.tbBatchSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBatchSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbBatchSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbBatchSize.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBatchSize.Location = New System.Drawing.Point(314, 119)
        Me.tbBatchSize.Name = "tbBatchSize"
        Me.tbBatchSize.Size = New System.Drawing.Size(221, 23)
        Me.tbBatchSize.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Batch Size"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dlgConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(585, 498)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 537)
        Me.Name = "dlgConfig"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.numDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numThread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvTemplates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FBD1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FBDtemplate As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnTruncateLogs As System.Windows.Forms.Button
    Friend WithEvents numDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents numThread As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents tbTemplateExeLoc As System.Windows.Forms.TextBox
    Friend WithEvents tbTemplateTargetDir As System.Windows.Forms.TextBox
    Friend WithEvents tbTemplateRootDir As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbUse As System.Windows.Forms.CheckBox
    Friend WithEvents btnSaveTemplate As System.Windows.Forms.Button
    Friend WithEvents btnSelectTemplateTargetDir As System.Windows.Forms.Button
    Friend WithEvents btnSelectTemplateRootDir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents dgvTemplates As System.Windows.Forms.DataGridView
    Friend WithEvents clTemplates As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbTemplateDir As System.Windows.Forms.Label
    Friend WithEvents tbDateFormat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbBatchSize As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
