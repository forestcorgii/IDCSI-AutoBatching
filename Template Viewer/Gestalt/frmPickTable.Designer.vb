﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickTable
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
        Me.btnData = New System.Windows.Forms.Button()
        Me.btnCbatch = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(12, 12)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(75, 23)
        Me.btnData.TabIndex = 0
        Me.btnData.Text = "Data"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'btnCbatch
        '
        Me.btnCbatch.Location = New System.Drawing.Point(93, 12)
        Me.btnCbatch.Name = "btnCbatch"
        Me.btnCbatch.Size = New System.Drawing.Size(75, 23)
        Me.btnCbatch.TabIndex = 1
        Me.btnCbatch.Text = "Cbatch"
        Me.btnCbatch.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.Location = New System.Drawing.Point(174, 12)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 23)
        Me.btnLog.TabIndex = 2
        Me.btnLog.Text = "Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'frmPickTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 46)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.btnCbatch)
        Me.Controls.Add(Me.btnData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPickTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pick Table"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnData As System.Windows.Forms.Button
    Friend WithEvents btnCbatch As System.Windows.Forms.Button
    Friend WithEvents btnLog As System.Windows.Forms.Button
End Class
