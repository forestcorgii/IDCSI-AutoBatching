<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstBatches = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPause = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbRemainingBatches = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbListing = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstLogs = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bgListing = New System.ComponentModel.BackgroundWorker()
        Me.tmMain = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBatches
        '
        Me.lstBatches.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstBatches.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader2, Me.ColumnHeader5})
        Me.lstBatches.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBatches.FullRowSelect = True
        Me.lstBatches.GridLines = True
        Me.lstBatches.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstBatches.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lstBatches.Location = New System.Drawing.Point(9, 27)
        Me.lstBatches.MultiSelect = False
        Me.lstBatches.Name = "lstBatches"
        Me.lstBatches.Size = New System.Drawing.Size(811, 226)
        Me.lstBatches.TabIndex = 0
        Me.lstBatches.UseCompatibleStateImageBehavior = False
        Me.lstBatches.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Source"
        Me.ColumnHeader4.Width = 406
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Client"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Job"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Progress"
        Me.ColumnHeader5.Width = 100
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnStart, Me.mnPause, Me.mnSettings, Me.mnExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(829, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnStart
        '
        Me.mnStart.Name = "mnStart"
        Me.mnStart.Size = New System.Drawing.Size(43, 20)
        Me.mnStart.Text = "Start"
        '
        'mnPause
        '
        Me.mnPause.Name = "mnPause"
        Me.mnPause.Size = New System.Drawing.Size(50, 20)
        Me.mnPause.Text = "Pause"
        '
        'mnSettings
        '
        Me.mnSettings.Name = "mnSettings"
        Me.mnSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnSettings.Text = "Settings"
        '
        'mnExit
        '
        Me.mnExit.Name = "mnExit"
        Me.mnExit.Size = New System.Drawing.Size(37, 20)
        Me.mnExit.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel, Me.lbRemainingBatches, Me.ToolStripStatusLabel1, Me.lbListing, Me.lbStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 386)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(829, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(111, 17)
        Me.statusLabel.Text = "Remaining Batches:"
        '
        'lbRemainingBatches
        '
        Me.lbRemainingBatches.AutoSize = False
        Me.lbRemainingBatches.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lbRemainingBatches.Name = "lbRemainingBatches"
        Me.lbRemainingBatches.Size = New System.Drawing.Size(100, 17)
        Me.lbRemainingBatches.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel1.Text = "re-Listing:"
        '
        'lbListing
        '
        Me.lbListing.Name = "lbListing"
        Me.lbListing.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.lbListing.Size = New System.Drawing.Size(154, 17)
        Me.lbListing.Text = "00sec. Before Listing"
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = False
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(350, 17)
        Me.lbStatus.Text = "STAND BY...."
        Me.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstLogs
        '
        Me.lstLogs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader7})
        Me.lstLogs.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLogs.FullRowSelect = True
        Me.lstLogs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstLogs.Location = New System.Drawing.Point(9, 259)
        Me.lstLogs.Name = "lstLogs"
        Me.lstLogs.Size = New System.Drawing.Size(811, 124)
        Me.lstLogs.TabIndex = 5
        Me.lstLogs.UseCompatibleStateImageBehavior = False
        Me.lstLogs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 347
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
        Me.ColumnHeader7.Width = 156
        '
        'bgListing
        '
        '
        'tmMain
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 408)
        Me.Controls.Add(Me.lstLogs)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lstBatches)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBatches As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPause As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstLogs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbRemainingBatches As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbListing As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bgListing As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmMain As System.Windows.Forms.Timer
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader

End Class
