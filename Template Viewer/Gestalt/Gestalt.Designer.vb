<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestalt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestalt))
        Me.tbClient = New System.Windows.Forms.TextBox()
        Me.tbType = New System.Windows.Forms.TextBox()
        Me.tbJob = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chbHasCSV = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rbtnCustom = New System.Windows.Forms.RadioButton()
        Me.rbtnClientJobType = New System.Windows.Forms.RadioButton()
        Me.rbtnUseClientJob = New System.Windows.Forms.RadioButton()
        Me.rbtnUseClientOnly = New System.Windows.Forms.RadioButton()
        Me.tbCustDtDir = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chbConRecCount = New System.Windows.Forms.CheckBox()
        Me.cbSourceImageType = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numImgPerRec = New System.Windows.Forms.NumericUpDown()
        Me.chbHasHeader = New System.Windows.Forms.CheckBox()
        Me.cbTargetImageType = New System.Windows.Forms.ComboBox()
        Me.numRecPerImg = New System.Windows.Forms.NumericUpDown()
        Me.numDefBatchSize = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbDBFileName = New System.Windows.Forms.TextBox()
        Me.tbImgFileName = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbBatchDateFolderName = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbBatFolderName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbImgFolderName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chbE1Only = New System.Windows.Forms.CheckBox()
        Me.tbComFolderName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbE2FolderName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbE1FolderName = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chbExCbatch = New System.Windows.Forms.CheckBox()
        Me.dgvCbatch = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbCbatch = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chbExLog = New System.Windows.Forms.CheckBox()
        Me.dgvLog = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbLog = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chbExData = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.clName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clMaxlLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clDefualtValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbData = New System.Windows.Forms.ComboBox()
        Me.chbAllin = New System.Windows.Forms.CheckBox()
        Me.lstTemplates = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstTables = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnTemplateDirectory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnImportTables = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSaveTemplate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSaveTemplateAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDeleteTemplate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDeleteTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbTemplatePath = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.tbRegex = New System.Windows.Forms.TextBox()
        Me.rbtnRegexBased = New System.Windows.Forms.RadioButton()
        Me.rbtnNoBasis = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.tbDateFormat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.numImgPerRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRecPerImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDefBatchSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvCbatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbClient
        '
        Me.tbClient.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbClient.Location = New System.Drawing.Point(54, 20)
        Me.tbClient.Name = "tbClient"
        Me.tbClient.Size = New System.Drawing.Size(87, 23)
        Me.tbClient.TabIndex = 0
        Me.tbClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbType
        '
        Me.tbType.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbType.Location = New System.Drawing.Point(54, 72)
        Me.tbType.Name = "tbType"
        Me.tbType.Size = New System.Drawing.Size(87, 23)
        Me.tbType.TabIndex = 2
        Me.tbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbJob
        '
        Me.tbJob.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbJob.Location = New System.Drawing.Point(54, 46)
        Me.tbJob.Name = "tbJob"
        Me.tbJob.Size = New System.Drawing.Size(87, 23)
        Me.tbJob.TabIndex = 1
        Me.tbJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Job"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Client"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbClient)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbJob)
        Me.GroupBox1.Controls.Add(Me.chbAllin)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(151, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1062, 514)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chbHasCSV)
        Me.GroupBox8.Location = New System.Drawing.Point(547, 49)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(266, 51)
        Me.GroupBox8.TabIndex = 38
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Logs"
        '
        'chbHasCSV
        '
        Me.chbHasCSV.AutoSize = True
        Me.chbHasCSV.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.chbHasCSV.Location = New System.Drawing.Point(6, 19)
        Me.chbHasCSV.Name = "chbHasCSV"
        Me.chbHasCSV.Size = New System.Drawing.Size(123, 19)
        Me.chbHasCSV.TabIndex = 12
        Me.chbHasCSV.Text = "Create a CSV copy"
        Me.chbHasCSV.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rbtnCustom)
        Me.GroupBox7.Controls.Add(Me.rbtnClientJobType)
        Me.GroupBox7.Controls.Add(Me.rbtnUseClientJob)
        Me.GroupBox7.Controls.Add(Me.rbtnUseClientOnly)
        Me.GroupBox7.Controls.Add(Me.tbCustDtDir)
        Me.GroupBox7.Location = New System.Drawing.Point(547, 101)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(266, 140)
        Me.GroupBox7.TabIndex = 37
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Data Directory Format"
        '
        'rbtnCustom
        '
        Me.rbtnCustom.AutoSize = True
        Me.rbtnCustom.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.rbtnCustom.Location = New System.Drawing.Point(10, 84)
        Me.rbtnCustom.Name = "rbtnCustom"
        Me.rbtnCustom.Size = New System.Drawing.Size(249, 19)
        Me.rbtnCustom.TabIndex = 47
        Me.rbtnCustom.TabStop = True
        Me.rbtnCustom.Text = "Custom: Optional. ex.(format\format\etc)"
        Me.rbtnCustom.UseVisualStyleBackColor = True
        '
        'rbtnClientJobType
        '
        Me.rbtnClientJobType.AutoSize = True
        Me.rbtnClientJobType.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.rbtnClientJobType.Location = New System.Drawing.Point(10, 56)
        Me.rbtnClientJobType.Name = "rbtnClientJobType"
        Me.rbtnClientJobType.Size = New System.Drawing.Size(158, 19)
        Me.rbtnClientJobType.TabIndex = 46
        Me.rbtnClientJobType.TabStop = True
        Me.rbtnClientJobType.Text = "Use Client, Job, and Type"
        Me.rbtnClientJobType.UseVisualStyleBackColor = True
        '
        'rbtnUseClientJob
        '
        Me.rbtnUseClientJob.AutoSize = True
        Me.rbtnUseClientJob.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.rbtnUseClientJob.Location = New System.Drawing.Point(10, 36)
        Me.rbtnUseClientJob.Name = "rbtnUseClientJob"
        Me.rbtnUseClientJob.Size = New System.Drawing.Size(125, 19)
        Me.rbtnUseClientJob.TabIndex = 45
        Me.rbtnUseClientJob.TabStop = True
        Me.rbtnUseClientJob.Text = "Use Client and Job"
        Me.rbtnUseClientJob.UseVisualStyleBackColor = True
        '
        'rbtnUseClientOnly
        '
        Me.rbtnUseClientOnly.AutoSize = True
        Me.rbtnUseClientOnly.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.rbtnUseClientOnly.Location = New System.Drawing.Point(10, 17)
        Me.rbtnUseClientOnly.Name = "rbtnUseClientOnly"
        Me.rbtnUseClientOnly.Size = New System.Drawing.Size(109, 19)
        Me.rbtnUseClientOnly.TabIndex = 44
        Me.rbtnUseClientOnly.TabStop = True
        Me.rbtnUseClientOnly.Text = "Use Client Only"
        Me.rbtnUseClientOnly.UseVisualStyleBackColor = True
        '
        'tbCustDtDir
        '
        Me.tbCustDtDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCustDtDir.Enabled = False
        Me.tbCustDtDir.Location = New System.Drawing.Point(10, 106)
        Me.tbCustDtDir.Name = "tbCustDtDir"
        Me.tbCustDtDir.Size = New System.Drawing.Size(250, 23)
        Me.tbCustDtDir.TabIndex = 40
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chbConRecCount)
        Me.GroupBox6.Controls.Add(Me.cbSourceImageType)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.numImgPerRec)
        Me.GroupBox6.Controls.Add(Me.chbHasHeader)
        Me.GroupBox6.Controls.Add(Me.cbTargetImageType)
        Me.GroupBox6.Controls.Add(Me.numRecPerImg)
        Me.GroupBox6.Controls.Add(Me.numDefBatchSize)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 101)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(331, 140)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Record && Image Setup"
        '
        'chbConRecCount
        '
        Me.chbConRecCount.AutoSize = True
        Me.chbConRecCount.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.chbConRecCount.Location = New System.Drawing.Point(14, 111)
        Me.chbConRecCount.Name = "chbConRecCount"
        Me.chbConRecCount.Size = New System.Drawing.Size(173, 19)
        Me.chbConRecCount.TabIndex = 28
        Me.chbConRecCount.Text = "Continous Record Counting"
        Me.chbConRecCount.UseVisualStyleBackColor = True
        '
        'cbSourceImageType
        '
        Me.cbSourceImageType.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.cbSourceImageType.FormattingEnabled = True
        Me.cbSourceImageType.Items.AddRange(New Object() {".tif", ".jpg", ".pdf"})
        Me.cbSourceImageType.Location = New System.Drawing.Point(167, 41)
        Me.cbSourceImageType.Name = "cbSourceImageType"
        Me.cbSourceImageType.Size = New System.Drawing.Size(151, 23)
        Me.cbSourceImageType.TabIndex = 26
        Me.cbSourceImageType.Text = ".tif"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(164, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(107, 15)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Source Image Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Images Per Record"
        '
        'numImgPerRec
        '
        Me.numImgPerRec.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.numImgPerRec.Location = New System.Drawing.Point(115, 21)
        Me.numImgPerRec.Name = "numImgPerRec"
        Me.numImgPerRec.Size = New System.Drawing.Size(46, 23)
        Me.numImgPerRec.TabIndex = 14
        Me.numImgPerRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numImgPerRec.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chbHasHeader
        '
        Me.chbHasHeader.AutoSize = True
        Me.chbHasHeader.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.chbHasHeader.Location = New System.Drawing.Point(193, 111)
        Me.chbHasHeader.Name = "chbHasHeader"
        Me.chbHasHeader.Size = New System.Drawing.Size(89, 19)
        Me.chbHasHeader.TabIndex = 18
        Me.chbHasHeader.Text = "Has Header"
        Me.chbHasHeader.UseVisualStyleBackColor = True
        '
        'cbTargetImageType
        '
        Me.cbTargetImageType.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.cbTargetImageType.FormattingEnabled = True
        Me.cbTargetImageType.Items.AddRange(New Object() {".tif", ".jpg", ".pdf"})
        Me.cbTargetImageType.Location = New System.Drawing.Point(272, 72)
        Me.cbTargetImageType.Name = "cbTargetImageType"
        Me.cbTargetImageType.Size = New System.Drawing.Size(46, 23)
        Me.cbTargetImageType.TabIndex = 17
        Me.cbTargetImageType.Text = ".tif"
        '
        'numRecPerImg
        '
        Me.numRecPerImg.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.numRecPerImg.Location = New System.Drawing.Point(115, 47)
        Me.numRecPerImg.Name = "numRecPerImg"
        Me.numRecPerImg.Size = New System.Drawing.Size(46, 23)
        Me.numRecPerImg.TabIndex = 15
        Me.numRecPerImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numRecPerImg.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numDefBatchSize
        '
        Me.numDefBatchSize.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.numDefBatchSize.Location = New System.Drawing.Point(115, 73)
        Me.numDefBatchSize.Name = "numDefBatchSize"
        Me.numDefBatchSize.Size = New System.Drawing.Size(46, 23)
        Me.numDefBatchSize.TabIndex = 16
        Me.numDefBatchSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numDefBatchSize.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(166, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 15)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Target Image Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(9, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Default Batch Size"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(6, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 15)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Records Per Image"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.tbDBFileName)
        Me.GroupBox5.Controls.Add(Me.tbImgFileName)
        Me.GroupBox5.Location = New System.Drawing.Point(343, 49)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(198, 51)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "File Naming"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(7, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 15)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "MDB"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(97, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 15)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "IMG"
        '
        'tbDBFileName
        '
        Me.tbDBFileName.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbDBFileName.Location = New System.Drawing.Point(42, 19)
        Me.tbDBFileName.Name = "tbDBFileName"
        Me.tbDBFileName.Size = New System.Drawing.Size(52, 23)
        Me.tbDBFileName.TabIndex = 10
        Me.tbDBFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbImgFileName
        '
        Me.tbImgFileName.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbImgFileName.Location = New System.Drawing.Point(130, 19)
        Me.tbImgFileName.Name = "tbImgFileName"
        Me.tbImgFileName.Size = New System.Drawing.Size(53, 23)
        Me.tbImgFileName.TabIndex = 11
        Me.tbImgFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbBatchDateFolderName)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.tbBatFolderName)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.tbImgFolderName)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.chbE1Only)
        Me.GroupBox4.Controls.Add(Me.tbComFolderName)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.tbE2FolderName)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.tbE1FolderName)
        Me.GroupBox4.Location = New System.Drawing.Point(343, 101)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(198, 140)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Folder Naming"
        '
        'tbBatchDateFolderName
        '
        Me.tbBatchDateFolderName.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbBatchDateFolderName.Location = New System.Drawing.Point(126, 18)
        Me.tbBatchDateFolderName.Name = "tbBatchDateFolderName"
        Me.tbBatchDateFolderName.Size = New System.Drawing.Size(57, 23)
        Me.tbBatchDateFolderName.TabIndex = 40
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(86, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 15)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "DATE"
        '
        'tbBatFolderName
        '
        Me.tbBatFolderName.Enabled = False
        Me.tbBatFolderName.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbBatFolderName.Location = New System.Drawing.Point(33, 18)
        Me.tbBatFolderName.Name = "tbBatFolderName"
        Me.tbBatFolderName.Size = New System.Drawing.Size(52, 23)
        Me.tbBatFolderName.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(7, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 15)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "BAT"
        '
        'tbImgFolderName
        '
        Me.tbImgFolderName.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbImgFolderName.Location = New System.Drawing.Point(126, 73)
        Me.tbImgFolderName.Name = "tbImgFolderName"
        Me.tbImgFolderName.Size = New System.Drawing.Size(57, 23)
        Me.tbImgFolderName.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(91, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 15)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "IMG"
        '
        'chbE1Only
        '
        Me.chbE1Only.AutoSize = True
        Me.chbE1Only.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.chbE1Only.Location = New System.Drawing.Point(10, 102)
        Me.chbE1Only.Name = "chbE1Only"
        Me.chbE1Only.Size = New System.Drawing.Size(93, 19)
        Me.chbE1Only.TabIndex = 10
        Me.chbE1Only.Text = "Entry 1 Only"
        Me.chbE1Only.UseVisualStyleBackColor = True
        '
        'tbComFolderName
        '
        Me.tbComFolderName.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbComFolderName.Location = New System.Drawing.Point(126, 46)
        Me.tbComFolderName.Name = "tbComFolderName"
        Me.tbComFolderName.Size = New System.Drawing.Size(57, 23)
        Me.tbComFolderName.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(86, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 15)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "COM"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label18.Location = New System.Drawing.Point(7, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 15)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "E2"
        '
        'tbE2FolderName
        '
        Me.tbE2FolderName.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbE2FolderName.Location = New System.Drawing.Point(33, 73)
        Me.tbE2FolderName.Name = "tbE2FolderName"
        Me.tbE2FolderName.Size = New System.Drawing.Size(52, 23)
        Me.tbE2FolderName.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(7, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 15)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "E1"
        '
        'tbE1FolderName
        '
        Me.tbE1FolderName.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbE1FolderName.Location = New System.Drawing.Point(33, 46)
        Me.tbE1FolderName.Name = "tbE1FolderName"
        Me.tbE1FolderName.Size = New System.Drawing.Size(52, 23)
        Me.tbE1FolderName.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtnNoBasis)
        Me.GroupBox3.Controls.Add(Me.rbtnRegexBased)
        Me.GroupBox3.Controls.Add(Me.tbRegex)
        Me.GroupBox3.Location = New System.Drawing.Point(147, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 90)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Basis"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1050, 267)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tables"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 22)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1038, 239)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chbExCbatch)
        Me.Panel2.Controls.Add(Me.dgvCbatch)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cbCbatch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(346, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 239)
        Me.Panel2.TabIndex = 0
        '
        'chbExCbatch
        '
        Me.chbExCbatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbExCbatch.AutoSize = True
        Me.chbExCbatch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbExCbatch.Location = New System.Drawing.Point(269, 25)
        Me.chbExCbatch.Name = "chbExCbatch"
        Me.chbExCbatch.Size = New System.Drawing.Size(74, 19)
        Me.chbExCbatch.TabIndex = 29
        Me.chbExCbatch.Text = "Excluded"
        Me.chbExCbatch.UseVisualStyleBackColor = True
        '
        'dgvCbatch
        '
        Me.dgvCbatch.AllowUserToOrderColumns = True
        Me.dgvCbatch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCbatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCbatch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvCbatch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvCbatch.Location = New System.Drawing.Point(2, 53)
        Me.dgvCbatch.Name = "dgvCbatch"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCbatch.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCbatch.RowHeadersWidth = 15
        Me.dgvCbatch.Size = New System.Drawing.Size(341, 186)
        Me.dgvCbatch.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Len"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 35
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Def. Val."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Cbatch"
        '
        'cbCbatch
        '
        Me.cbCbatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCbatch.FormattingEnabled = True
        Me.cbCbatch.Location = New System.Drawing.Point(3, 23)
        Me.cbCbatch.Name = "cbCbatch"
        Me.cbCbatch.Size = New System.Drawing.Size(259, 23)
        Me.cbCbatch.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chbExLog)
        Me.Panel3.Controls.Add(Me.dgvLog)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cbLog)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(692, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 239)
        Me.Panel3.TabIndex = 0
        '
        'chbExLog
        '
        Me.chbExLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbExLog.AutoSize = True
        Me.chbExLog.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbExLog.Location = New System.Drawing.Point(268, 25)
        Me.chbExLog.Name = "chbExLog"
        Me.chbExLog.Size = New System.Drawing.Size(74, 19)
        Me.chbExLog.TabIndex = 28
        Me.chbExLog.Text = "Excluded"
        Me.chbExLog.UseVisualStyleBackColor = True
        '
        'dgvLog
        '
        Me.dgvLog.AllowUserToOrderColumns = True
        Me.dgvLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvLog.Location = New System.Drawing.Point(3, 53)
        Me.dgvLog.Name = "dgvLog"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLog.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLog.RowHeadersWidth = 15
        Me.dgvLog.Size = New System.Drawing.Size(339, 186)
        Me.dgvLog.TabIndex = 27
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Len"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 35
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Def. Val."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Log"
        '
        'cbLog
        '
        Me.cbLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLog.FormattingEnabled = True
        Me.cbLog.Location = New System.Drawing.Point(3, 23)
        Me.cbLog.Name = "cbLog"
        Me.cbLog.Size = New System.Drawing.Size(258, 23)
        Me.cbLog.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chbExData)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dgvData)
        Me.Panel1.Controls.Add(Me.cbData)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 239)
        Me.Panel1.TabIndex = 0
        '
        'chbExData
        '
        Me.chbExData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbExData.AutoSize = True
        Me.chbExData.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbExData.Location = New System.Drawing.Point(269, 25)
        Me.chbExData.Name = "chbExData"
        Me.chbExData.Size = New System.Drawing.Size(74, 19)
        Me.chbExData.TabIndex = 24
        Me.chbExData.Text = "Excluded"
        Me.chbExData.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Data"
        '
        'dgvData
        '
        Me.dgvData.AllowUserToOrderColumns = True
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clName, Me.clType, Me.clMaxlLength, Me.clDefualtValue})
        Me.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvData.Location = New System.Drawing.Point(2, 53)
        Me.dgvData.Name = "dgvData"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvData.RowHeadersWidth = 15
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvData.Size = New System.Drawing.Size(341, 186)
        Me.dgvData.TabIndex = 8
        '
        'clName
        '
        Me.clName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clName.HeaderText = "Name"
        Me.clName.Name = "clName"
        Me.clName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clType
        '
        Me.clType.HeaderText = "Type"
        Me.clType.Name = "clType"
        Me.clType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clType.Width = 75
        '
        'clMaxlLength
        '
        Me.clMaxlLength.HeaderText = "Len"
        Me.clMaxlLength.Name = "clMaxlLength"
        Me.clMaxlLength.Width = 35
        '
        'clDefualtValue
        '
        Me.clDefualtValue.HeaderText = "Def. Val."
        Me.clDefualtValue.Name = "clDefualtValue"
        Me.clDefualtValue.Width = 75
        '
        'cbData
        '
        Me.cbData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbData.FormattingEnabled = True
        Me.cbData.Location = New System.Drawing.Point(2, 23)
        Me.cbData.Name = "cbData"
        Me.cbData.Size = New System.Drawing.Size(260, 23)
        Me.cbData.TabIndex = 11
        '
        'chbAllin
        '
        Me.chbAllin.AutoSize = True
        Me.chbAllin.Location = New System.Drawing.Point(347, 30)
        Me.chbAllin.Name = "chbAllin"
        Me.chbAllin.Size = New System.Drawing.Size(54, 19)
        Me.chbAllin.TabIndex = 35
        Me.chbAllin.Text = "All-in"
        Me.chbAllin.UseVisualStyleBackColor = True
        '
        'lstTemplates
        '
        Me.lstTemplates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstTemplates.FormattingEnabled = True
        Me.lstTemplates.HorizontalScrollbar = True
        Me.lstTemplates.ItemHeight = 15
        Me.lstTemplates.Location = New System.Drawing.Point(12, 57)
        Me.lstTemplates.Name = "lstTemplates"
        Me.lstTemplates.Size = New System.Drawing.Size(133, 484)
        Me.lstTemplates.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Templates"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1216, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Imported Tables"
        '
        'lstTables
        '
        Me.lstTables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTables.FormattingEnabled = True
        Me.lstTables.ItemHeight = 15
        Me.lstTables.Location = New System.Drawing.Point(1219, 57)
        Me.lstTables.Name = "lstTables"
        Me.lstTables.Size = New System.Drawing.Size(133, 484)
        Me.lstTables.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CommandToolStripMenuItem, Me.mnHelp, Me.lbTemplatePath})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnTemplateDirectory, Me.mnImportTables})
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'mnTemplateDirectory
        '
        Me.mnTemplateDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.mnTemplateDirectory.ForeColor = System.Drawing.Color.White
        Me.mnTemplateDirectory.Name = "mnTemplateDirectory"
        Me.mnTemplateDirectory.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnTemplateDirectory.Size = New System.Drawing.Size(193, 22)
        Me.mnTemplateDirectory.Text = "Template Directory"
        '
        'mnImportTables
        '
        Me.mnImportTables.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.mnImportTables.ForeColor = System.Drawing.Color.White
        Me.mnImportTables.Name = "mnImportTables"
        Me.mnImportTables.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnImportTables.Size = New System.Drawing.Size(193, 22)
        Me.mnImportTables.Text = "Import Tables"
        '
        'CommandToolStripMenuItem
        '
        Me.CommandToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSaveTemplate, Me.mnSaveTemplateAs, Me.mnDeleteTemplate, Me.mnDeleteTable, Me.mnRefresh})
        Me.CommandToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CommandToolStripMenuItem.Name = "CommandToolStripMenuItem"
        Me.CommandToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.CommandToolStripMenuItem.Text = "Commands"
        '
        'mnSaveTemplate
        '
        Me.mnSaveTemplate.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.mnSaveTemplate.ForeColor = System.Drawing.Color.White
        Me.mnSaveTemplate.Name = "mnSaveTemplate"
        Me.mnSaveTemplate.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnSaveTemplate.Size = New System.Drawing.Size(263, 22)
        Me.mnSaveTemplate.Text = "Save Template"
        '
        'mnSaveTemplateAs
        '
        Me.mnSaveTemplateAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.mnSaveTemplateAs.ForeColor = System.Drawing.Color.White
        Me.mnSaveTemplateAs.Name = "mnSaveTemplateAs"
        Me.mnSaveTemplateAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnSaveTemplateAs.Size = New System.Drawing.Size(263, 22)
        Me.mnSaveTemplateAs.Text = "Save as New Template"
        '
        'mnDeleteTemplate
        '
        Me.mnDeleteTemplate.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.mnDeleteTemplate.ForeColor = System.Drawing.Color.White
        Me.mnDeleteTemplate.Name = "mnDeleteTemplate"
        Me.mnDeleteTemplate.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.mnDeleteTemplate.Size = New System.Drawing.Size(263, 22)
        Me.mnDeleteTemplate.Text = "Delete Current Template"
        '
        'mnDeleteTable
        '
        Me.mnDeleteTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.mnDeleteTable.ForeColor = System.Drawing.Color.White
        Me.mnDeleteTable.Name = "mnDeleteTable"
        Me.mnDeleteTable.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.mnDeleteTable.Size = New System.Drawing.Size(263, 22)
        Me.mnDeleteTable.Text = "Delete Current Table"
        '
        'mnRefresh
        '
        Me.mnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.mnRefresh.ForeColor = System.Drawing.Color.White
        Me.mnRefresh.Name = "mnRefresh"
        Me.mnRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnRefresh.Size = New System.Drawing.Size(263, 22)
        Me.mnRefresh.Text = "Refresh"
        '
        'mnHelp
        '
        Me.mnHelp.ForeColor = System.Drawing.Color.White
        Me.mnHelp.Name = "mnHelp"
        Me.mnHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnHelp.Text = "Help"
        '
        'lbTemplatePath
        '
        Me.lbTemplatePath.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbTemplatePath.ForeColor = System.Drawing.Color.White
        Me.lbTemplatePath.Name = "lbTemplatePath"
        Me.lbTemplatePath.Size = New System.Drawing.Size(12, 20)
        '
        'OFD
        '
        Me.OFD.Filter = "MDB files|*.mdb"
        Me.OFD.Multiselect = True
        Me.OFD.Title = "Select Database"
        '
        'FBD
        '
        Me.FBD.Description = "Browse For Template Folder"
        '
        'tbRegex
        '
        Me.tbRegex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRegex.Enabled = False
        Me.tbRegex.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbRegex.Location = New System.Drawing.Point(69, 41)
        Me.tbRegex.Multiline = True
        Me.tbRegex.Name = "tbRegex"
        Me.tbRegex.Size = New System.Drawing.Size(111, 38)
        Me.tbRegex.TabIndex = 37
        '
        'rbtnRegexBased
        '
        Me.rbtnRegexBased.AutoSize = True
        Me.rbtnRegexBased.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.rbtnRegexBased.Location = New System.Drawing.Point(12, 41)
        Me.rbtnRegexBased.Name = "rbtnRegexBased"
        Me.rbtnRegexBased.Size = New System.Drawing.Size(56, 19)
        Me.rbtnRegexBased.TabIndex = 45
        Me.rbtnRegexBased.Text = "Regex"
        Me.rbtnRegexBased.UseVisualStyleBackColor = True
        '
        'rbtnNoBasis
        '
        Me.rbtnNoBasis.AutoSize = True
        Me.rbtnNoBasis.Checked = True
        Me.rbtnNoBasis.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.rbtnNoBasis.Location = New System.Drawing.Point(12, 16)
        Me.rbtnNoBasis.Name = "rbtnNoBasis"
        Me.rbtnNoBasis.Size = New System.Drawing.Size(53, 19)
        Me.rbtnNoBasis.TabIndex = 47
        Me.rbtnNoBasis.TabStop = True
        Me.rbtnNoBasis.Text = "None"
        Me.rbtnNoBasis.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.tbDateFormat)
        Me.GroupBox9.Controls.Add(Me.Label11)
        Me.GroupBox9.Location = New System.Drawing.Point(819, 49)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(237, 192)
        Me.GroupBox9.TabIndex = 39
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Etc"
        '
        'tbDateFormat
        '
        Me.tbDateFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDateFormat.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.tbDateFormat.Location = New System.Drawing.Point(145, 17)
        Me.tbDateFormat.Name = "tbDateFormat"
        Me.tbDateFormat.Size = New System.Drawing.Size(82, 23)
        Me.tbDateFormat.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(6, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 15)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Download Date Format"
        '
        'Gestalt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 544)
        Me.Controls.Add(Me.lstTables)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstTemplates)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Gestalt"
        Me.Text = "Gestalt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.numImgPerRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRecPerImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDefBatchSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvCbatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbClient As System.Windows.Forms.TextBox
    Friend WithEvents tbType As System.Windows.Forms.TextBox
    Friend WithEvents tbJob As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTemplates As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstTables As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnTemplateDirectory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnImportTables As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents numImgPerRec As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chbHasCSV As System.Windows.Forms.CheckBox
    Friend WithEvents chbE1Only As System.Windows.Forms.CheckBox
    Friend WithEvents numDefBatchSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbTemplatePath As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCbatch As System.Windows.Forms.ComboBox
    Friend WithEvents cbLog As System.Windows.Forms.ComboBox
    Friend WithEvents cbData As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDeleteTable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSaveTemplate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents clName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clMaxlLength As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clDefualtValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvCbatch As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvLog As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbTargetImageType As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbComFolderName As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbE2FolderName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbImgFileName As System.Windows.Forms.TextBox
    Friend WithEvents tbDBFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbE1FolderName As System.Windows.Forms.TextBox
    Friend WithEvents chbHasHeader As System.Windows.Forms.CheckBox
    Friend WithEvents numRecPerImg As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbImgFolderName As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents mnSaveTemplateAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDeleteTemplate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chbExCbatch As System.Windows.Forms.CheckBox
    Friend WithEvents chbExLog As System.Windows.Forms.CheckBox
    Friend WithEvents chbExData As System.Windows.Forms.CheckBox
    Friend WithEvents chbAllin As System.Windows.Forms.CheckBox
    Friend WithEvents tbBatFolderName As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbSourceImageType As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tbBatchDateFolderName As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chbConRecCount As System.Windows.Forms.CheckBox
    Friend WithEvents tbCustDtDir As System.Windows.Forms.TextBox
    Friend WithEvents rbtnCustom As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnClientJobType As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnUseClientJob As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnUseClientOnly As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnNoBasis As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnRegexBased As System.Windows.Forms.RadioButton
    Friend WithEvents tbRegex As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents tbDateFormat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
