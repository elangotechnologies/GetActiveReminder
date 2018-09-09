Imports NLog

Public Class ToastNotificationForm

    Public gNotificationDuration As Integer = 6000
    Public gNotificationMessage As String = ""
    Public gNotificationWindowSize As Size = Me.Size
    Dim log As Logger = LogManager.GetCurrentClassLogger()

    Private Sub ToastNotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setProperties()
        setTimerToClose()
        setContent()
    End Sub

    Private Sub setProperties()
        Me.Size = gNotificationWindowSize
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Me.Width - 10, Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 10)
        Me.TopMost = True
    End Sub

    Private Sub setTimerToClose()
        Dim fadeTriggerTime As Integer = gNotificationDuration * 40 / 100
        timerClose.Interval = gNotificationDuration - fadeTriggerTime
        timerFade.Interval = fadeTriggerTime / 100
        log.Debug("timerClose.Interval: " + timerClose.Interval.ToString + ", timerFade.Interval: " + timerFade.Interval.ToString)
        timerClose.Start()
    End Sub

    Private Sub setContent()
        adjustCloseButton()
        attachMessage(gNotificationMessage)
    End Sub

    Private Sub adjustCloseButton()
        LblClose.Location = New Point(Me.Width - LblClose.Width, 0)
    End Sub

    Private Sub attachMessage(message As String)
        lblMessage.Location = New Point(2, 10)
        lblMessage.Size = New Size(Me.Width - LblClose.Width, Me.Height - 20)
        lblMessage.Text = message
    End Sub

    Private Sub ToastNotificationForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub timerClose_Tick(sender As Object, e As EventArgs) Handles timerClose.Tick
        timerClose.Stop()
        log.Debug("timerClose_Tick")
        timerFade.Start()
    End Sub

    Private Sub ToastNotificationForm_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        Me.Hide()
        FrmMain.showMainForm()
    End Sub

    Private Sub timerFade_Tick(sender As Object, e As EventArgs) Handles timerFade.Tick
        log.Debug("timerFade_Tick Me.Opacity: " + Me.Opacity.ToString)
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