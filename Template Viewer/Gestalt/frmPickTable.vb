Public Class frmPickTable

    Public SelectedCB As ComboBox
    Public SelectedDGV As DataGridView
    Public SelectedDB As AutoBatchingLibrary.Automation.Batching.Database

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click, btnData.Click, btnCbatch.Click
        Select Case DirectCast(sender, Button).Name
            Case btnLog.Name
                SelectedCB = Gestalt.cbLog
                SelectedDGV = Gestalt.dgvLog
                SelectedDB = Gestalt.CurrentTemplate.Log
            Case btnCbatch.Name
                SelectedCB = Gestalt.cbCbatch
                SelectedDGV = Gestalt.dgvCbatch
                SelectedDB = Gestalt.CurrentTemplate.CBatch
            Case btnData.Name
                SelectedCB = Gestalt.cbData
                SelectedDGV = Gestalt.dgvData
                SelectedDB = Gestalt.CurrentTemplate.Data
        End Select
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class