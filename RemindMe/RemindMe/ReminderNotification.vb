Imports System.Threading
Imports NLog

Public Class ReminderNotification

    Dim log As Logger = LogManager.GetCurrentClassLogger()
    Private gReminderRow As DataRow
    Private moveXAxisByValue As Double = 0
    Private gSlideIncrementCount As Double = 0
    Public Const SLIDE_TIME_MAX As Integer = 100
    Public Const SLIDE_COUNT_MAX As Integer = 20
    Public Const moveXAxisByValueForReturn As Integer = 10
    Private gCloseTime As DateTime
    Private gNotificationSeconds As Integer = 0

    Private Sub ToastNotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gVisibleNotifications.Add(Me)
    End Sub

    Private Sub ToastNotificationForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub ToastNotificationForm_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick, lblMessage.DoubleClick, panelNotificationHeader.DoubleClick
        FrmMain.showMainForm()
    End Sub

    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles LblClose.Click
        Me.Close()
    End Sub

    Public Sub showNotification(reminderRow As DataRow)
        gReminderRow = reminderRow
        Me.Size = New Size(gReminderRow.Item(COL_NOTIFICATION_WIDTH), gReminderRow.Item(COL_NOTIFICATION_HEIGHT))

        LblClose.Location = New Point(Me.Width - LblClose.Width, 0)
        LblClose.ForeColor = Color.FromName(gReminderRow.Item(COL_NOTIFICATION_META_FORECOLOR))
        lblReminderId.Location = New Point(10, 0)
        lblReminderId.Text = "Id: " + gReminderRow.Item(COL_REMINDER_ID).ToString
        lblReminderType.Text = "Type: " + gReminderRow.Item(COL_REMINDER_TYPE)
        ''log.Debug("lblReminderType Width: " + lblReminderType.Width.ToString)
        lblReminderType.Location = New Point((Me.Width / 2) - lblReminderType.Width, 0)
        lblMessage.Text = gReminderRow.Item(COL_NOTIFICATION_MESSAGE)
        lblMessage.ForeColor = Color.FromName(gReminderRow.Item(COL_NOTIFICATION_FORECOLOR))
        Me.BackColor = Color.FromName(gReminderRow.Item(COL_NOTIFICATION_BACKCOLOR))
        lblMessage.Font = getFontObjFromDisplayFormat(gReminderRow.Item(COL_NOTIFICATION_FONT))
        panelNotificationHeader.Font = getFontObjFromDisplayFormat(gReminderRow.Item(COL_NOTIFICATION_META_FONT))
        panelNotificationHeader.ForeColor = Color.FromName(reminderRow(COL_NOTIFICATION_META_FORECOLOR))

        gNotificationSeconds = gReminderRow.Item(COL_NOTIFICATION_DURATION)
        lblcloseTimeCounter.Text = "Closes in: " + gNotificationSeconds.ToString
        lblcloseTimeCounter.Location = New Point(Me.Width - lblcloseTimeCounter.Width - 40, 0)
        Dim notificationDuration As Double = gNotificationSeconds * 1000
        Dim fadeTriggerTime As Double = 2000
        gCloseTime = DateTime.Now.AddMilliseconds(notificationDuration - fadeTriggerTime)
        timerClose.Start()

        ''timerClose.Interval = notificationDuration - fadeTriggerTime
        timerFade.Interval = fadeTriggerTime / 100

        Dim yPosition As Integer = Screen.PrimaryScreen.WorkingArea.Height - (Me.Height + NOTIFICATION_GAP_OFFSET + getVisibleNotificationsTotalHeight())

        If My.Settings.notify_with_animation = True Then
            Dim xPosition As Integer = Screen.PrimaryScreen.Bounds.Width
            Me.Location = New Point(xPosition, yPosition)
            ''calculation for sliding animation
            Dim slidingInterval As Double = SLIDE_TIME_MAX / SLIDE_COUNT_MAX
            timerSlideIn.Interval = slidingInterval
            moveXAxisByValue = Me.Width / SLIDE_COUNT_MAX
            timerSlideIn.Start()
        Else
            Dim xPosition As Integer = Screen.PrimaryScreen.Bounds.Width - Me.Width - NOTIFICATION_GAP_OFFSET
            Me.Location = New Point(xPosition, yPosition)
        End If

        If gReminderRow.Item(COL_NOTIFICATION_SOUND) <> "None" Then
            My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(gReminderRow.Item(COL_NOTIFICATION_SOUND)), AudioPlayMode.Background)
        End If

        Me.Show()

        ''animateSlideIn()
    End Sub

    Private Sub timerClose_Tick(sender As Object, e As EventArgs) Handles timerClose.Tick
        lblcloseTimeCounter.Text = "Closes in: " + gNotificationSeconds.ToString
        gNotificationSeconds -= 1
        Dim currentTime As DateTime = DateTime.Now
        If currentTime >= gCloseTime Then
            timerClose.Stop()
            timerFade.Start()
        End If
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

    Private Sub timerSlideIn_Tick(sender As Object, e As EventArgs) Handles timerSlideIn.Tick
        gSlideIncrementCount += 1
        If gSlideIncrementCount > SLIDE_COUNT_MAX + 3 Then
            timerSlideIn.Stop()
            timerSlideInBack.Interval = 5
            timerSlideInBack.Start()
            Return
        End If

        Me.Location = New Point(Me.Location.X - moveXAxisByValue, Me.Location.Y)

    End Sub

    Private Sub timerSlideInBack_Tick(sender As Object, e As EventArgs) Handles timerSlideInBack.Tick
        Dim expectedXAxis As Integer = Screen.PrimaryScreen.Bounds.Width - Me.Width - NOTIFICATION_GAP_OFFSET

        If Me.Location.X >= expectedXAxis Then
            timerSlideInBack.Stop()
            Return
        End If

        Dim nextXAxis As Integer = Me.Location.X + moveXAxisByValueForReturn
        If nextXAxis > expectedXAxis Then
            nextXAxis = expectedXAxis
        End If

        Me.Location = New Point(nextXAxis, Me.Location.Y)
    End Sub
End Class