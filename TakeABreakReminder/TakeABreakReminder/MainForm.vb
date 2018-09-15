Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic.Devices
Imports NLog

Public Class FrmMain
    Shared log As Logger = LogManager.GetCurrentClassLogger()
    Const HOURS_MILLISECONDS_CONVERTER As Integer = 60 * 60 * 1000
    Const MINUTES_MILLISECONDS_CONVERTER As Integer = 60 * 1000
    Const SECONDS_MILLISECONDS_CONVERTER As Integer = 1000

    Dim gSystemSoundMapper As Dictionary(Of Integer, System.Media.SystemSound)
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
        ReminderManager.getInstance().cleanSavedReminderTable()
        loadReminderGrid()
        initReminderDuration()
        initNotificationData()
        subscribeForSettingsDataChange()
    End Sub

    Sub loadReminderGrid()
        dgReminderDetails.DataSource = ReminderManager.getInstance().getReminderTable()
    End Sub

    Private Sub subscribeForSettingsDataChange()
        AddHandler My.Settings.PropertyChanged, AddressOf Settings_DataChanged
    End Sub

    Private Sub Settings_DataChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
        Dim settingName As String = e.PropertyName

        Select Case settingName
            Case "notification_duration"
                'Only required when the notification form loaded. The setting value accessed there itself.
            Case "notification_message"
                ToastNotificationForm.lblMessage.Text = My.Settings.notification_message
            Case "notification_font"
                ToastNotificationForm.lblMessage.Font = My.Settings.notification_font
            Case "notification_backcolor"
                ToastNotificationForm.BackColor = My.Settings.notification_backcolor
            Case "notification_forecolor"
                ToastNotificationForm.lblMessage.ForeColor = My.Settings.notification_forecolor
            Case "notification_sound"
                'Only required when the notification form loaded. The setting value accessed there itself.
            Case "notification_width", "notification_height"
                ToastNotificationForm.Size = New Size(My.Settings.notification_width, My.Settings.notification_height)
                ToastNotificationForm.updateLocation()
        End Select
    End Sub

    Private Sub initReminderDuration()
        numHours.Value = My.Settings.hours
        numMinutes.Value = My.Settings.minutes
        numSeconds.Value = My.Settings.seconds
    End Sub

    Private Sub initNotificationData()
        loadNotificationDurationList()
        loadNotificationSoundList()

        txtNotificationMessage.Text = My.Settings.notification_message
        colorPickerForeColor.Color = My.Settings.notification_forecolor
        colorPickerBackColor.Color = My.Settings.notification_backcolor
        txtNotificaitonFont.Text = getFontInDisplayFormat(My.Settings.notification_font)

        numNotificationWidth.Value = My.Settings.notification_width
        numNotificationHeight.Value = My.Settings.notification_height
        numNotificationWidth.Maximum = Screen.PrimaryScreen.Bounds.Width
        numNotificationHeight.Maximum = Screen.PrimaryScreen.Bounds.Height
    End Sub

    Private Sub loadNotificationDurationList()

        Dim notificaitonDurationList As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)

        For value As Integer = 1 To 12
            Dim seconds As Integer = value * 5
            notificaitonDurationList.Add(seconds, seconds.ToString + " Seconds")
        Next

        cmbNotificationDuration.ValueMember = "Key"
        cmbNotificationDuration.DisplayMember = "Value"
        cmbNotificationDuration.DataSource = New BindingSource(notificaitonDurationList, Nothing)
        cmbNotificationDuration.SelectedValue = My.Settings.notification_duration

        AddHandler cmbNotificationDuration.SelectedIndexChanged, AddressOf cmbNotificationDuration_SelectedIndexChanged

    End Sub

    Private Sub loadNotificationSoundList()
        Dim notificaitonSoundList As Dictionary(Of String, String) = New Dictionary(Of String, String)
        notificaitonSoundList.Add("None", "None")

        Dim resourceEntry As DictionaryEntry
        Dim allResources As Object = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, False, True)
        For Each resourceEntry In allResources
            If (resourceEntry.Value.GetType() Is GetType(UnmanagedMemoryStream)) Then
                notificaitonSoundList.Add(resourceEntry.Key.ToString, resourceEntry.Key.ToString)
            End If
        Next

        cmbNotificationSound.ValueMember = "Key"
        cmbNotificationSound.DisplayMember = "Value"
        cmbNotificationSound.DataSource = New BindingSource(notificaitonSoundList, Nothing)
        cmbNotificationSound.SelectedValue = My.Settings.notification_sound

        AddHandler cmbNotificationSound.SelectedIndexChanged, AddressOf cmbNotificationSound_SelectedIndexChanged
    End Sub

    Private Sub cmbNotificationDuration_SelectedIndexChanged(sender As Object, e As EventArgs)
        My.Settings.notification_duration = cmbNotificationDuration.SelectedValue
    End Sub

    Private Sub cmbNotificationSound_SelectedIndexChanged(sender As Object, e As EventArgs)
        My.Settings.notification_sound = cmbNotificationSound.SelectedValue

        If cmbNotificationSound.SelectedValue = "None" Then
            btnPlaySound.Enabled = False
        Else
            btnPlaySound.Enabled = True
        End If
    End Sub

    Private Sub btnShowNotificationFontDialog_Click(sender As Object, e As EventArgs) Handles btnShowNotificationFontDialog.Click
        fontdialogNotificationFont.Font = My.Settings.notification_font
        If fontdialogNotificationFont.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            My.Settings.notification_font = fontdialogNotificationFont.Font
            txtNotificaitonFont.Text = getFontInDisplayFormat(My.Settings.notification_font)
        End If
    End Sub

    Private Function getFontInDisplayFormat(myFont As Font) As String
        Dim fontFamilyName As String = myFont.FontFamily.GetName(0).ToString
        Dim fontSize As String = myFont.Size.ToString
        Dim fontStyle As String = myFont.Style.ToString

        Return fontFamilyName + ", " + fontSize + "pt, style=" + fontStyle
    End Function

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If gIsReminderTimerRunning = False Then
            startReminder()
        Else
            stopReminder()
        End If

    End Sub

    Private Sub startReminder()
        Dim intervalMilliSeconds As Integer = getIntervalAsMilliseconds()

        If intervalMilliSeconds < 1000 Then
            MsgBox("The selected time for reminder must be atleast 30 seconds or more. Current value is : " + getDisplayIntervalFromScreen() + ". Please Retry!")
            Return
        End If

        'For Actual Reminder Timer start
        timerReminder.Interval = intervalMilliSeconds
        gIntervalMilliseconds = intervalMilliSeconds
        timerReminder.Start()
        gIsReminderTimerRunning = True

        'To show countdown time on the status bar
        gRemainingIntervalMilliseconds = gIntervalMilliseconds
        timerStatusBarUpdater.Start()
        statusRemainingTime.Text = getDisplayIntervalFromMilliseconds(0)
        statusRemainingTime.ForeColor = Color.Maroon

        'Update UI as the timer started
        btnStartStop.Text = "Stop Reminder"
        grpIntervalDuration.Enabled = False
    End Sub

    Private Sub stopReminder()
        'For Actual Reminder Timer stop
        timerReminder.Stop()
        gIsReminderTimerRunning = False

        'To stop countdown time on the status bar
        timerStatusBarUpdater.Stop()
        statusRemainingTime.Text = "No Reminder Running"
        statusRemainingTime.ForeColor = Color.Red

        'Update UI as the timer stopped
        btnStartStop.Text = "Start Reminder"
        ToastNotificationForm.Close()
        grpIntervalDuration.Enabled = True
    End Sub

    Private Sub timerReminder_Tick(sender As Object, e As EventArgs) Handles timerReminder.Tick
        ToastNotificationForm.Show()

        'To reset countdown time on the status bar
        gRemainingIntervalMilliseconds = gIntervalMilliseconds
    End Sub

    Private Function getIntervalAsMilliseconds() As Integer
        Dim hours As Integer = numHours.Value
        Dim minutes As Integer = numMinutes.Value
        Dim seconds As Integer = numSeconds.Value

        Return ((hours * HOURS_MILLISECONDS_CONVERTER) + (minutes * MINUTES_MILLISECONDS_CONVERTER) + (seconds * SECONDS_MILLISECONDS_CONVERTER))
    End Function

    Private Function getDisplayIntervalFromScreen() As String
        Dim hours As Integer = numHours.Value
        Dim minutes As Integer = numMinutes.Value
        Dim seconds As Integer = numSeconds.Value

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
            Dim result As Integer = CustomDialog.showMyDialog("Reminder is Running, Confirm Your Action", "Continue and Minimize to Tray", "Abort Reminder and Exit", "Return to Application")
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

    Private Sub txtNotificationMessage_TextChanged(sender As Object, e As EventArgs) Handles txtNotificationMessage.TextChanged
        My.Settings.notification_message = txtNotificationMessage.Text
    End Sub

    Private Sub colorPickerBackColor_ColorChanged(sender As Object, e As EventArgs) Handles colorPickerBackColor.ColorChanged
        My.Settings.notification_backcolor = colorPickerBackColor.Color
    End Sub

    Private Sub colorPickerForeColor_ColorChanged(sender As Object, e As EventArgs) Handles colorPickerForeColor.ColorChanged
        My.Settings.notification_forecolor = colorPickerForeColor.Color
    End Sub

    Private Sub btnPlaySong_Click(sender As Object, e As EventArgs) Handles btnPlaySound.Click
        Dim selectedSound As String = cmbNotificationSound.SelectedValue
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(selectedSound), AudioPlayMode.Background)
    End Sub

    Private Sub numHours_ValueChanged(sender As Object, e As EventArgs) Handles numHours.ValueChanged
        My.Settings.hours = numHours.Value
    End Sub

    Private Sub numMinutes_ValueChanged(sender As Object, e As EventArgs) Handles numMinutes.ValueChanged
        My.Settings.minutes = numMinutes.Value
    End Sub

    Private Sub numSeconds_ValueChanged(sender As Object, e As EventArgs) Handles numSeconds.ValueChanged
        My.Settings.seconds = numSeconds.Value
    End Sub

    Private Sub numNotificationWidth_ValueChanged(sender As Object, e As EventArgs) Handles numNotificationWidth.ValueChanged
        My.Settings.notification_width = numNotificationWidth.Value
    End Sub

    Private Sub numNotificationHeight_ValueChanged(sender As Object, e As EventArgs) Handles numNotificationHeight.ValueChanged
        My.Settings.notification_height = numNotificationHeight.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReminderManager.getInstance().saveReminder(1, New Reminder(0, 13, 10, 15))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim reminder As Reminder = ReminderManager.getInstance().getReminder(1)

        MsgBox(reminder.DurationHours.ToString)
    End Sub

    Private Sub btnAddReminder_Click(sender As Object, e As EventArgs) Handles btnAddReminder.Click
        Dim creationStatus As String = btnAddReminder.Tag

        If creationStatus = "CreationNotInProgress" Then
            btnAddReminder.Tag = "CreationInProgress"
            btnAddReminder.Text = "Confirm"
            btnStartStop.Visible = False
        ElseIf creationStatus = "CreationInProgress" Then
            btnAddReminder.Tag = "CreationNotInProgress"

            Dim reminderTable As DataTable = dgReminderDetails.DataSource
            Dim reminderRow As DataRow = reminderTable.NewRow()
            reminderRow("type") = 1
            reminderTable.Rows.InsertAt(reminderRow, 0)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReminderManager.getInstance().cleanSavedReminderTable()
    End Sub
End Class
