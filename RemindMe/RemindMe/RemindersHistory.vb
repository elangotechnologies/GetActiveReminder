Public Class RemindersHistory

    Private Sub RemindersHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDataGrid(dgReminderHistoryDetails, ReminderManager.getInstance().getReminderHistoryTable())
    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class