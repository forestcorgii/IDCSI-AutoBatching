<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnBatchSelected = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPause = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.chbSelectAll = New System.Windows.Forms.CheckBox()
        Me.lstLogs = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbRemainingBatches = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbListing = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.clSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clJobcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clJob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clBatch = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.clStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clSource, Me.clJobcode, Me.clJob, Me.clClient, Me.clBatch, Me.clStatus})
        Me.dgv.GridColor = System.Drawing.Color.White
        Me.dgv.Location = New System.Drawing.Point(12, 60)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Size = New System.Drawing.Size(611, 193)
        Me.dgv.TabIndex = 0
        '
        'btnBatchSelected
        '
        Me.btnBatchSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatchSelected.Location = New System.Drawing.Point(513, 29)
        Me.btnBatchSelected.Name = "btnBatchSelected"
        Me.btnBatchSelected.Size = New System.Drawing.Size(110, 25)
        Me.btnBatchSelected.TabIndex = 3
        Me.btnBatchSelected.Text = "Batch Selected"
        Me.btnBatchSelected.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnStart, Me.mnPause, Me.mnSettings, Me.mnExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(635, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnStart
        '
        Me.mnStart.ForeColor = System.Drawing.Color.White
        Me.mnStart.Name = "mnStart"
        Me.mnStart.Size = New System.Drawing.Size(43, 20)
        Me.mnStart.Text = "Start"
        '
        'mnPause
        '
        Me.mnPause.ForeColor = System.Drawing.Color.White
        Me.mnPause.Name = "mnPause"
        Me.mnPause.Size = New System.Drawing.Size(50, 20)
        Me.mnPause.Text = "Pause"
        '
        'mnSettings
        '
        Me.mnSettings.ForeColor = System.Drawing.Color.White
        Me.mnSettings.Name = "mnSettings"
        Me.mnSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnSettings.Text = "Settings"
        '
        'mnExit
        '
        Me.mnExit.ForeColor = System.Drawing.Color.White
        Me.mnExit.Name = "mnExit"
        Me.mnExit.Size = New System.Drawing.Size(37, 20)
        Me.mnExit.Text = "Exit"
        '
        'chbSelectAll
        '
        Me.chbSelectAll.AutoSize = True
        Me.chbSelectAll.Location = New System.Drawing.Point(12, 36)
        Me.chbSelectAll.Name = "chbSelectAll"
        Me.chbSelectAll.Size = New System.Drawing.Size(77, 18)
        Me.chbSelectAll.TabIndex = 6
        Me.chbSelectAll.Text = "Select All"
        Me.chbSelectAll.UseVisualStyleBackColor = True
        '
        'lstLogs
        '
        Me.lstLogs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader7})
        Me.lstLogs.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLogs.FullRowSelect = True
        Me.lstLogs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstLogs.Location = New System.Drawing.Point(12, 260)
        Me.lstLogs.Name = "lstLogs"
        Me.lstLogs.Size = New System.Drawing.Size(611, 106)
        Me.lstLogs.TabIndex = 7
        Me.lstLogs.UseCompatibleStateImageBehavior = False
        Me.lstLogs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 214
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Start Time"
        Me.ColumnHeader8.Width = 121
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "End Time"
        Me.ColumnHeader9.Width = 105
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Elapse Time"
        Me.ColumnHeader10.Width = 76
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Error"
        Me.ColumnHeader7.Width = 83
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel, Me.lbRemainingBatches, Me.ToolStripStatusLabel1, Me.lbListing, Me.lbStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 369)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(635, 24)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(111, 19)
        Me.statusLabel.Text = "Remaining Batches:"
        '
        'lbRemainingBatches
        '
        Me.lbRemainingBatches.AutoSize = False
        Me.lbRemainingBatches.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lbRemainingBatches.Name = "lbRemainingBatches"
        Me.lbRemainingBatches.Size = New System.Drawing.Size(100, 19)
        Me.lbRemainingBatches.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(60, 19)
        Me.ToolStripStatusLabel1.Text = "re-Listing:"
        '
        'lbListing
        '
        Me.lbListing.Name = "lbListing"
        Me.lbListing.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.lbListing.Size = New System.Drawing.Size(154, 19)
        Me.lbListing.Text = "00sec. Before Listing"
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = False
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(350, 19)
        Me.lbStatus.Text = "STAND BY...."
        Me.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'clSource
        '
        Me.clSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clSource.HeaderText = "Source"
        Me.clSource.Name = "clSource"
        Me.clSource.ReadOnly = True
        '
        'clJobcode
        '
        Me.clJobcode.HeaderText = "Jobcode"
        Me.clJobcode.Name = "clJobcode"
        Me.clJobcode.ReadOnly = True
        '
        'clJob
        '
        Me.clJob.HeaderText = "Job"
        Me.clJob.Name = "clJob"
        Me.clJob.ReadOnly = True
        '
        'clClient
        '
        Me.clClient.HeaderText = "Client"
        Me.clClient.Name = "clClient"
        Me.clClient.ReadOnly = True
        '
        'clBatch
        '
        Me.clBatch.HeaderText = "Batch"
        Me.clBatch.Name = "clBatch"
        Me.clBatch.ReadOnly = True
        Me.clBatch.Width = 60
        '
        'clStatus
        '
        Me.clStatus.HeaderText = "Status"
        Me.clStatus.Name = "clStatus"
        Me.clStatus.ReadOnly = True
        Me.clStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clStatus.Width = 60
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 393)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lstLogs)
        Me.Controls.Add(Me.chbSelectAll)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnBatchSelected)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnBatchSelected As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPause As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chbSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents lstLogs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbRemainingBatches As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbListing As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents clSource As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clJobcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clJob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clClient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clBatch As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents clStatus As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
