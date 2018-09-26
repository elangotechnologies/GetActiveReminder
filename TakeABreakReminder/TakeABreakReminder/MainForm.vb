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
    Private gSelectedReminderId As Integer = REMINDER_ID_NONE

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
            FrmMain.btnStartStopReminder.BackgroundImage = My.Resources.start
        End Sub

        Private Sub remainingTimeChanged(remainingTimeStr As String) Implements ReminderManager.IReminderUpdateObserver.remainingTimeChanged
            FrmMain.statusRemainingTimeLabel.Text = remainingTimeStr
        End Sub
    End Class

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim buttonsList As New List(Of PictureBox) From {btnAddReminder, btnDeleteReminder, btnStartStopReminder, btnClearScreen, btnEditReminder}
        addButtonAppearnceEventHandlers(buttonsList)
        gReminderManager.registerForRemainingTime(New ReminderUpdateObserver)
        loadNotificationDurationList()
        loadNotificationSoundList()
        setDataGrid(dgReminderDetails, gReminderManager.getReminderTable())

        radReminderTypeInterval.Tag = REMINDER_TYPE_INTERVAL
        radReminderTypeDaily.Tag = REMINDER_TYPE_DAILY
        radReminderTypeSpecific.Tag = REMINDER_TYPE_SPECIFIC_TIME
        numNotificationWidth.Maximum = Screen.PrimaryScreen.Bounds.Width
        numNotificationHeight.Maximum = Screen.PrimaryScreen.Bounds.Height

        setVisibilityByByOperation(OPERATION_SCREEN_LOADED)

        'this should be in last
        gReminderManager.startAllRunningStatusReminders()
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
        If gSelectedReminderId = REMINDER_ID_NONE Then
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
            setVisibilityByByOperation(OPERATION_REMINDER_STARTED)
        ElseIf reminderStatus = REMINDER_STATUS_RUNNING Then
            gReminderManager.stopReminder(gSelectedReminderId)
            setVisibilityByByOperation(OPERATION_REMINDER_STOPPED)

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

    Private Function fillReminderRowFromScreen(reminderRow As DataRow, Optional isNewRecord As Boolean = True) As DataRow
        Dim reminderType As String = getSelectedReminderType()
        reminderRow(COL_REMINDER_TYPE) = reminderType
        reminderRow(COL_REMINDER_REPEAT_MAX) = numRepeat.Value
        reminderRow(COL_REMINDER_INTERVAL) = "none"
        reminderRow(COL_REMINDER_DAILY) = "none"

        Select Case reminderType
            Case REMINDER_TYPE_INTERVAL
                reminderRow(COL_REMINDER_INTERVAL) = getFormattedInterval(numHours.Value, numMinutes.Value, numSeconds.Value)
            Case REMINDER_TYPE_SPECIFIC_TIME
                reminderRow(COL_REMINDER_SPECIFIC_TIME) = dtSpecific.Value
                reminderRow(COL_REMINDER_REPEAT_MAX) = 1
            Case REMINDER_TYPE_DAILY
                reminderRow(COL_REMINDER_DAILY) = getDailyTimeStr()
        End Select

        If isNewRecord Then
            reminderRow(COL_REMINDER_CREATED_TIME) = DateTime.Now
            reminderRow(COL_REMINDER_REPEAT_ELAPSED) = 0
        Else
            reminderRow(COL_REMINDER_UPDATED_TIME) = DateTime.Now
        End If
        reminderRow(COL_REMINDER_NEXT_NOTIFY_TIME) = DBNull.Value

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

    Private Function getDailyTimeStr() As String
        Dim selectedDailyTimeStr As String = "none"
        Dim selectedDailyTimeList As New List(Of String)

        For Each dayIndex As Integer In lvDaily.CheckedIndices
            If dayIndex <> 0 Then
                selectedDailyTimeList.Add(indexToDaysMap(dayIndex))
            End If
        Next
        selectedDailyTimeStr = String.Join("|", selectedDailyTimeList.ToArray)
        selectedDailyTimeStr += " " + dtDailyTime.Value.ToString("hh:mm:ss tt", CultureInfo.CurrentCulture)

        Return selectedDailyTimeStr
    End Function

    Private Sub updateScreenFromReminderRow()
        Dim reminderRow As DataRow = gReminderManager.getReminderRow(gSelectedReminderId)
        Dim reminderType As String = reminderRow(COL_REMINDER_TYPE)

        Select Case reminderType
            Case REMINDER_TYPE_INTERVAL
                Dim reminderInterval As Double = convertFormattedIntervalToSeconds(reminderRow(COL_REMINDER_INTERVAL))
                numHours.Value = getHoursFromTotalSeconds(reminderInterval)
                numMinutes.Value = getMinutesFromTotalSeconds(reminderInterval)
                numSeconds.Value = getSecondsFromTotalSeconds(reminderInterval)
            Case REMINDER_TYPE_SPECIFIC_TIME
                Dim specifTime As DateTime = reminderRow(COL_REMINDER_SPECIFIC_TIME)
                dtSpecific.Value = specifTime
            Case REMINDER_TYPE_DAILY
                loadDailyReminderFromRow(reminderRow)
        End Select

        numRepeat.Value = reminderRow(COL_REMINDER_REPEAT_MAX)
        cmbNotificationSound.Text = reminderRow(COL_NOTIFICATION_SOUND)
        cmbNotificationDuration.SelectedValue = reminderRow(COL_NOTIFICATION_DURATION)
        txtNotificationMessage.Text = reminderRow(COL_NOTIFICATION_MESSAGE)
        txtNotificaitonFont.Text = reminderRow(COL_NOTIFICATION_FONT)
        colorPickerBackColor.Color = Color.FromName(reminderRow(COL_NOTIFICATION_BACKCOLOR))
        colorPickerForeColor.Color = Color.FromName(reminderRow(COL_NOTIFICATION_FORECOLOR))
        numNotificationWidth.Value = reminderRow(COL_NOTIFICATION_WIDTH)
        numNotificationHeight.Value = reminderRow(COL_NOTIFICATION_HEIGHT)

        setVisibilityByByOperation(OPERATION_REMINDER_SELECTED)
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
                If dtSpecific.Value <= DateTime.Now Then
                    MsgBox("The selected time is already crossed. Please select a new time")
                    Return False
                End If
            Case REMINDER_TYPE_DAILY
                If lvDaily.CheckedItems.Count <= 0 Then
                    MsgBox("Atleast one day must be selected")
                    Return False
                End If
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

        If btnAddReminder.Tag = OPERATION_ADD_STARTED Then
            MessageBox.Show("Sorry, you cannot view any existing reminders because you are in the middle of creating a new reminder. Please compelete the creation or cancel it", "ERROR")
            dgReminderDetails.ClearSelection()
            Return
        End If

        If btnEditReminder.Tag = OPERATION_EDIT_STARTED Then
            MessageBox.Show("Sorry, you cannot view any existing reminders because you are in the middle of editing an exisiting reminder. Please compelete the edit operation or cancel it", "ERROR")
            selectRowAtDataGridByKey(dgReminderDetails, COL_REMINDER_ID, gSelectedReminderId)
            Return
        End If

        gSelectedReminderId = dgReminderDetails.Item("colReminderId", e.RowIndex).Value

        setVisibilityByByOperation(OPERATION_REMINDER_SELECTED)

        updateScreenFromReminderRow()

    End Sub

    Private Sub btnDeleteReminder_Click(sender As Object, e As EventArgs) Handles btnDeleteReminder.Click
        If gSelectedReminderId = REMINDER_ID_NONE Then
            MsgBox("Please select a reminder to do this operation")
            Return
        End If
        Dim reminderId As Integer = gSelectedReminderId
        Dim reminderRow As DataRow = gReminderManager.getReminderRow(reminderId)
        Dim reminderStatus As String = reminderRow(COL_REMINDER_STATUS)

        'Dim deletionConfirmed As Boolean = True
        'If reminderStatus = REMINDER_STATUS_RUNNING Then
        '    If MessageBox.Show("This reminder is currently running. Do you want to stop this reminder and delete it?", "CONFIRMATION", System.Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        '        gReminderManager.stopReminder(reminderId)
        '    Else
        '        deletionConfirmed = False
        '    End If
        'End If

        'If deletionConfirmed Then
        gReminderManager.commitDeletedReminderRow(reminderRow)
            gSelectedReminderId = REMINDER_ID_NONE
            setVisibilityByByOperation(OPERATION_DELETE_COMPLETED)
        statusRemainingTimeLabel.Text = "Reminder with id " + reminderId.ToString + " is deleted successfully"
        'End If

    End Sub

    Private Sub btnClearScreen_Click(sender As Object, e As EventArgs) Handles btnClearScreen.Click

        If btnAddReminder.Tag = OPERATION_ADD_STARTED Then
            setVisibilityByByOperation(OPERATION_ADD_CANCELED)
        ElseIf btnEditReminder.Tag = OPERATION_EDIT_STARTED Then
            setVisibilityByByOperation(OPERATION_EDIT_CANCELED)
        Else
            setVisibilityByByOperation(OPERATION_SCREEN_CLEARED)
        End If

    End Sub
    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub radReminderTypeInterval_CheckedChanged(sender As Object, e As EventArgs) Handles radReminderTypeInterval.CheckedChanged
        If radReminderTypeInterval.Checked = True Then
            setVisibilityByByOperation(OPERATION_REMINDER_TYPE_INTERVAL_CHECKED)
        Else
            setVisibilityByByOperation(OPERATION_REMINDER_TYPE_INTERVAL_UNCHECKED)
        End If
    End Sub

    Private Sub radReminderTypeDaily_CheckedChanged(sender As Object, e As EventArgs) Handles radReminderTypeDaily.CheckedChanged
        If radReminderTypeDaily.Checked = True Then
            setVisibilityByByOperation(OPERATION_REMINDER_TYPE_DAILY_CHECKED)
        Else
            setVisibilityByByOperation(OPERATION_REMINDER_TYPE_DAILY_UNCHECKED)
        End If
    End Sub

    Private Sub radReminderTypeSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles radReminderTypeSpecific.CheckedChanged
        If radReminderTypeSpecific.Checked = True Then
            setVisibilityByByOperation(OPERATION_REMINDER_TYPE_SPECIFIC_CHECKED)
        Else
            setVisibilityByByOperation(OPERATION_REMINDER_TYPE_SPECIFIC_UNCHECKED)
        End If
    End Sub

    Private Function getSelectedReminderType() As String
        Dim checkedRadioButton As RadioButton = panelReminderTypeContent.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        Return If(checkedRadioButton Is Nothing, REMINDER_TYPE_NONE, checkedRadioButton.Tag)
    End Function

    Private Sub lvDaily_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvDaily.ItemCheck
        RemoveHandler lvDaily.ItemCheck, AddressOf lvDaily_ItemCheck
        Dim newCheckedState As CheckState = e.NewValue
        If e.Index = 0 Then
            For i As Integer = 1 To lvDaily.Items.Count - 1
                lvDaily.SetItemCheckState(i, newCheckedState)
            Next
        ElseIf e.NewValue = CheckState.Unchecked Then
            If lvDaily.GetItemCheckState(0) = CheckState.Checked Then
                lvDaily.SetItemCheckState(0, newCheckedState)
            End If
        ElseIf e.NewValue = CheckState.Checked Then
            Dim allChecked As Boolean = True
            For i As Integer = 1 To lvDaily.Items.Count - 1
                If e.Index <> i Then
                    If lvDaily.GetItemCheckState(i) = CheckState.Unchecked Then
                        allChecked = False
                        Exit For
                    End If
                End If
            Next
            If allChecked = True Then
                lvDaily.SetItemCheckState(0, newCheckedState)
            End If
        End If
        AddHandler lvDaily.ItemCheck, AddressOf lvDaily_ItemCheck
    End Sub

    Public Sub loadDailyReminderFromRow(reminderRow As DataRow)
        Dim dailyReminderTime As String = reminderRow(COL_REMINDER_DAILY)

        If dailyReminderTime <> "none" Then

            For i As Integer = 0 To lvDaily.Items.Count - 1
                lvDaily.SetItemCheckState(i, CheckState.Unchecked)
            Next

            Dim dailyReminderTimeArray As Array = dailyReminderTime.Split(" ")
            Dim daysStr As String = dailyReminderTimeArray(0)
            Dim timeStr As String = dailyReminderTimeArray(1) + " " + dailyReminderTimeArray(2)

            Dim daysArray As Array = daysStr.Split("|")

            For Each day As String In daysArray
                lvDaily.SetItemCheckState(daysToIndexMap(day), CheckState.Checked)
            Next

            dtDailyTime.Value = DateTime.ParseExact(timeStr, "hh:mm:ss tt", CultureInfo.InvariantCulture)
        End If
    End Sub

    Private Sub btnAddReminder_Click(sender As Object, e As EventArgs) Handles btnAddReminder.Click

        Dim creationStatus As Integer = btnAddReminder.Tag
        If creationStatus = OPERATION_NONE Then
            setVisibilityByByOperation(OPERATION_ADD_STARTED)
        ElseIf creationStatus = OPERATION_ADD_STARTED Then

            If validateReminderData() = False Then
                Return
            End If

            Dim newReminderRow As DataRow = gReminderManager.createNewReminderRow()
            gReminderManager.commitNewReminderRow(fillReminderRowFromScreen(newReminderRow))
            gSelectedReminderId = newReminderRow.Item(COL_REMINDER_ID)

            setVisibilityByByOperation(OPERATION_ADD_COMPLETED)
            statusRemainingTimeLabel.Text = "Reminder with id " + gSelectedReminderId.ToString + " is added successfully"
        End If

    End Sub

    Private Sub btnEditReminder_Click(sender As Object, e As EventArgs) Handles btnEditReminder.Click

        If gSelectedReminderId = REMINDER_ID_NONE Then
            MsgBox("Please select a reminder to do this operation")
            Return
        End If

        'Dim reminderStatus As String = gReminderManager.getReminderStatus(gSelectedReminderId)
        'If reminderStatus = REMINDER_STATUS_RUNNING Then
        '    MsgBox("This reminder is currently running. Please stop the reminder before editing it.")
        '    Return
        'End If

        Dim editingStatus As Integer = btnEditReminder.Tag
        If editingStatus = OPERATION_NONE Then

            setVisibilityByByOperation(OPERATION_EDIT_STARTED)

        ElseIf editingStatus = OPERATION_EDIT_STARTED Then

            If validateReminderData() = False Then
                Return
            End If

            fillReminderRowFromScreen(gReminderManager.getReminderRow(gSelectedReminderId), False)
            gReminderManager.commitUpdatedReminderRow()

            setVisibilityByByOperation(OPERATION_EDIT_COMPLETED)
            statusRemainingTimeLabel.Text = "Reminder with id " + gSelectedReminderId.ToString + " is updated successfully"
        End If

    End Sub

    Private Sub btnAddReminder_EnabledChanged(sender As Object, e As EventArgs) Handles btnAddReminder.EnabledChanged
        sender.BackgroundImage = If(sender.enabled, My.Resources._new, My.Resources.new_disabled)
    End Sub

    Private Sub btnEditReminder_EnabledChanged(sender As Object, e As EventArgs) Handles btnEditReminder.EnabledChanged
        sender.BackgroundImage = If(sender.enabled, My.Resources.edit, My.Resources.edit_disabled)
    End Sub

    Private Sub btnStartStopReminder_EnabledChanged(sender As Object, e As EventArgs) Handles btnStartStopReminder.EnabledChanged
        sender.BackgroundImage = If(sender.enabled, My.Resources.start, My.Resources.start_disabled)
    End Sub

    Private Sub btnDeleteReminder_EnabledChanged(sender As Object, e As EventArgs) Handles btnDeleteReminder.EnabledChanged
        sender.BackgroundImage = If(sender.enabled, My.Resources.delete, My.Resources.delete_disabled)
    End Sub

    Private Sub btnClearScreen_EnabledChanged(sender As Object, e As EventArgs) Handles btnClearScreen.EnabledChanged
        sender.BackgroundImage = If(sender.enabled, My.Resources.clear, My.Resources.clear_disabled)
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
        For i As Integer = 0 To lvDaily.Items.Count - 1
            lvDaily.SetItemCheckState(i, CheckState.Unchecked)
        Next
        dtDailyTime.Value = DateTime.Now
        dtSpecific.Value = DateTime.Now

    End Sub

    Private Sub setVisibilityByByOperation(operation As Integer)
        Console.WriteLine("operation: " + operation.ToString)
        Select Case operation
            Case OPERATION_NONE
                ''Nothing
            Case OPERATION_SCREEN_LOADED
                grpReminderTypeInterval.Location = reminderTimePlaceHolder.Location
                grpReminderTypeDaily.Location = reminderTimePlaceHolder.Location
                grpReminderTypeSpecific.Location = reminderTimePlaceHolder.Location
                btnAddReminder.Tag = OPERATION_NONE
                btnAddReminder.BackgroundImage = My.Resources._new
                btnEditReminder.Tag = OPERATION_NONE
                btnClearScreen.BackgroundImage = My.Resources.clear

                setVisibilityByByOperation(OPERATION_SCREEN_CLEARED)

            Case OPERATION_SCREEN_CLEARED
                panelReminderType.Visible = False
                panelReminderTimeConfig.Visible = False
                panelNotificationSettings.Visible = False
                btnEditReminder.Enabled = False
                btnDeleteReminder.Enabled = False
                btnStartStopReminder.Enabled = False

            Case OPERATION_SCREEN_VALUES_RESET
                dgReminderDetails.ClearSelection()
                gSelectedReminderId = REMINDER_ID_NONE

                radReminderTypeInterval.Checked = False
                radReminderTypeDaily.Checked = False
                radReminderTypeSpecific.Checked = False

                cmbNotificationDuration.SelectedIndex = 0
                cmbNotificationSound.SelectedIndex = 0
                txtNotificationMessage.Text = txtNotificationMessage.Tag.ToString
                txtNotificaitonFont.Text = txtNotificaitonFont.Tag.ToString
                colorPickerBackColor.Color = Color.FromName(colorPickerBackColor.Tag)
                colorPickerForeColor.Color = Color.FromName(colorPickerForeColor.Tag)
                numNotificationWidth.Value = numNotificationWidth.Tag
                numNotificationHeight.Value = numNotificationHeight.Tag

            Case OPERATION_ADD_STARTED
                btnEditReminder.Enabled = False
                btnDeleteReminder.Enabled = False
                btnStartStopReminder.Enabled = False
                btnAddReminder.Tag = operation
                btnAddReminder.BackgroundImage = My.Resources.confirm
                btnClearScreen.BackgroundImage = My.Resources.cancel

                setVisibilityByByOperation(OPERATION_SCREEN_VALUES_RESET)

                panelReminderType.Visible = True
                panelReminderTimeConfig.Visible = True
                panelNotificationSettings.Visible = True

                panelReminderTypeContent.Enabled = True
                panelReminderTypeIntervalContent.Enabled = True
                panelReminderTypeDailyContent.Enabled = True
                panelReminderTypeSpecificContent.Enabled = True

                radReminderTypeInterval.Checked = True

            Case OPERATION_ADD_COMPLETED
                btnAddReminder.Tag = OPERATION_NONE
                btnAddReminder.BackgroundImage = My.Resources._new
                btnClearScreen.BackgroundImage = My.Resources.clear

                selectRowAtDataGridByKey(dgReminderDetails, COL_REMINDER_ID, gSelectedReminderId)
                setVisibilityByByOperation(OPERATION_REMINDER_SELECTED)

            Case OPERATION_ADD_CANCELED
                btnAddReminder.Tag = OPERATION_NONE
                btnAddReminder.BackgroundImage = My.Resources._new
                btnClearScreen.BackgroundImage = My.Resources.clear
                setVisibilityByByOperation(OPERATION_SCREEN_CLEARED)

            Case OPERATION_EDIT_STARTED
                btnAddReminder.Enabled = False
                btnDeleteReminder.Enabled = False
                btnStartStopReminder.Enabled = False

                btnEditReminder.Tag = operation
                btnEditReminder.BackgroundImage = My.Resources.confirm
                btnClearScreen.BackgroundImage = My.Resources.cancel ''make sure that you dont clear screen here. We just need to reload the reminder row.

                panelReminderTypeContent.Enabled = True
                panelReminderTypeIntervalContent.Enabled = True
                panelReminderTypeDailyContent.Enabled = True
                panelReminderTypeSpecificContent.Enabled = True
                panelNotificationSettingsContent.Enabled = True
                panelRepeatContent.Enabled = True

            Case OPERATION_EDIT_COMPLETED
                btnAddReminder.Enabled = True
                btnDeleteReminder.Enabled = True
                btnStartStopReminder.Enabled = True

                btnEditReminder.Tag = OPERATION_NONE
                btnEditReminder.BackgroundImage = My.Resources.edit
                btnClearScreen.BackgroundImage = My.Resources.clear

                setVisibilityByByOperation(OPERATION_REMINDER_SELECTED)

            Case OPERATION_EDIT_CANCELED
                btnAddReminder.Enabled = True
                btnEditReminder.Tag = OPERATION_NONE
                btnEditReminder.BackgroundImage = My.Resources.edit
                btnClearScreen.BackgroundImage = My.Resources.clear

                selectRowAtDataGridByKey(dgReminderDetails, COL_REMINDER_ID, gSelectedReminderId)
                setVisibilityByByOperation(OPERATION_REMINDER_SELECTED)

            Case OPERATION_DELETE_COMPLETED
                setVisibilityByByOperation(OPERATION_SCREEN_CLEARED)

            Case OPERATION_REMINDER_STARTED
                btnEditReminder.Enabled = False
                btnDeleteReminder.Enabled = False
                btnStartStopReminder.BackgroundImage = My.Resources._stop

            Case OPERATION_REMINDER_STOPPED
                btnEditReminder.Enabled = True
                btnDeleteReminder.Enabled = True
                btnStartStopReminder.BackgroundImage = My.Resources.start

            Case OPERATION_REMINDER_SELECTED
                btnEditReminder.Enabled = True
                btnStartStopReminder.Enabled = True
                btnDeleteReminder.Enabled = True

                Dim reminderRow As DataRow = gReminderManager.getReminderRow(gSelectedReminderId)
                If reminderRow IsNot Nothing AndAlso reminderRow(COL_REMINDER_STATUS) = REMINDER_STATUS_RUNNING Then
                    btnEditReminder.Enabled = False
                    btnDeleteReminder.Enabled = False
                    btnStartStopReminder.BackgroundImage = My.Resources._stop
                Else
                    btnEditReminder.Enabled = True
                    btnDeleteReminder.Enabled = True
                    btnStartStopReminder.BackgroundImage = My.Resources.start
                End If

                panelReminderType.Visible = True
                panelReminderTimeConfig.Visible = True
                panelNotificationSettings.Visible = True

                Dim reminderType As String = reminderRow(COL_REMINDER_TYPE)
                Select Case reminderType
                    Case REMINDER_TYPE_INTERVAL
                        radReminderTypeInterval.Checked = True
                    Case REMINDER_TYPE_DAILY
                        radReminderTypeDaily.Checked = True
                    Case REMINDER_TYPE_SPECIFIC_TIME
                        radReminderTypeSpecific.Checked = True
                End Select

                panelReminderTypeContent.Enabled = False
                panelReminderTypeIntervalContent.Enabled = False
                panelReminderTypeDailyContent.Enabled = False
                panelReminderTypeSpecificContent.Enabled = False
                panelNotificationSettingsContent.Enabled = False
                panelRepeatContent.Enabled = False

                gReminderManager.updateStatusBar(reminderRow)

            Case OPERATION_REMINDER_TYPE_INTERVAL_CHECKED
                grpReminderTypeInterval.Visible = True
                numHours.Value = numHours.Tag
                numMinutes.Value = numMinutes.Tag
                numSeconds.Value = numSeconds.Tag
                numRepeat.Value = numRepeat.Tag

            Case OPERATION_REMINDER_TYPE_DAILY_CHECKED
                grpReminderTypeDaily.Visible = True
                For i As Integer = 0 To lvDaily.Items.Count - 1
                    lvDaily.SetItemCheckState(i, CheckState.Unchecked)
                Next
                dtDailyTime.Value = DateTime.Now
                numRepeat.Value = numRepeat.Tag

            Case OPERATION_REMINDER_TYPE_SPECIFIC_CHECKED
                grpReminderTypeSpecific.Visible = True
                dtSpecific.Value = DateTime.Now
                numRepeat.Value = numRepeat.Tag

            Case OPERATION_REMINDER_TYPE_INTERVAL_UNCHECKED
                grpReminderTypeInterval.Visible = False

            Case OPERATION_REMINDER_TYPE_DAILY_UNCHECKED
                grpReminderTypeDaily.Visible = False

            Case OPERATION_REMINDER_TYPE_SPECIFIC_UNCHECKED
                grpReminderTypeSpecific.Visible = False

        End Select

    End Sub

    Private Sub panelReminderTypeContent_EnabledChanged(sender As Object, e As EventArgs) Handles panelReminderTypeContent.EnabledChanged
        lblReminderTypeInterval.Visible = Not sender.Enabled
        lblReminderTypeDaily.Visible = Not sender.Enabled
        lblReminderTypeSpecific.Visible = Not sender.Enabled
    End Sub
End Class
