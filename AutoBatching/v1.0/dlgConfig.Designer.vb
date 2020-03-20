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
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.clType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clKeyString = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clSubstring = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.cbFileType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbBatchCount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSelectTargetDir = New System.Windows.Forms.Button()
        Me.btnSelectRootDir = New System.Windows.Forms.Button()
        Me.tbBatchingLoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbTargetDir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbClient = New System.Windows.Forms.TextBox()
        Me.tbJob = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbType = New System.Windows.Forms.TextBox()
        Me.tbRootDir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.FBD1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSaveTemplate = New System.Windows.Forms.Button()
        Me.btnSelectTemplateTargetDir = New System.Windows.Forms.Button()
        Me.btnSelectTemplateRootDir = New System.Windows.Forms.Button()
        Me.tbTemplateTargetDir = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTemplateRootDir = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSelectTemplateDir = New System.Windows.Forms.Button()
        Me.lbTemplateDir = New System.Windows.Forms.Label()
        Me.lstTemplates = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnTruncateLogs = New System.Windows.Forms.Button()
        Me.numDays = New System.Windows.Forms.NumericUpDown()
        Me.numThread = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FBDtemplate = New System.Windows.Forms.FolderBrowserDialog()
        Me.cbUse = New System.Windows.Forms.CheckBox()
        Me.tbTemplateExeLoc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.numDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numThread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstItems
        '
        Me.lstItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstItems.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.ItemHeight = 15
        Me.lstItems.Location = New System.Drawing.Point(7, 52)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(199, 484)
        Me.lstItems.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cbFileType)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbBatchCount)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnSelectTargetDir)
        Me.GroupBox1.Controls.Add(Me.btnSelectRootDir)
        Me.GroupBox1.Controls.Add(Me.tbBatchingLoc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbTargetDir)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbClient)
        Me.GroupBox1.Controls.Add(Me.tbJob)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.tbType)
        Me.GroupBox1.Controls.Add(Me.tbRootDir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(212, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 529)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Properties"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 316)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 173)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Basis"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 21)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(352, 149)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgv)
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(344, 119)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Bounty"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clType, Me.clKeyString, Me.clSubstring})
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(338, 113)
        Me.dgv.TabIndex = 0
        '
        'clType
        '
        Me.clType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clType.HeaderText = "Type"
        Me.clType.Name = "clType"
        '
        'clKeyString
        '
        Me.clKeyString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clKeyString.HeaderText = "Keystring"
        Me.clKeyString.Name = "clKeyString"
        '
        'clSubstring
        '
        Me.clSubstring.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clSubstring.HeaderText = "Substring"
        Me.clSubstring.Name = "clSubstring"
        '
        'TabPage4
        '
        Me.TabPage4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(344, 119)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Option 2"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cbFileType
        '
        Me.cbFileType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFileType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFileType.FormattingEnabled = True
        Me.cbFileType.Items.AddRange(New Object() {".ZIP", ".TIFF", ".JPEG"})
        Me.cbFileType.Location = New System.Drawing.Point(65, 414)
        Me.cbFileType.Name = "cbFileType"
        Me.cbFileType.Size = New System.Drawing.Size(197, 23)
        Me.cbFileType.TabIndex = 10
        Me.cbFileType.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "File Type"
        Me.Label8.Visible = False
        '
        'tbBatchCount
        '
        Me.tbBatchCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBatchCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBatchCount.Location = New System.Drawing.Point(268, 287)
        Me.tbBatchCount.Name = "tbBatchCount"
        Me.tbBatchCount.Size = New System.Drawing.Size(99, 23)
        Me.tbBatchCount.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(190, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Batch Count"
        '
        'btnSelectTargetDir
        '
        Me.btnSelectTargetDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectTargetDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTargetDir.Location = New System.Drawing.Point(329, 216)
        Me.btnSelectTargetDir.Name = "btnSelectTargetDir"
        Me.btnSelectTargetDir.Size = New System.Drawing.Size(38, 23)
        Me.btnSelectTargetDir.TabIndex = 13
        Me.btnSelectTargetDir.Text = "..."
        Me.btnSelectTargetDir.UseVisualStyleBackColor = True
        '
        'btnSelectRootDir
        '
        Me.btnSelectRootDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectRootDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectRootDir.Location = New System.Drawing.Point(329, 192)
        Me.btnSelectRootDir.Name = "btnSelectRootDir"
        Me.btnSelectRootDir.Size = New System.Drawing.Size(38, 23)
        Me.btnSelectRootDir.TabIndex = 11
        Me.btnSelectRootDir.Text = "..."
        Me.btnSelectRootDir.UseVisualStyleBackColor = True
        '
        'tbBatchingLoc
        '
        Me.tbBatchingLoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBatchingLoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbBatchingLoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbBatchingLoc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBatchingLoc.Location = New System.Drawing.Point(110, 263)
        Me.tbBatchingLoc.Name = "tbBatchingLoc"
        Me.tbBatchingLoc.Size = New System.Drawing.Size(257, 23)
        Me.tbBatchingLoc.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Batching Program"
        '
        'tbTargetDir
        '
        Me.tbTargetDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTargetDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTargetDir.Location = New System.Drawing.Point(110, 217)
        Me.tbTargetDir.Name = "tbTargetDir"
        Me.tbTargetDir.Size = New System.Drawing.Size(213, 23)
        Me.tbTargetDir.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Target Directory"
        '
        'tbClient
        '
        Me.tbClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbClient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbClient.Location = New System.Drawing.Point(63, 49)
        Me.tbClient.Name = "tbClient"
        Me.tbClient.Size = New System.Drawing.Size(305, 23)
        Me.tbClient.TabIndex = 3
        '
        'tbJob
        '
        Me.tbJob.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbJob.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJob.Location = New System.Drawing.Point(63, 73)
        Me.tbJob.Name = "tbJob"
        Me.tbJob.Size = New System.Drawing.Size(305, 23)
        Me.tbJob.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(268, 500)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbType
        '
        Me.tbType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbType.Location = New System.Drawing.Point(63, 97)
        Me.tbType.Multiline = True
        Me.tbType.Name = "tbType"
        Me.tbType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbType.Size = New System.Drawing.Size(305, 89)
        Me.tbType.TabIndex = 5
        '
        'tbRootDir
        '
        Me.tbRootDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRootDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRootDir.Location = New System.Drawing.Point(110, 193)
        Me.tbRootDir.Name = "tbRootDir"
        Me.tbRootDir.Size = New System.Drawing.Size(213, 23)
        Me.tbRootDir.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Root Directory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Job"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(106, 17)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 29)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(598, 575)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.tbTemplateExeLoc)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.cbUse)
        Me.TabPage5.Controls.Add(Me.Label11)
        Me.TabPage5.Controls.Add(Me.btnSaveTemplate)
        Me.TabPage5.Controls.Add(Me.btnSelectTemplateTargetDir)
        Me.TabPage5.Controls.Add(Me.btnSelectTemplateRootDir)
        Me.TabPage5.Controls.Add(Me.tbTemplateTargetDir)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.tbTemplateRootDir)
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.btnSelectTemplateDir)
        Me.TabPage5.Controls.Add(Me.lbTemplateDir)
        Me.TabPage5.Controls.Add(Me.lstTemplates)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(590, 549)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Templates"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(358, 521)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Don't Forget to save before leaving!"
        '
        'btnSaveTemplate
        '
        Me.btnSaveTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTemplate.Location = New System.Drawing.Point(455, 142)
        Me.btnSaveTemplate.Name = "btnSaveTemplate"
        Me.btnSaveTemplate.Size = New System.Drawing.Size(115, 23)
        Me.btnSaveTemplate.TabIndex = 20
        Me.btnSaveTemplate.Text = "Save"
        Me.btnSaveTemplate.UseVisualStyleBackColor = True
        '
        'btnSelectTemplateTargetDir
        '
        Me.btnSelectTemplateTargetDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectTemplateTargetDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTemplateTargetDir.Location = New System.Drawing.Point(526, 70)
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
        Me.btnSelectTemplateRootDir.Location = New System.Drawing.Point(526, 46)
        Me.btnSelectTemplateRootDir.Name = "btnSelectTemplateRootDir"
        Me.btnSelectTemplateRootDir.Size = New System.Drawing.Size(38, 23)
        Me.btnSelectTemplateRootDir.TabIndex = 18
        Me.btnSelectTemplateRootDir.Text = "..."
        Me.btnSelectTemplateRootDir.UseVisualStyleBackColor = True
        '
        'tbTemplateTargetDir
        '
        Me.tbTemplateTargetDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTemplateTargetDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTemplateTargetDir.Location = New System.Drawing.Point(313, 70)
        Me.tbTemplateTargetDir.Name = "tbTemplateTargetDir"
        Me.tbTemplateTargetDir.Size = New System.Drawing.Size(213, 23)
        Me.tbTemplateTargetDir.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(215, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Target Directory"
        '
        'tbTemplateRootDir
        '
        Me.tbTemplateRootDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTemplateRootDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTemplateRootDir.Location = New System.Drawing.Point(313, 46)
        Me.tbTemplateRootDir.Name = "tbTemplateRootDir"
        Me.tbTemplateRootDir.Size = New System.Drawing.Size(213, 23)
        Me.tbTemplateRootDir.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(223, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Root Directory"
        '
        'btnSelectTemplateDir
        '
        Me.btnSelectTemplateDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTemplateDir.Location = New System.Drawing.Point(13, 14)
        Me.btnSelectTemplateDir.Name = "btnSelectTemplateDir"
        Me.btnSelectTemplateDir.Size = New System.Drawing.Size(115, 23)
        Me.btnSelectTemplateDir.TabIndex = 4
        Me.btnSelectTemplateDir.Text = "Template Directory"
        Me.btnSelectTemplateDir.UseVisualStyleBackColor = True
        '
        'lbTemplateDir
        '
        Me.lbTemplateDir.AutoSize = True
        Me.lbTemplateDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTemplateDir.Location = New System.Drawing.Point(134, 19)
        Me.lbTemplateDir.Name = "lbTemplateDir"
        Me.lbTemplateDir.Size = New System.Drawing.Size(89, 13)
        Me.lbTemplateDir.TabIndex = 3
        Me.lbTemplateDir.Text = "Template Path"
        '
        'lstTemplates
        '
        Me.lstTemplates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstTemplates.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTemplates.FormattingEnabled = True
        Me.lstTemplates.ItemHeight = 15
        Me.lstTemplates.Location = New System.Drawing.Point(3, 46)
        Me.lstTemplates.Name = "lstTemplates"
        Me.lstTemplates.Size = New System.Drawing.Size(199, 499)
        Me.lstTemplates.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnNew)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.lstItems)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(590, 549)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Batch Items"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(7, 17)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(93, 29)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = True
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
        Me.TabPage2.Size = New System.Drawing.Size(590, 549)
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
        Me.numDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.numThread.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
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
        'cbUse
        '
        Me.cbUse.AutoSize = True
        Me.cbUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUse.Location = New System.Drawing.Point(345, 146)
        Me.cbUse.Name = "cbUse"
        Me.cbUse.Size = New System.Drawing.Size(104, 17)
        Me.cbUse.TabIndex = 22
        Me.cbUse.Text = "Use Template"
        Me.cbUse.UseVisualStyleBackColor = True
        '
        'tbTemplateExeLoc
        '
        Me.tbTemplateExeLoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTemplateExeLoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbTemplateExeLoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbTemplateExeLoc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTemplateExeLoc.Location = New System.Drawing.Point(313, 94)
        Me.tbTemplateExeLoc.Name = "tbTemplateExeLoc"
        Me.tbTemplateExeLoc.Size = New System.Drawing.Size(251, 23)
        Me.tbTemplateExeLoc.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(204, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 15)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Batching Program"
        '
        'dlgConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 537)
        Me.Name = "dlgConfig"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.numDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numThread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbClient As System.Windows.Forms.TextBox
    Friend WithEvents tbJob As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tbType As System.Windows.Forms.TextBox
    Friend WithEvents tbRootDir As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents tbBatchCount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSelectTargetDir As System.Windows.Forms.Button
    Friend WithEvents btnSelectRootDir As System.Windows.Forms.Button
    Friend WithEvents tbBatchingLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbTargetDir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FBD1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbFileType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents numDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents numThread As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnTruncateLogs As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents clType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clKeyString As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clSubstring As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents FBDtemplate As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSelectTemplateDir As System.Windows.Forms.Button
    Friend WithEvents lbTemplateDir As System.Windows.Forms.Label
    Friend WithEvents lstTemplates As System.Windows.Forms.ListBox
    Friend WithEvents btnSelectTemplateTargetDir As System.Windows.Forms.Button
    Friend WithEvents btnSelectTemplateRootDir As System.Windows.Forms.Button
    Friend WithEvents tbTemplateTargetDir As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbTemplateRootDir As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSaveTemplate As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbUse As System.Windows.Forms.CheckBox
    Friend WithEvents tbTemplateExeLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
