Public Class frmReminders

    Private Sub rtb_TextChanged(sender As Object, e As EventArgs) Handles rtb.TextChanged

    End Sub

    Private Sub frmReminders_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.reminders = rtb.Text
        My.Settings.Save()
    End Sub

    Private Sub frmReminders_Load(sender As Object, e As EventArgs) Handles Me.Load
        rtb.Text = My.Settings.reminders
    End Sub
End Class