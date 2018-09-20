Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic.Devices
Imports NLog
Imports TakeABreakReminder

Public Class FrmMain
    Shared log As Logger = LogManager.GetCurrentClassLogger()

    Private gIsExitClicked As Boolean = False
    Private gReminderManager As ReminderManager = ReminderManager.getInstance()
    Private gSelectedReminderId As Integer = -1

    Private gIsReminderTimerRunning As Boolean = False

    Private Class TrackerBarDataKeeper
        Public displayLabel As Label
        Public persistentKey As String

        Public Sub New(pDisplayLabel As Label, pPersistentKey As String)
            displayLabel = pDisplayLabel
            persistentKey = pPersistentKey
        End Sub
    End Class

    Private Class ReminderUpdateObserver : Implements ReminderManager.IReminderUpdateObserver

        Public Sub reminderStopped() Implements ReminderManager.IReminderUpdateObserver.reminderStopped
            FrmMain.btnStartStopReminder.Text = "Start"
        End Sub

        Private Sub remainingTimeChanged(remainingTimeStr As String) Implements ReminderManager.IReminderUpdateObserver.remainingTimeChanged
            FrmMain.statusRemainingTimeLabel.Text = remainingTimeStr
        End Sub
    End Class

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gReminderManager.startAllRunningStatusReminders()
        setRadioBoxReminderTypes()

        gReminderManager.registerForRemainingTime(New ReminderUpdateObserver)

        setDataGrid(dgReminderDetails, gReminderManager.getReminderTable())
        dgReminderDetails.ClearSelection()
        loadNotificationDurationList()
        loadNotificationSoundList()
        numNotificationWidth.Maximum = Screen.PrimaryScreen.Bounds.Width
        numNotificationHeight.Maximum = Screen.PrimaryScreen.Bounds.Height
        btnAddReminder.Tag = REMINDER_CREATION_STATUS_NONE
    End Sub

    Private Sub setRadioBoxReminderTypes()
        radReminderTypeInterval.Tag = REMINDER_TYPE_INTERVAL
        radReminderTypeDaily.Tag = REMINDER_TYPE_DAILY
        radReminderTypeWeekly.Tag = REMINDER_TYPE_WEEKLY
        radReminderTypeSpecific.Tag = REMINDER_TYPE_SPECIFIC_TIME
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
        'cmbNotificationDuration.SelectedValue = My.Settings.notification_duration
        cmbNotificationDuration.Tag = cmbNotificationDuration.SelectedIndex

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
        'cmbNotificationSound.SelectedValue = My.Settings.notification_sound
        cmbNotificationSound.Tag = cmbNotificationSound.SelectedIndex

        AddHandler cmbNotificationSound.SelectedIndexChanged, AddressOf cmbNotificationSound_SelectedIndexChanged
    End Sub

    Private Sub cmbNotificationSound_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbNotificationSound.SelectedValue = "None" Then
            btnPlaySound.Enabled = False
        Else
            btnPlaySound.Enabled = True
        End If
    End Sub

    Private Sub btnShowNotificationFontDialog_Click(sender As Object, e As EventArgs) Handles btnShowNotificationFontDialog.Click
        If Not String.IsNullOrEmpty(txtNotificaitonFont.Text) Then
            fontdialogNotificationFont.Font = getFontObjFromDisplayFormat(txtNotificaitonFont.Text)
        End If

        If fontdialogNotificationFont.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtNotificaitonFont.Text = getFontInDisplayFormat(fontdialogNotificationFont.Font)
        End If
    End Sub

    Private Sub btnStartStopReminder_Click(sender As Object, e As EventArgs) Handles btnStartStopReminder.Click
        If gSelectedReminderId = -1 Then
            MsgBox("Please select a reminder to do this operation")
            Return
        End If

        Dim reminderRow As DataRow = gReminderManager.getReminderRow(gSelectedReminderId)
        Dim reminderStatus As String = reminderRow(COL_REMINDER_STATUS)
        Dim reminderType As String = reminderRow.Item(COL_REMINDER_TYPE)
        Dim currentTime As DateTime = DateTime.Now
        If reminderType = REMINDER_TYPE_SPECIFIC_TIME AndAlso reminderRow(COL_REMINDER_SPECIFIC_TIME) <= currentTime Then
            MsgBox("Sorry, the time for this reminder has already passed. Please set a new time to start the reminder")
            Return
        End If

        If reminderStatus = REMINDER_STATUS_NOT_RUNNING Then
            gReminderManager.startReminder(gSelectedReminderId)
            btnStartStopReminder.Text = "Stop"
        ElseIf reminderStatus = REMINDER_STATUS_RUNNING Then
            gReminderManager.stopReminder(gSelectedReminderId)
            btnStartStopReminder.Text = "Start"
        End If

        gReminderManager.updateStatusBar(reminderRow)

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
        If gIsExitClicked = False AndAlso gIsReminderTimerRunning = True Then
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
            Case "menuItemShowApp" : showMainForm()
        End Select
    End Sub

    Private Sub btnPlaySong_Click(sender As Object, e As EventArgs) Handles btnPlaySound.Click
        Dim selectedSound As String = cmbNotificationSound.SelectedValue

        If selectedSound <> "None" Then
            My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(selectedSound), AudioPlayMode.Background)
        End If

    End Sub

    Private Sub btnAddReminder_Click(sender As Object, e As EventArgs) Handles btnAddReminder.Click

        Dim creationStatus As Integer = btnAddReminder.Tag

        If creationStatus = REMINDER_CREATION_STATUS_NONE Then

            resetScreen()
            btnAddReminder.Tag = REMINDER_CREATION_STATUS_IN_PROGRESS
            btnAddReminder.Text = "Confirm"
            btnClearScreen.Text = "Cancel"

        ElseIf creationStatus = REMINDER_CREATION_STATUS_IN_PROGRESS Then

            If validateReminderData() = False Then
                Return
            End If

            Dim newReminderRow As DataRow = gReminderManager.createNewReminderRow()
            gReminderManager.commitNewReminderRow(fillReminderRowFromScreen(newReminderRow))

            gSelectedReminderId = newReminderRow.Item(COL_REMINDER_ID)
            selectRowAtDataGridByKey(dgReminderDetails, COL_REMINDER_ID, gSelectedReminderId)

            enableControlsOnReminderSelected(True)

            btnAddReminder.Tag = REMINDER_CREATION_STATUS_NONE
            btnAddReminder.Text = "New"
            btnClearScreen.Text = "Clear"
        End If

        allowEditReminder(True)
    End Sub

    Private Function fillReminderRowFromScreen(reminderRow As DataRow, Optional isNewRecord As Boolean = True) As DataRow
        Dim reminderType As String = getSelectedReminderType()
        reminderRow(COL_REMINDER_TYPE) = reminderType
        reminderRow(COL_REMINDER_REPEAT_MAX) = numRepeat.Value
        reminderRow(COL_REMINDER_INTERVAL) = "none"

        Select Case reminderType
            Case REMINDER_TYPE_INTERVAL
                reminderRow(COL_REMINDER_INTERVAL) = getFormattedInterval(numHours.Value, numMinutes.Value, numSeconds.Value)
            Case REMINDER_TYPE_SPECIFIC_TIME
                reminderRow(COL_REMINDER_SPECIFIC_TIME) = dtSpecific.Value
                reminderRow(COL_REMINDER_REPEAT_MAX) = 1
            Case REMINDER_TYPE_DAILY

            Case REMINDER_TYPE_WEEKLY

        End Select

        If isNewRecord Then
            reminderRow(COL_REMINDER_CREATED_TIME) = DateTime.Now
            reminderRow(COL_REMINDER_REPEAT_ELAPSED) = 0
        Else
            reminderRow(COL_REMINDER_UPDATED_TIME) = DateTime.Now
        End If

        reminderRow(COL_REMINDER_STATUS) = REMINDER_STATUS_NOT_RUNNING
        reminderRow(COL_NOTIFICATION_DURATION) = cmbNotificationDuration.SelectedValue
        reminderRow(COL_NOTIFICATION_SOUND) = cmbNotificationSound.Text
        reminderRow(COL_NOTIFICATION_MESSAGE) = txtNotificationMessage.Text
        reminderRow(COL_NOTIFICATION_FONT) = txtNotificaitonFont.Text
        reminderRow(COL_NOTIFICATION_BACKCOLOR) = colorPickerBackColor.Color.Name.ToString
        reminderRow(COL_NOTIFICATION_FORECOLOR) = colorPickerForeColor.Color.Name.ToString
        reminderRow(COL_NOTIFICATION_WIDTH) = numNotificationWidth.Value
        reminderRow(COL_NOTIFICATION_HEIGHT) = numNotificationHeight.Value

        Return reminderRow
    End Function

    Private Sub fillScreenFromReminderRow(reminderRow As DataRow)
        Dim reminderType As String = reminderRow(COL_REMINDER_TYPE)

        If reminderType = REMINDER_TYPE_INTERVAL Then
            Dim reminderInterval As Double = convertFormattedIntervalToSeconds(reminderRow(COL_REMINDER_INTERVAL))
            numHours.Value = getHoursFromTotalSeconds(reminderInterval)
            numMinutes.Value = getMinutesFromTotalSeconds(reminderInterval)
            numSeconds.Value = getSecondsFromTotalSeconds(reminderInterval)
        End If
        numRepeat.Value = reminderRow(COL_REMINDER_REPEAT_MAX)
        cmbNotificationSound.Text = reminderRow(COL_NOTIFICATION_SOUND)
        cmbNotificationDuration.SelectedValue = reminderRow(COL_NOTIFICATION_DURATION)
        txtNotificationMessage.Text = reminderRow(COL_NOTIFICATION_MESSAGE)
        txtNotificaitonFont.Text = reminderRow(COL_NOTIFICATION_FONT)
        colorPickerBackColor.Color = Color.FromName(reminderRow(COL_NOTIFICATION_BACKCOLOR))
        colorPickerForeColor.Color = Color.FromName(reminderRow(COL_NOTIFICATION_FORECOLOR))
        numNotificationWidth.Value = reminderRow(COL_NOTIFICATION_WIDTH)
        numNotificationHeight.Value = reminderRow(COL_NOTIFICATION_HEIGHT)
    End Sub

    Private Sub resetScreen()
        cmbNotificationDuration.SelectedIndex = 0
        cmbNotificationSound.SelectedIndex = 0
        txtNotificationMessage.Text = txtNotificationMessage.Tag.ToString
        txtNotificaitonFont.Text = txtNotificaitonFont.Tag.ToString
        colorPickerBackColor.Color = Color.FromName(colorPickerBackColor.Tag)
        colorPickerForeColor.Color = Color.FromName(colorPickerForeColor.Tag)
        numNotificationWidth.Value = numNotificationWidth.Tag
        numNotificationHeight.Value = numNotificationHeight.Tag
        numRepeat.Value = numRepeat.Tag
        dgReminderDetails.ClearSelection()
        gSelectedReminderId = -1

        btnAddReminder.Text = "New"
        btnAddReminder.Tag = REMINDER_CREATION_STATUS_NONE
        enableControlsOnReminderSelected(False)
        allowEditReminder(False)

        btnClearScreen.Text = "Clear"
    End Sub


    Private Function validateReminderData() As Boolean
        Dim reminderType As String = getSelectedReminderType()

        Select Case reminderType
            Case REMINDER_TYPE_INTERVAL
                If convertTimeToSeconds(numHours.Value, numMinutes.Value, numSeconds.Value) < REMINDER_INTERVAL_MINIMUM_LIMIT_SECONDS Then
                    MsgBox("The reminder interval must be 30 seconds or more. Current value is : " + getFormattedInterval(numHours.Value, numMinutes.Value, numSeconds.Value) + ". Please Retry!")
                    Return False
                End If
            Case REMINDER_TYPE_SPECIFIC_TIME
                ''compare with current time

            Case REMINDER_TYPE_DAILY

            Case REMINDER_TYPE_WEEKLY

        End Select

        Return True
    End Function

    Private Sub cmbNotificationDuration_Leave(sender As Object, e As EventArgs) Handles cmbNotificationDuration.Leave
        If cmbNotificationDuration.SelectedIndex = -1 Then
            cmbNotificationDuration.SelectedIndex = cmbNotificationDuration.Tag
        Else
            cmbNotificationDuration.Tag = cmbNotificationDuration.SelectedIndex
        End If
    End Sub

    Private Sub cmbNotificationSound_Leave(sender As Object, e As EventArgs) Handles cmbNotificationSound.Leave
        If cmbNotificationSound.SelectedIndex = -1 Then
            cmbNotificationSound.SelectedIndex = cmbNotificationSound.Tag
        Else
            cmbNotificationSound.Tag = cmbNotificationSound.SelectedIndex
        End If
    End Sub

    Private Sub dgReminderDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReminderDetails.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        If btnAddReminder.Tag = REMINDER_CREATION_STATUS_IN_PROGRESS Then
            MessageBox.Show("Sorry, you cannot view any existing reminders because you are in the middle of creating a new reminder. Please compelete the creation or cancel it", "ERROR")
            dgReminderDetails.ClearSelection()
            Return
        End If

        gSelectedReminderId = dgReminderDetails.Item("colReminderId", e.RowIndex).Value
        Dim reminderRow As DataRow = gReminderManager.getReminderRow(gSelectedReminderId)

        fillScreenFromReminderRow(reminderRow)

        enableControlsOnReminderSelected(True)
        allowEditReminder(True)

        If reminderRow(COL_REMINDER_STATUS) = REMINDER_STATUS_RUNNING Then
            btnStartStopReminder.Text = "Stop"
        Else
            btnStartStopReminder.Text = "Start"
        End If

        gReminderManager.updateStatusBar(reminderRow)
    End Sub

    Private Sub enableControlsOnReminderSelected(enabledStatus As Boolean)
        btnUpdateReminder.Enabled = enabledStatus
        btnStartStopReminder.Enabled = enabledStatus
        btnDeleteReminder.Enabled = enabledStatus
    End Sub

    Private Sub allowEditReminder(isAllowed As Boolean)
        grpReminderTypeInterval.Enabled = isAllowed
        grpPopupSettings.Enabled = isAllowed
        grpReminderType.Enabled = isAllowed
    End Sub

    Private Sub btnUpdateReminder_Click(sender As Object, e As EventArgs) Handles btnUpdateReminder.Click
        If gSelectedReminderId = -1 Then
            MsgBox("Please select a reminder to do this operation")
            Return
        End If
        fillReminderRowFromScreen(gReminderManager.getReminderRow(gSelectedReminderId), False)
        gReminderManager.commitUpdatedReminderRow()
    End Sub

    Private Sub btnDeleteReminder_Click(sender As Object, e As EventArgs) Handles btnDeleteReminder.Click
        If gSelectedReminderId = -1 Then
            MsgBox("Please select a reminder to do this operation")
            Return
        End If

        Dim reminderRow As DataRow = gReminderManager.getReminderRow(gSelectedReminderId)
        Dim reminderStatus As String = reminderRow(COL_REMINDER_STATUS)

        Dim deletionConfirmed As Boolean = True
        If reminderStatus = REMINDER_STATUS_RUNNING Then
            If MessageBox.Show("This reminder is currently running. Do you want to stop this reminder and delete it?", "CONFIRMATION", System.Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                gReminderManager.stopReminder(gSelectedReminderId)
            Else
                deletionConfirmed = False
            End If
        End If

        If deletionConfirmed Then
            gReminderManager.commitDeletedReminderRow(reminderRow)
            resetScreen()
            gSelectedReminderId = -1
        End If

    End Sub

    Private Sub btnClearScreen_Click(sender As Object, e As EventArgs) Handles btnClearScreen.Click
        resetScreen()
    End Sub
    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub radReminderTypeInterval_CheckedChanged(sender As Object, e As EventArgs) Handles radReminderTypeInterval.CheckedChanged
        updateVisibilityByReminderType(REMINDER_TYPE_INTERVAL, radReminderTypeInterval.Checked)
    End Sub

    Private Sub radReminderTypeDaily_CheckedChanged(sender As Object, e As EventArgs) Handles radReminderTypeDaily.CheckedChanged
        updateVisibilityByReminderType(REMINDER_TYPE_DAILY, radReminderTypeDaily.Checked)
    End Sub

    Private Sub radReminderTypeWeekly_CheckedChanged(sender As Object, e As EventArgs) Handles radReminderTypeWeekly.CheckedChanged
        updateVisibilityByReminderType(REMINDER_TYPE_WEEKLY, radReminderTypeWeekly.Checked)
    End Sub

    Private Sub radReminderTypeSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles radReminderTypeSpecific.CheckedChanged
        updateVisibilityByReminderType(REMINDER_TYPE_SPECIFIC_TIME, radReminderTypeSpecific.Checked)
    End Sub

    Private Sub updateVisibilityByReminderType(reminderType As String, checked As Boolean)
        grpReminderTypeInterval.Visible = False
        grpReminderTypeSpecific.Visible = False

        Select Case reminderType
            Case REMINDER_TYPE_INTERVAL
                grpReminderTypeInterval.Visible = True
            Case REMINDER_TYPE_DAILY

            Case REMINDER_TYPE_WEEKLY

            Case REMINDER_TYPE_SPECIFIC_TIME
                grpReminderTypeSpecific.Visible = True
        End Select
    End Sub

    Private Function getSelectedReminderType() As String
        Return grpReminderType.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).Tag
    End Function
End Class
