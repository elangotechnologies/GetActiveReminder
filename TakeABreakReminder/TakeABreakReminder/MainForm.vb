Imports NLog

Public Class FrmMain
    Dim log As Logger = LogManager.GetCurrentClassLogger()
    Const HOURS_MILLISECONDS_CONVERTER As Integer = 60 * 60 * 1000
    Const MINUTES_MILLISECONDS_CONVERTER As Integer = 60 * 1000
    Const SECONDS_MILLISECONDS_CONVERTER As Integer = 1000

    Dim gTrackerBarDataKeepers As Dictionary(Of TrackBar, TrackerBarDataKeeper)
    Dim gRemainingIntervalMilliseconds As Integer = 0
    Dim gIntervalMilliseconds As Integer = 0
    Dim gIsExitClicked As Boolean = False
    Private gIsReminderTimerRunning As Boolean = False

    Private Class TrackerBarDataKeeper
        Public displayLabel As Label
        Public persistentKey As String

        Public Sub New(pDisplayLabel As Label, pPersistentKey As String)
            displayLabel = pDisplayLabel
            persistentKey = pPersistentKey
        End Sub
    End Class

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gTrackerBarDataKeepers = New Dictionary(Of TrackBar, TrackerBarDataKeeper) From
        {{trackBarHours, New TrackerBarDataKeeper(lblHours, "hours")}, {trackBarMinutes, New TrackerBarDataKeeper(lblMinutes, "minutes")}, {trackBarSeconds, New TrackerBarDataKeeper(lblSeconds, "seconds")}}

        For Each trackerBarDataKeeperPair As KeyValuePair(Of TrackBar, TrackerBarDataKeeper) In gTrackerBarDataKeepers
            Dim trackBar As TrackBar = trackerBarDataKeeperPair.Key
            Dim trackerBarDataKeeper As TrackerBarDataKeeper = trackerBarDataKeeperPair.Value
            trackBar.Value = My.Settings.Item(trackerBarDataKeeperPair.Value.persistentKey)
        Next



        loadNotificationDurationList()

    End Sub

    Private Sub loadNotificationDurationList()
        Dim notificaitonDurationList As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) From
        {{5, "5 Seconds"}, {10, "10 Seconds"}, {15, "15 Seconds"}}
        cmbNotificationDuration.ValueMember = "Key"
        cmbNotificationDuration.DisplayMember = "Value"
        cmbNotificationDuration.DataSource = New BindingSource(notificaitonDurationList, Nothing)
        cmbNotificationDuration.SelectedValue = My.Settings.notification_duration

        AddHandler cmbNotificationDuration.SelectedIndexChanged, AddressOf cmbNotificationDuration_SelectedIndexChanged

    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If gIsReminderTimerRunning = False Then
            startReminder()
        Else
            stopReminder()
        End If

    End Sub

    Private Sub startReminder()
        Dim intervalMilliSeconds As Integer = getIntervalAsMilliseconds()

        If intervalMilliSeconds < 30000 Then
            MsgBox("The selected time for reminder must be atleast 30 seconds or more. Current value is : " + getDisplayIntervalFromScreen() + ". Please Retry!")
            Return
        End If

        timerReminder.Interval = intervalMilliSeconds
        gIntervalMilliseconds = intervalMilliSeconds
        gRemainingIntervalMilliseconds = gIntervalMilliseconds
        timerReminder.Start()
        gIsReminderTimerRunning = True
        timerStatusBarUpdater.Start()
        statusRemainingTime.Text = getDisplayIntervalFromMilliseconds(0)
        statusRemainingTime.ForeColor = Color.Maroon
        btnStartStop.Text = "Stop Reminder"
    End Sub

    Private Sub stopReminder()
        timerReminder.Stop()
        timerStatusBarUpdater.Stop()
        gIsReminderTimerRunning = False
        statusRemainingTime.Text = "No Reminder Running"
        statusRemainingTime.ForeColor = Color.Red
        btnStartStop.Text = "Start Reminder"
        ToastNotificationForm.Close()
    End Sub

    Private Sub timerReminder_Tick(sender As Object, e As EventArgs) Handles timerReminder.Tick
        ToastNotificationForm.gNotificationDuration = My.Settings.notification_duration * 1000
        ToastNotificationForm.gNotificationWindowSize = New Size(750, 80)
        ToastNotificationForm.gNotificationMessage = "Hey You, Please Take a Break For 2 Mins! " +
            "Continuous Sitting Causes BACK PAIN, HEART DISEASE and KIDNEY FAILURE. " +
            "Stand up and Walk 10 Steps, Now!!"
        ToastNotificationForm.Show()
        gRemainingIntervalMilliseconds = gIntervalMilliseconds
    End Sub

    Private Function getIntervalAsMilliseconds() As Integer
        Dim hours As Integer = Integer.Parse(lblHours.Text.ToString)
        Dim minutes As Integer = Integer.Parse(lblMinutes.Text.ToString)
        Dim seconds As Integer = Integer.Parse(lblSeconds.Text.ToString)

        Return ((hours * HOURS_MILLISECONDS_CONVERTER) + (minutes * MINUTES_MILLISECONDS_CONVERTER) + (seconds * SECONDS_MILLISECONDS_CONVERTER))
    End Function

    Private Function getDisplayIntervalFromScreen() As String
        Dim hours As Integer = Integer.Parse(lblHours.Text.ToString)
        Dim minutes As Integer = Integer.Parse(lblMinutes.Text.ToString)
        Dim seconds As Integer = Integer.Parse(lblSeconds.Text.ToString)

        Return getDisplayInterval(hours, minutes, seconds)
    End Function

    Private Function getDisplayIntervalFromMilliseconds(milliseconds As Integer) As String
        Dim hours As Integer = milliseconds / HOURS_MILLISECONDS_CONVERTER
        milliseconds = milliseconds Mod HOURS_MILLISECONDS_CONVERTER
        Dim minutes As Integer = milliseconds / MINUTES_MILLISECONDS_CONVERTER
        milliseconds = milliseconds Mod MINUTES_MILLISECONDS_CONVERTER
        Dim seconds As Integer = milliseconds / SECONDS_MILLISECONDS_CONVERTER

        Return getDisplayInterval(hours, minutes, seconds)
    End Function

    Private Function getDisplayInterval(hours As Integer, minutes As Integer, seconds As Integer) As String
        Return hours.ToString("00") + " Hrs   " + minutes.ToString("00") + " Mins   " + seconds.ToString("00") + " Secs"
    End Function

    Private Sub trackBarHours_ValueChanged(sender As Object, e As EventArgs) Handles trackBarSeconds.ValueChanged, trackBarMinutes.ValueChanged, trackBarHours.ValueChanged
        Dim trackBar As TrackBar = sender
        Dim trackerBarDataKeeper As TrackerBarDataKeeper = gTrackerBarDataKeepers.Item(trackBar)
        trackerBarDataKeeper.displayLabel.Text = trackBar.Value.ToString("00")
        My.Settings.Item(trackerBarDataKeeper.persistentKey) = trackBar.Value
        My.Settings.Save()
    End Sub

    Private Sub setPropertiesForCustomDialog()
        CustomDialog.btnOption1.BackColor = Color.Green
        CustomDialog.btnOption1.ForeColor = Color.White

        CustomDialog.btnOption2.BackColor = Color.Red
        CustomDialog.btnOption2.ForeColor = Color.Maroon

        CustomDialog.btnOption3.BackColor = Color.Gold
        CustomDialog.btnOption3.ForeColor = Color.Olive
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If gIsExitClicked = False And gIsReminderTimerRunning = True Then
            setPropertiesForCustomDialog()
            Dim result As Integer = CustomDialog.showMyDialog("Closing Confirmation", "Continue and Minimize to Tray", "Abort Reminder and Exit", "Return to Application")
            If result = CustomDialog.OPTION_ONE Then
                Me.WindowState = FormWindowState.Minimized
                ShowInTaskbar = False
                e.Cancel = True
                trayIcon.Visible = True
            ElseIf result = CustomDialog.OPTION_TWO Then
                exitApp()
            ElseIf result = CustomDialog.OPTION_THREE Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub exitApp()
        trayIcon.Visible = False
        gIsExitClicked = True
        stopReminder()
        Application.Exit()
    End Sub

    Private Sub notifyIconForTray_DoubleClick(sender As Object, e As EventArgs) Handles trayIcon.DoubleClick
        showMainForm()
    End Sub

    Public Sub showMainForm()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        trayIcon.Visible = False
    End Sub

    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            trayIcon.Visible = True
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub contextMenuForTrayIcon_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles contextMenuForTrayIcon.ItemClicked
        Select Case e.ClickedItem.Name
            Case "menuItemExit" : exitApp()
            Case "menuItemStopReminder" : stopReminder()
            Case "menuItemShowApp" : showMainForm()
        End Select
    End Sub

    Private Sub timerStatusBarUpdater_Tick(sender As Object, e As EventArgs) Handles timerStatusBarUpdater.Tick
        gRemainingIntervalMilliseconds -= SECONDS_MILLISECONDS_CONVERTER
        If Me.WindowState = FormWindowState.Normal Then
            statusRemainingTime.Text = getDisplayIntervalFromMilliseconds(gRemainingIntervalMilliseconds)
        End If

    End Sub

    Private Sub cmbNotificationDuration_SelectedIndexChanged(sender As Object, e As EventArgs)
        My.Settings.notification_duration = cmbNotificationDuration.SelectedValue
    End Sub
End Class
