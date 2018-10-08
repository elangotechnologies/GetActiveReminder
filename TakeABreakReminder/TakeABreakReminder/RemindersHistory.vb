Public Class RemindersHistory

    Private Sub RemindersHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDataGrid(dgReminderHistoryDetails, ReminderManager.getInstance().getReminderHistoryTable())
    End Sub
End Class