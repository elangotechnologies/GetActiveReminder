Imports NLog

Public Class ToastNotificationForm

    Dim log As Logger = LogManager.GetCurrentClassLogger()

    Private Sub ToastNotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setProperties()
        setTimerToClose()
        playNotificationSound()
    End Sub

    Private Sub playNotificationSound()
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(My.Settings.notification_sound), AudioPlayMode.Background)
    End Sub

    Private Sub setProperties()
        Me.Size = New Size(My.Settings.notification_width, My.Settings.notification_height)
        Me.StartPosition = FormStartPosition.Manual
        updateLocation()
        Me.TopMost = True
        LblClose.Location = New Point(Me.Width - LblClose.Width, 0)
        lblMessage.Text = My.Settings.notification_message
        lblMessage.ForeColor = My.Settings.notification_forecolor
        Me.BackColor = My.Settings.notification_backcolor
        lblMessage.Font = My.Settings.notification_font

    End Sub

    Public Sub updateLocation()
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Me.Width - 10, Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 10)
    End Sub

    Private Sub setTimerToClose()
        Dim notificationDuration As Integer = My.Settings.notification_duration * 1000
        Dim fadeTriggerTime As Integer = notificationDuration * 40 / 100
        timerClose.Interval = notificationDuration - fadeTriggerTime
        timerFade.Interval = fadeTriggerTime / 100
        timerClose.Start()
    End Sub

    Private Sub ToastNotificationForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub timerClose_Tick(sender As Object, e As EventArgs) Handles timerClose.Tick
        timerClose.Stop()
        timerFade.Start()
    End Sub

    Private Sub ToastNotificationForm_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        Me.Hide()
        FrmMain.showMainForm()
    End Sub

    Private Sub timerFade_Tick(sender As Object, e As EventArgs) Handles timerFade.Tick
        Me.Opacity = Me.Opacity - 0.03
        If Me.Opacity <= 0 Then
            timerFade.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles LblClose.Click
        Me.Close()
    End Sub
End Class