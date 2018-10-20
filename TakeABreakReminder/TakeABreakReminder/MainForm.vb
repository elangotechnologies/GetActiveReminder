Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports NLog

Public Class FrmMain
    ''Shared log As Logger = LogManager.GetCurrentClassLogger()

    Private gIsExitClicked As Boolean = False
    Private gReminderManager As ReminderManager = ReminderManager.getInstance()
    Private gSelectedReminderId As Integer = REMINDER_ID_NONE
    Public Const DEFAULT_WINDOW_STATE As FormWindowState = FormWindowState.Maximized
    Private gWindowState As FormWindowState = DEFAULT_WINDOW_STATE

    Private gIsRowAddEvent As Boolean = False

    Dim gButtonsIconsList As List(Of PictureBox)
    Dim gIconsPlaceHolderList As List(Of Label)

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
            FrmMain.btnStartStopReminder.Tag = REMINDER_STATUS_NOT_RUNNING
            FrmMain.ttIconTooltip.SetToolTip(FrmMain.btnStartStopReminder, "Start (Ctrl+R)")
        End Sub

        Private Sub remainingTimeChanged(remainingTimeStr As String) Implements ReminderManager.IReminderUpdateObserver.remainingTimeChanged
            FrmMain.lblReminderStatus.Text = remainingTimeStr
        End Sub
    End Class

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''gWindowState = Me.WindowState
        ''log.Debug("Environment.GetCommandLineArgs().Count: " + Environment.GetCommandLineArgs().Count.ToString)
        If Environment.GetCommandLineArgs().Count >= 2 Then
            log.Debug("Minimizing")
            Me.WindowState = FormWindowState.Minimized
        End If

        gButtonsIconsList = New List(Of PictureBox) From {btnAddReminder, btnEditReminder, btnStartStopReminder, btnDeleteReminder, btnClearScreen, btnCloneReminder}
        gIconsPlaceHolderList = New List(Of Label) From {lblIconPlace1, lblIconPlace2, lblIconPlace3, lblIconPlace4, lblIconPlace5, lblIconPlace6}

        addButtonAppearnceEventHandlers(gButtonsIconsList)

        gReminderManager.registerForRemainingTime(New ReminderUpdateObserver)
        loadNotificationDurationList()
        loadNotificationSoundList()
        setDataGrid(dgReminderDetails, gReminderManager.getReminderTable())
        setlblReminderTypes()

        radReminderTypeInterval.Tag = REMINDER_TYPE_INTERVAL
        radReminderTypeDaily.Tag = REMINDER_TYPE_DAILY
        radReminderTypeSpecific.Tag = REMINDER_TYPE_SPECIFIC_TIME
        numNotificationWidth.Maximum = Screen.PrimaryScreen.Bounds.Width
        numNotificationHeight.Maximum = Screen.PrimaryScreen.Bounds.Height

        setVisibilityByByOperation(OPERATION_SCREEN_LOADED)

        'this should be in last
        gReminderManager.startAllRunningStatusReminders()
    End Sub

    Private Sub setlblReminderTypes()
        lblReminderTypeInterval.Location = getRadioButtonLocation(radReminderTypeInterval)
        lblReminderTypeDaily.Location = getRadioButtonLocation(radReminderTypeDaily)
        lblReminderTypeSpecific.Location = getRadioButtonLocation(radReminderTypeSpecific)

        lblReminderTypeInterval.Text = radReminderTypeInterval.Text
        lblReminderTypeDaily.Text = radReminderTypeDaily.Text
        lblReminderTypeSpecific.Text = radReminderTypeSpecific.Text
    End Sub

    Private Function getRadioButtonLocation(radioButton As RadioButton) As Point
        Return New Point(grpReminderType.Location.X + panelReminderTypeContent.Location.X + radioButton.Location.X + 15, grpReminderType.Location.Y + panelReminderTypeContent.Location.Y + radioButton.Location.Y + 2)
    End Function

    Private Sub arrangeIcons()
        Dim buttonAppreanceDetails As ButtonAppearanceDetails
        Dim index As Integer = 0
        For Each button As PictureBox In gButtonsIconsList
            If button.Enabled = True Then
                button.Location = gIconsPlaceHolderList.Item(index).Location
                index += 1
                buttonAppreanceDetails = gButtonsMap(button)
                If buttonAppreanceDetails IsNot Nothing Then
                    button.Size = buttonAppreanceDetails.defaultSize
                End If
            End If
        Next
        For Each button As PictureBox In gButtonsIconsList
            If button.Enabled = False Then
                button.Location = gIconsPlaceHolderList.Item(index).Location
                index += 1
                buttonAppreanceDetails = gButtonsMap(button)
                If buttonAppreanceDetails IsNot Nothing Then
                    button.Size = buttonAppreanceDetails.defaultSize
                End If
            End If
        Next
    End Sub

    Private Sub loadNotificationDurationList()

        Dim notificaitonDurationList As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)

        For value As Integer = 1 To 12
            Dim seconds As Integer = value * 5
            notificaitonDurationList.Add(seconds, seconds.ToString + " Seconds")
        Next

        For value As Integer = 2 To 10
            Dim seconds As Integer = value * MINUTES_SECONDS_CONVERTER
            notificaitonDurationList.Add(seconds, value.ToString + " Minutes")
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

        If Not sender.Enabled Then
            Return
        End If

        If gSelectedReminderId = REMINDER_ID_NONE Then
            MsgBox("Please select a reminder to do this operation")
            dgReminderDetails.Focus()
            Return
        End If

        Dim reminderRow As DataRow = gReminderManager.getReminderRow(gSelectedReminderId)
        Dim reminderStatus As String = reminderRow(COL_REMINDER_STATUS)
        Dim reminderType As String = reminderRow.Item(COL_REMINDER_TYPE)
        Dim currentTime As DateTime = DateTime.Now
        If reminderType = REMINDER_TYPE_SPECIFIC_TIME AndAlso reminderRow(COL_REMINDER_SPECIFIC_TIME) <= currentTime Then
            MsgBox("Sorry, the time for this reminder has already passed. Please set a new time to start the reminder")
            dgReminderDetails.Focus()
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
        If My.Settings.minimize_on_close = False OrElse gIsExitClicked = True Then
            'do clean up required
        Else
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized
        End If


        'If gIsExitClicked = False Then
        '    setPropertiesForCustomDialog()
        '    Dim result As Integer = CustomDialog.showMyDialog("Reminder is Running, Confirm Your Action", "Continue and Minimize to Tray", "Abort Reminder and Exit", "Return to Application")
        '    If result = CustomDialog.OPTION_ONE Then
        '        Me.WindowState = FormWindowState.Minimized
        '        ShowInTaskbar = False
        '        trayIcon.Visible = True
        '    ElseIf result = CustomDialog.OPTION_TWO Then
        '        exitApp()
        '    ElseIf result = CustomDialog.OPTION_THREE Then
        '        e.Cancel = True
        '    End If
        'End If

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
        Me.WindowState = DEFAULT_WINDOW_STATE
    End Sub

    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If gWindowState <> Me.WindowState Then
            gWindowState = Me.WindowState
            If Me.WindowState = FormWindowState.Minimized Then
                trayIcon.Visible = True
                ShowInTaskbar = False
                If My.Settings.notify_on_minimize_to_tray = True Then
                    trayIcon.ShowBalloonTip(1, "RemindMe Application", "I'm running in background. You can launch me from system tray.", ToolTipIcon.Info)
                End If
            Else
                trayIcon.Visible = False
                ShowInTaskbar = True
            End If

        End If
    End Sub

    Private Sub trayIcon_BalloonTipClicked(sender As Object, e As EventArgs) Handles trayIcon.BalloonTipClicked
        showMainForm()
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
        ''reminderRow(COL_REMINDER_NEXT_NOTIFY_TIME) = DBNull.Value

        reminderRow(COL_REMINDER_STATUS) = REMINDER_STATUS_NOT_RUNNING
        reminderRow(COL_NOTIFICATION_DURATION) = cmbNotificationDuration.SelectedValue
        reminderRow(COL_NOTIFICATION_SOUND) = cmbNotificationSound.Text
        reminderRow(COL_NOTIFICATION_MESSAGE) = txtNotificationMessage.Text
        reminderRow(COL_NOTIFICATION_FONT) = txtNotificaitonFont.Text
        reminderRow(COL_NOTIFICATION_META_FONT) = txtNotificaitonMetaFont.Text
        reminderRow(COL_NOTIFICATION_BACKCOLOR) = colorPickerBackColor.Color.Name.ToString
        reminderRow(COL_NOTIFICATION_FORECOLOR) = colorPickerForeColor.Color.Name.ToString
        reminderRow(COL_NOTIFICATION_META_FORECOLOR) = colorPickerMetaForeColor.Color.Name.ToString
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
        txtNotificaitonMetaFont.Text = reminderRow(COL_NOTIFICATION_META_FONT)
        colorPickerBackColor.Color = Color.FromName(reminderRow(COL_NOTIFICATION_BACKCOLOR))
        colorPickerForeColor.Color = Color.FromName(reminderRow(COL_NOTIFICATION_FORECOLOR))
        colorPickerMetaForeColor.Color = Color.FromName(reminderRow(COL_NOTIFICATION_META_FORECOLOR))
        numNotificationWidth.Value = reminderRow(COL_NOTIFICATION_WIDTH)
        numNotificationHeight.Value = reminderRow(COL_NOTIFICATION_HEIGHT)

    End Sub

    Private Function validateReminderData() As Boolean
        Dim reminderType As String = getSelectedReminderType()

        Select Case reminderType
            Case REMINDER_TYPE_INTERVAL
                If convertTimeToSeconds(numHours.Value, numMinutes.Value, numSeconds.Value) < cmbNotificationDuration.SelectedValue Then
                    MsgBox("The reminder interval cannot be lesser than notification duration. Current values,  Reminder Interval : " + getFormattedInterval(numHours.Value, numMinutes.Value, numSeconds.Value) + ", Notification Duration: " + cmbNotificationDuration.Text)
                    numHours.Focus()
                    Return False
                End If
            Case REMINDER_TYPE_SPECIFIC_TIME
                If dtSpecific.Value <= DateTime.Now Then
                    MsgBox("The selected time is already crossed. Please select a new time")
                    dtSpecific.Focus()
                    Return False
                End If
            Case REMINDER_TYPE_DAILY
                If lvDaily.CheckedItems.Count <= 0 Then
                    MsgBox("Atleast one day must be selected")
                    lvDaily.Focus()
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
        ''onReminderSelected(e.RowIndex)
        If e.RowIndex = -1 Then
            Return
        End If

        If gSelectedReminderId <> dgReminderDetails.Item(COL_REMINDER_ID, e.RowIndex).Value Then
            onReminderSelected(e.RowIndex)
        End If
    End Sub

    Private Sub onReminderSelected(rowIndex As Integer)
        If rowIndex < 0 Then
            Return
        End If

        If btnAddReminder.Tag = OPERATION_ADD_COMPLETED Or btnEditReminder.Tag = OPERATION_EDIT_COMPLETED Then
            'we came here not by intentional.
            Return
        End If

        If btnAddReminder.Tag = OPERATION_ADD_STARTED Then
            MessageBox.Show("Sorry, you cannot view any existing reminders because you are in the middle of creating a new reminder. Please compelete the creation or cancel it", "ERROR")
            dgReminderDetails.ClearSelection()
            numRepeat.Focus()
            gSelectedReminderId = REMINDER_ID_NONE
            Return
        End If

        If btnEditReminder.Tag = OPERATION_EDIT_STARTED Then
            MessageBox.Show("Sorry, you cannot view any existing reminders because you are in the middle of editing an exisiting reminder. Please compelete the edit operation or cancel it", "ERROR")
            selectRowAtDataGridByKey(dgReminderDetails, COL_REMINDER_ID, gSelectedReminderId)
            numRepeat.Focus()
            Return
        End If

        gSelectedReminderId = dgReminderDetails.Item(COL_REMINDER_ID, rowIndex).Value
        setVisibilityByByOperation(OPERATION_REMINDER_SELECTED)
        updateScreenFromReminderRow()
    End Sub


    Private Sub btnDeleteReminder_Click(sender As Object, e As EventArgs) Handles btnDeleteReminder.Click

        If Not sender.Enabled Then
            Return
        End If

        If gSelectedReminderId = REMINDER_ID_NONE Then
            MsgBox("Please select a reminder to do this operation")
            dgReminderDetails.Focus()
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

        If My.Settings.confirm_before_delete = False OrElse
                (My.Settings.confirm_before_delete = True And
                MessageBox.Show("Do you really want to delete this reminder?", "CONFIRMATION",
                                System.Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            gReminderManager.commitDeletedReminderRow(reminderRow)
            gSelectedReminderId = REMINDER_ID_NONE
            setVisibilityByByOperation(OPERATION_DELETE_COMPLETED)
            lblReminderStatus.Text = "Reminder with id " + reminderId.ToString + " is deleted successfully"
        End If

    End Sub

    Private Sub btnClearScreen_Click(sender As Object, e As EventArgs) Handles btnClearScreen.Click

        If btnAddReminder.Tag = OPERATION_ADD_STARTED Then
            setVisibilityByByOperation(OPERATION_ADD_CANCELED)
        ElseIf btnEditReminder.Tag = OPERATION_EDIT_STARTED Then
            setVisibilityByByOperation(OPERATION_EDIT_CANCELED, gSelectedReminderId)
        Else
            setVisibilityByByOperation(OPERATION_SCREEN_CLEARED)
        End If

    End Sub

    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control Then
            Select Case (e.KeyCode)
                Case Keys.N
                    If btnAddReminder.Tag <> OPERATION_ADD_STARTED Then
                        btnAddReminder_Click(btnAddReminder, New EventArgs)
                    End If
                Case Keys.E
                    If btnEditReminder.Tag <> OPERATION_EDIT_STARTED Then
                        btnEditReminder_Click(btnEditReminder, New EventArgs)
                    End If
                Case Keys.D
                    btnDeleteReminder_Click(btnDeleteReminder, New EventArgs)
                Case Keys.R
                    If btnStartStopReminder.Tag = REMINDER_STATUS_NOT_RUNNING Then
                        btnStartStopReminder_Click(btnStartStopReminder, New EventArgs)
                    End If
                Case Keys.Z
                    If btnStartStopReminder.Tag = REMINDER_STATUS_RUNNING Then
                        btnStartStopReminder_Click(btnStartStopReminder, New EventArgs)
                    End If
                    ''Case Keys.C
                    ''btnClearScreen_Click(btnClearScreen, New EventArgs)
                Case Keys.L
                    btnCloneReminder_Click(btnCloneReminder, New EventArgs)
                Case Keys.T
                    dgReminderDetails.Focus()
            End Select
        End If

        If e.KeyCode = Keys.Enter Then
            If btnAddReminder.Tag = OPERATION_ADD_STARTED Then
                btnAddReminder_Click(btnAddReminder, New EventArgs)
            ElseIf btnEditReminder.Tag = OPERATION_EDIT_STARTED Then
                btnEditReminder_Click(btnEditReminder, New EventArgs)
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            ''If btnAddReminder.Tag = OPERATION_ADD_STARTED OrElse btnEditReminder.Tag = OPERATION_EDIT_STARTED Then
            btnClearScreen_Click(btnClearScreen, New EventArgs)
            ''End If
        End If

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

        If Not sender.Enabled Then
            Return
        End If

        Dim creationStatus As Integer = btnAddReminder.Tag
        If creationStatus = OPERATION_NONE Then
            setVisibilityByByOperation(OPERATION_ADD_STARTED)
        ElseIf creationStatus = OPERATION_ADD_STARTED Then

            If validateReminderData() = False Then
                Return
            End If

            btnAddReminder.Tag = OPERATION_ADD_COMPLETED

            Dim newReminderRow As DataRow = gReminderManager.createNewReminderRow()
            gReminderManager.commitNewReminderRow(fillReminderRowFromScreen(newReminderRow))
            Dim reminderId As Integer = newReminderRow.Item(COL_REMINDER_ID)

            setVisibilityByByOperation(OPERATION_ADD_COMPLETED, reminderId)
            lblReminderStatus.Text = "Reminder with id " + reminderId.ToString + " is added successfully"
            ''dgReminderDetails.Sort(dgReminderDetails.Columns(COL_REMINDER_ID), ListSortDirection.Descending)

        End If

    End Sub

    Private Sub btnEditReminder_Click(sender As Object, e As EventArgs) Handles btnEditReminder.Click

        If Not sender.Enabled Then
            Return
        End If

        If gSelectedReminderId = REMINDER_ID_NONE Then
            MsgBox("Please select a reminder to do this operation")
            dgReminderDetails.Focus()
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

            btnEditReminder.Tag = OPERATION_EDIT_COMPLETED

            Dim reminderRow As DataRow = gReminderManager.getReminderRow(gSelectedReminderId)

            fillReminderRowFromScreen(reminderRow, False)
            gReminderManager.commitUpdatedReminderRow(reminderRow)

            setVisibilityByByOperation(OPERATION_EDIT_COMPLETED, gSelectedReminderId)
            lblReminderStatus.Text = "Reminder with id " + gSelectedReminderId.ToString + " is updated successfully"
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

    Private Sub btnCloneReminder_EnabledChanged(sender As Object, e As EventArgs) Handles btnCloneReminder.EnabledChanged
        sender.BackgroundImage = If(sender.enabled, My.Resources.clone, My.Resources.clone_disabled)
    End Sub

    Private Sub resetScreen()
        cmbNotificationDuration.SelectedIndex = 0
        cmbNotificationSound.SelectedIndex = 0
        txtNotificationMessage.Text = txtNotificationMessage.Tag.ToString
        txtNotificaitonFont.Text = txtNotificaitonFont.Tag.ToString
        txtNotificaitonMetaFont.Text = txtNotificaitonMetaFont.Tag.ToString
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

    Private Sub setVisibilityByByOperation(operation As Integer, Optional reminderId As Integer = REMINDER_ID_NONE)
        Select Case operation
            Case OPERATION_NONE
                ''Nothing
            Case OPERATION_SCREEN_LOADED
                setVisibilityByByOperation(OPERATION_SCREEN_CLEARED)

                grpReminderTypeInterval.Location = reminderTimePlaceHolder.Location
                grpReminderTypeDaily.Location = reminderTimePlaceHolder.Location
                grpReminderTypeSpecific.Location = reminderTimePlaceHolder.Location
                btnAddReminder.Tag = OPERATION_NONE
                btnAddReminder.BackgroundImage = My.Resources._new
                ttIconTooltip.SetToolTip(btnAddReminder, "New (Ctrl+N)")
                btnEditReminder.Tag = OPERATION_NONE
                btnClearScreen.BackgroundImage = My.Resources.clear

                selectFirstRowAtDataGrid(dgReminderDetails)

            Case OPERATION_SCREEN_CLEARED
                dgReminderDetails.ClearSelection()
                gSelectedReminderId = REMINDER_ID_NONE

                panelReminderType.Visible = False
                panelReminderTimeConfig.Visible = False
                panelNotificationSettings.Visible = False
                btnEditReminder.Enabled = False
                btnDeleteReminder.Enabled = False
                btnCloneReminder.Enabled = False
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
                txtNotificaitonMetaFont.Text = txtNotificaitonMetaFont.Tag.ToString
                colorPickerBackColor.Color = Color.FromName(colorPickerBackColor.Tag)
                colorPickerForeColor.Color = Color.FromName(colorPickerForeColor.Tag)
                numNotificationWidth.Value = numNotificationWidth.Tag
                numNotificationHeight.Value = numNotificationHeight.Tag

            Case OPERATION_ADD_STARTED
                btnEditReminder.Enabled = False
                btnDeleteReminder.Enabled = False
                btnCloneReminder.Enabled = False
                btnStartStopReminder.Enabled = False
                btnAddReminder.Tag = operation
                btnAddReminder.BackgroundImage = My.Resources.confirm
                ttIconTooltip.SetToolTip(btnAddReminder, "Confirm (Enter)")
                btnClearScreen.BackgroundImage = My.Resources.cancel
                ttIconTooltip.SetToolTip(btnClearScreen, "Cancel (Esc)")

                setVisibilityByByOperation(OPERATION_SCREEN_VALUES_RESET)

                panelReminderType.Visible = True
                panelReminderTimeConfig.Visible = True
                panelNotificationSettings.Visible = True

                panelReminderTypeContent.Enabled = True
                panelReminderTypeIntervalContent.Enabled = True
                panelReminderTypeDailyContent.Enabled = True
                panelReminderTypeSpecificContent.Enabled = True
                panelNotificationSettingsContent.Enabled = True
                panelRepeatContent.Enabled = True

                radReminderTypeInterval.Checked = True

            Case OPERATION_ADD_COMPLETED
                btnAddReminder.Tag = OPERATION_NONE
                btnAddReminder.BackgroundImage = My.Resources._new
                ttIconTooltip.SetToolTip(btnAddReminder, "New (Ctrl+N)")
                btnClearScreen.BackgroundImage = My.Resources.clear
                ttIconTooltip.SetToolTip(btnClearScreen, "Clear (Esc)")

                dgReminderDetails.Sort(dgReminderDetails.Columns(COL_REMINDER_ID), ListSortDirection.Descending)
                dgReminderDetails.FirstDisplayedScrollingRowIndex = 0
                selectRowAtDataGridByKey(dgReminderDetails, COL_REMINDER_ID, reminderId)

            Case OPERATION_CLONE_COMPLETED
                selectRowAtDataGridByKey(dgReminderDetails, COL_REMINDER_ID, reminderId)


            Case OPERATION_ADD_CANCELED
                btnAddReminder.Tag = OPERATION_NONE
                btnAddReminder.BackgroundImage = My.Resources._new
                ttIconTooltip.SetToolTip(btnAddReminder, "New (Ctrl+N)")
                btnClearScreen.BackgroundImage = My.Resources.clear
                ttIconTooltip.SetToolTip(btnClearScreen, "Clear (Esc)")

                selectFirstRowAtDataGrid(dgReminderDetails)


            Case OPERATION_EDIT_STARTED
                btnAddReminder.Enabled = False
                btnDeleteReminder.Enabled = False
                btnCloneReminder.Enabled = False
                btnStartStopReminder.Enabled = False

                btnEditReminder.Tag = operation
                btnEditReminder.BackgroundImage = My.Resources.confirm
                ttIconTooltip.SetToolTip(btnEditReminder, "Confirm (Enter)")
                btnClearScreen.BackgroundImage = My.Resources.cancel ''make sure that you dont clear screen here. We just need to reload the reminder row.
                ttIconTooltip.SetToolTip(btnClearScreen, "Cancel (Esc)")

                panelReminderTypeContent.Enabled = True
                panelReminderTypeIntervalContent.Enabled = True
                panelReminderTypeDailyContent.Enabled = True
                panelReminderTypeSpecificContent.Enabled = True
                panelNotificationSettingsContent.Enabled = True
                panelRepeatContent.Enabled = True

                If radReminderTypeInterval.Checked Then
                    numHours.Focus()
                ElseIf radReminderTypeDaily.Checked Then
                    lvDaily.Focus()
                ElseIf radReminderTypeSpecific.Checked Then
                    dtSpecific.Focus()
                End If

            Case OPERATION_EDIT_COMPLETED
                btnAddReminder.Enabled = True

                btnEditReminder.Tag = OPERATION_NONE
                btnEditReminder.BackgroundImage = My.Resources.edit
                ttIconTooltip.SetToolTip(btnEditReminder, "Edit (Ctrl+E)")
                btnClearScreen.BackgroundImage = My.Resources.clear
                ttIconTooltip.SetToolTip(btnClearScreen, "Clear (Esc)")

                dgReminderDetails.Sort(dgReminderDetails.Columns(COL_REMINDER_UPDATED_TIME), ListSortDirection.Descending)
                dgReminderDetails.FirstDisplayedScrollingRowIndex = 0
                selectRowAtDataGridByKey(dgReminderDetails, COL_REMINDER_ID, reminderId)

            Case OPERATION_EDIT_CANCELED
                btnAddReminder.Enabled = True
                btnEditReminder.Tag = OPERATION_NONE
                btnEditReminder.BackgroundImage = My.Resources.edit
                ttIconTooltip.SetToolTip(btnEditReminder, "Edit (Ctrl+E)")
                btnClearScreen.BackgroundImage = My.Resources.clear
                ttIconTooltip.SetToolTip(btnClearScreen, "Clear (Esc)")

                selectRowAtDataGridByKey(dgReminderDetails, COL_REMINDER_ID, reminderId)


            Case OPERATION_DELETE_COMPLETED

                If gReminderManager.getReminderTable.Rows.Count = 0 Then
                    setVisibilityByByOperation(OPERATION_SCREEN_CLEARED)
                Else
                    selectFirstRowAtDataGrid(dgReminderDetails)

                End If

            Case OPERATION_REMINDER_STARTED
                btnEditReminder.Enabled = False
                btnDeleteReminder.Enabled = False
                btnCloneReminder.Enabled = False
                btnStartStopReminder.BackgroundImage = My.Resources._stop
                ttIconTooltip.SetToolTip(btnStartStopReminder, "Stop (Ctrl+Z)")
                btnStartStopReminder.Tag = REMINDER_STATUS_RUNNING

            Case OPERATION_REMINDER_STOPPED
                btnEditReminder.Enabled = True
                btnDeleteReminder.Enabled = True
                btnCloneReminder.Enabled = True
                btnStartStopReminder.BackgroundImage = My.Resources.start
                ttIconTooltip.SetToolTip(btnStartStopReminder, "Start (Ctrl+R)")
                btnStartStopReminder.Tag = REMINDER_STATUS_NOT_RUNNING

            Case OPERATION_REMINDER_SELECTED
                btnEditReminder.Enabled = True
                btnStartStopReminder.Enabled = True
                btnDeleteReminder.Enabled = True
                btnCloneReminder.Enabled = True

                Dim reminderRow As DataRow = gReminderManager.getReminderRow(gSelectedReminderId)
                Dim reminderStatus As String = reminderRow(COL_REMINDER_STATUS)
                If reminderStatus = REMINDER_STATUS_RUNNING Then
                    btnEditReminder.Enabled = False
                    btnDeleteReminder.Enabled = False
                    btnCloneReminder.Enabled = False
                    btnStartStopReminder.BackgroundImage = My.Resources._stop
                    ttIconTooltip.SetToolTip(btnStartStopReminder, "Stop (Ctrl+Z)")
                Else
                    btnStartStopReminder.BackgroundImage = My.Resources.start
                    ttIconTooltip.SetToolTip(btnStartStopReminder, "Start (Ctrl+R)")
                End If
                btnStartStopReminder.Tag = reminderStatus

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

                dgReminderDetails.Focus()

            Case OPERATION_REMINDER_TYPE_INTERVAL_CHECKED
                grpReminderTypeInterval.Visible = True
                numHours.Value = numHours.Tag
                numMinutes.Value = numMinutes.Tag
                numSeconds.Value = numSeconds.Tag
                numRepeat.Value = numRepeat.Tag
                numRepeat.Enabled = True
                numHours.Focus()

            Case OPERATION_REMINDER_TYPE_DAILY_CHECKED
                grpReminderTypeDaily.Visible = True
                For i As Integer = 0 To lvDaily.Items.Count - 1
                    lvDaily.SetItemCheckState(i, CheckState.Unchecked)
                Next
                dtDailyTime.Value = DateTime.Now
                numRepeat.Value = numRepeat.Tag
                numRepeat.Enabled = True
                lvDaily.Focus()
            Case OPERATION_REMINDER_TYPE_SPECIFIC_CHECKED
                grpReminderTypeSpecific.Visible = True
                dtSpecific.Value = DateTime.Now
                numRepeat.Value = numRepeat.Tag
                numRepeat.Enabled = False
                dtSpecific.Focus()
            Case OPERATION_REMINDER_TYPE_INTERVAL_UNCHECKED
                grpReminderTypeInterval.Visible = False

            Case OPERATION_REMINDER_TYPE_DAILY_UNCHECKED
                grpReminderTypeDaily.Visible = False

            Case OPERATION_REMINDER_TYPE_SPECIFIC_UNCHECKED
                grpReminderTypeSpecific.Visible = False
        End Select

        arrangeIcons()
    End Sub

    Private Sub selectRowAtDataGridByKey(lDataGridView As DataGridView, lDBkeyColumn As String, lKeyValue As Integer)
        Dim lDataBindingSource As BindingSource = lDataGridView.DataSource
        Dim lDataTableFromBinding As DataTable = lDataBindingSource.DataSource

        If lDataTableFromBinding.Rows.Count > 0 Then
            Dim rowPosition As Integer = lDataBindingSource.Find(lDataTableFromBinding.Columns(lDBkeyColumn).ToString, lKeyValue.ToString)
            lDataGridView.DataSource.Position = rowPosition
            ''lDataBindingSource.ResetBindings(False)
            onReminderSelected(rowPosition)
        End If

    End Sub


    Private Sub selectFirstRowAtDataGrid(lDataGridView As DataGridView)
        ''lDataGridView.Focus()
        Dim lDataBindingSource As BindingSource = lDataGridView.DataSource
        Dim lDataTableFromBinding As DataTable = lDataBindingSource.DataSource

        If lDataTableFromBinding.Rows.Count > 0 Then
            Dim reminderRow As DataRow = lDataTableFromBinding.Rows(0)
            lDataGridView.DataSource.Position = 0
            lDataBindingSource.ResetBindings(False)
            onReminderSelected(0)
        End If

    End Sub

    Private Sub panelReminderTypeContent_EnabledChanged(sender As Object, e As EventArgs) Handles panelReminderTypeContent.EnabledChanged
        lblReminderTypeInterval.Visible = Not sender.Enabled
        lblReminderTypeDaily.Visible = Not sender.Enabled
        lblReminderTypeSpecific.Visible = Not sender.Enabled
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        exitApp()
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub ReminderHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReminderHistoryToolStripMenuItem.Click
        RemindersHistory.ShowDialog()
    End Sub

    Private Sub ClearHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearHistoryToolStripMenuItem.Click
        gReminderManager.resetSavedReminderDB(STORAGE_REMINDER_HISTORY_OPERATION)
        lblReminderStatus.Text = "History is completely cleared."
    End Sub

    Private Sub btnCloneReminder_Click(sender As Object, e As EventArgs) Handles btnCloneReminder.Click

        Dim reminderRow As DataRow = gReminderManager.getReminderRow(gSelectedReminderId)
        Dim reminderId As Integer = gSelectedReminderId
        Dim clonedReminderRow As DataRow = gReminderManager.cloneReminderRow(reminderRow, gReminderManager.getReminderTable().NewRow())
        clonedReminderRow(COL_REMINDER_STATUS) = REMINDER_STATUS_NOT_RUNNING
        clonedReminderRow(COL_REMINDER_CREATED_TIME) = DateTime.Now
        clonedReminderRow(COL_REMINDER_UPDATED_TIME) = DBNull.Value
        clonedReminderRow(COL_REMINDER_STARTED_TIME) = DBNull.Value
        clonedReminderRow(COL_REMINDER_NOTIFIED_TIME) = DBNull.Value
        clonedReminderRow(COL_REMINDER_NEXT_NOTIFY_TIME) = DBNull.Value
        clonedReminderRow(COL_REMINDER_REPEAT_ELAPSED) = 0

        gReminderManager.commitNewReminderRow(clonedReminderRow)
        Dim clonedReminderId As Integer = clonedReminderRow.Item(COL_REMINDER_ID)

        setVisibilityByByOperation(OPERATION_CLONE_COMPLETED, clonedReminderId)
        lblReminderStatus.Text = "Reminder with id " + reminderId.ToString + " is cloned to " + clonedReminderId.ToString + " successfully"
    End Sub

    Private Sub dgReminderDetails_SelectionChanged(sender As Object, e As EventArgs) Handles dgReminderDetails.SelectionChanged
        If dgReminderDetails.CurrentRow Is Nothing Then
            Return
        End If
        If gIsRowAddEvent = False AndAlso gSelectedReminderId <> dgReminderDetails.Item(COL_REMINDER_ID, dgReminderDetails.CurrentRow.Index).Value Then
            onReminderSelected(dgReminderDetails.CurrentRow.Index)
        End If
        gIsRowAddEvent = False

    End Sub

    Private Sub dgReminderDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles dgReminderDetails.KeyDown
        gIsRowAddEvent = False
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dgReminderDetails_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgReminderDetails.RowsAdded
        gIsRowAddEvent = True
    End Sub

    Private Sub ShortcutsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShortcutsToolStripMenuItem.Click
        Shortcuts.ShowDialog()
    End Sub

    Private ReadOnly REMINDER_STATUSBAR_COLOR_1 As Color = Color.DodgerBlue
    Private ReadOnly REMINDER_STATUSBAR_COLOR_2 As Color = Color.SteelBlue
    Private Sub lblReminderStatus_TextChanged(sender As Object, e As EventArgs) Handles lblReminderStatus.TextChanged
        ssReminderStatusBar.BackColor = If(ssReminderStatusBar.BackColor = REMINDER_STATUSBAR_COLOR_1, REMINDER_STATUSBAR_COLOR_2, REMINDER_STATUSBAR_COLOR_1)
    End Sub

    Private Sub btnShowNotificationMetaFontDialog_Click(sender As Object, e As EventArgs) Handles btnShowNotificationMetaFontDialog.Click
        If Not String.IsNullOrEmpty(txtNotificaitonMetaFont.Text) Then
            fontdialogNotificationFont.Font = getFontObjFromDisplayFormat(txtNotificaitonMetaFont.Text)
        End If

        If fontdialogNotificationFont.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtNotificaitonMetaFont.Text = getFontInDisplayFormat(fontdialogNotificationFont.Font)
        End If
    End Sub
End Class

