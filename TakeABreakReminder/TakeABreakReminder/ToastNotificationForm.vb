Imports NLog

Public Class ToastNotificationForm

    Dim log As Logger = LogManager.GetCurrentClassLogger()
    Private gReminderRow As DataRow

    Private Sub ToastNotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gVisibleNotifications.Add(Me)
    End Sub

    Private Sub ToastNotificationForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub ToastNotificationForm_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        FrmMain.showMainForm()
    End Sub

    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles LblClose.Click
        Me.Close()
    End Sub

    Public Sub showNotification(reminderRow As DataRow)
        gReminderRow = reminderRow
        Me.Size = New Size(gReminderRow.Item(COL_NOTIFICATION_WIDTH), gReminderRow.Item(COL_NOTIFICATION_HEIGHT))
        ''gSumOfNotificationHeights += Me.Height + NOTIFICATION_GAP_OFFSET
        Dim xPosition As Integer = Screen.PrimaryScreen.Bounds.Width - Me.Width - NOTIFICATION_GAP_OFFSET
        Dim yPosition As Integer = Screen.PrimaryScreen.WorkingArea.Height - (Me.Height + NOTIFICATION_GAP_OFFSET + getVisibleNotificationsTotalHeight())
        Me.Location = New Point(xPosition, yPosition)
        LblClose.Location = New Point(Me.Width - LblClose.Width, 0)
        LblClose.ForeColor = Color.FromName(gReminderRow.Item(COL_NOTIFICATION_FORECOLOR))
        lblMessage.Text = gReminderRow.Item(COL_NOTIFICATION_MESSAGE)
        lblMessage.ForeColor = Color.FromName(gReminderRow.Item(COL_NOTIFICATION_FORECOLOR))
        Me.BackColor = Color.FromName(gReminderRow.Item(COL_NOTIFICATION_BACKCOLOR))
        lblMessage.Font = getFontObjFromDisplayFormat(gReminderRow.Item(COL_NOTIFICATION_FONT))

        Dim notificationDuration As Integer = gReminderRow.Item(COL_NOTIFICATION_DURATION) * 1000
        Dim fadeTriggerTime As Integer = 3000
        timerClose.Interval = notificationDuration - fadeTriggerTime
        timerFade.Interval = fadeTriggerTime / 100
        timerClose.Start()

        If gReminderRow.Item(COL_NOTIFICATION_SOUND) <> "None" Then
            My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(gReminderRow.Item(COL_NOTIFICATION_SOUND)), AudioPlayMode.Background)
        End If

        Me.Show()
    End Sub

    Private Sub timerClose_Tick(sender As Object, e As EventArgs) Handles timerClose.Tick
        timerClose.Stop()
        timerFade.Start()
    End Sub

    Private Sub timerFade_Tick(sender As Object, e As EventArgs) Handles timerFade.Tick
        Me.Opacity = Me.Opacity - 0.03
        If Me.Opacity <= 0 Then
            timerFade.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub ToastNotificationForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ''gReminderRow(COL_REMINDER_REPEAT_ELAPSED) += 1
        gVisibleNotifications.Remove(Me)
        updateVisibleNotificationPositions()
    End Sub

End Class