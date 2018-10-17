Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports NLog

Public NotInheritable Class ReminderManager
    Shared log As Logger = LogManager.GetCurrentClassLogger()
    Private gReminderTable As DataTable = Nothing
    Private gReminderHistoryTable As DataTable = Nothing
    Private gRunnningRemindersMap As New Dictionary(Of Integer, RunningReminder)

    Private gReminderTimer As New Timer
    Private gRemainingTimeToNotificationTimer As New Timer
    Private gReminderUpdateObserver As IReminderUpdateObserver

    Private Shared classLocker As New Object()
    Private Shared objSingleton As ReminderManager

    Private Sub New()
        '' cleanSavedReminderTable()

        gReminderTimer.Interval = 1 * SECONDS_MILLISECONDS_CONVERTER
        AddHandler gReminderTimer.Tick, AddressOf reminderTimer_tick

        gRemainingTimeToNotificationTimer.Interval = 1 * SECONDS_MILLISECONDS_CONVERTER
        AddHandler gRemainingTimeToNotificationTimer.Tick, AddressOf remainingTimeToNotificationTimer_tick

        loadReminders()

    End Sub

    Public Shared Function getInstance() As ReminderManager
        If (objSingleton Is Nothing) Then
            SyncLock (classLocker)
                If (objSingleton Is Nothing) Then
                    objSingleton = New ReminderManager()
                End If
            End SyncLock
        End If
        Return objSingleton
    End Function

    Private Class RunningReminder
        Public reminderRow As DataRow
        Public toastNotificationForm As ReminderNotification

        Public Sub New(reminderRow As DataRow, toastNotificationForm As ReminderNotification)
            Me.reminderRow = reminderRow
            Me.toastNotificationForm = toastNotificationForm
        End Sub
    End Class

    Public Interface IReminderUpdateObserver
        Sub remainingTimeChanged(remainingTimeStr As String)
        Sub reminderStopped()
    End Interface

    Public Function getReminderTable() As DataTable
        Return gReminderTable
    End Function

    Public Function getReminderHistoryTable() As DataTable
        If gReminderHistoryTable Is Nothing Then
            loadRemindersHistory()
        End If

        Return gReminderHistoryTable
    End Function

    Public Sub registerForRemainingTime(reminderUpdateObserver As IReminderUpdateObserver)
        gReminderUpdateObserver = reminderUpdateObserver
    End Sub


    Private Sub saveDataInPermenantStorage(dataTable As DataTable, Optional operationType As Integer = STORAGE_REMINDER_OPERATION)
        Dim dbPath As String = ""
        If operationType = STORAGE_REMINDER_OPERATION Then
            dbPath = getRemindersDBPath()
        ElseIf operationType = STORAGE_REMINDER_HISTORY_OPERATION Then
            dbPath = getRemindersHistoryDBPath()
        End If

        Dim fileWriter As New FileStream(dbPath, FileMode.Create, FileAccess.Write, FileShare.None)
        Dim binaryFormatter As New BinaryFormatter

        Try
            binaryFormatter.Serialize(fileWriter, dataTable)
        Catch ex As SerializationException
            Console.WriteLine("saveDataInPermenantStorage: Serialization failed. Reason: " & ex.Message)
        Catch ex As TargetInvocationException
            Dim iEX = ex.InnerException
            MsgBox(iEX.Message)
        Finally
            fileWriter.Close()
        End Try

    End Sub

    Public Sub resetSavedReminderDB(Optional operationType As Integer = STORAGE_REMINDER_OPERATION)

        Dim dbPath As String = ""
        If operationType = STORAGE_REMINDER_OPERATION Then
            dbPath = getRemindersDBPath()
            gReminderTable.Rows.Clear()
        ElseIf operationType = STORAGE_REMINDER_HISTORY_OPERATION Then
            dbPath = getRemindersHistoryDBPath()
            getReminderHistoryTable().Rows.Clear()
        End If

        Dim fileWriter As FileStream = File.Create(dbPath)
        fileWriter.Close()
    End Sub

    Private Function getRemindersDBPath() As String
        Return Application.CommonAppDataPath + "\Reminders.dat"
    End Function

    Private Function getRemindersHistoryDBPath() As String
        Return Application.CommonAppDataPath + "\RemindersHistory.dat"
    End Function

    Private Sub loadReminders()
        Dim fileReader As New FileStream(getRemindersDBPath(), FileMode.OpenOrCreate, FileAccess.Read)
        Dim binaryFormatter As New BinaryFormatter
        gReminderTable = New DataTable
        gReminderTable.Columns.AddRange(New DataColumn(21) _
                {New DataColumn(COL_REMINDER_ID, GetType(Integer)),
                New DataColumn(COL_REMINDER_TYPE, GetType(String)),
                New DataColumn(COL_REMINDER_REPEAT_MAX, GetType(Integer)),
                New DataColumn(COL_REMINDER_REPEAT_ELAPSED, GetType(Integer)),
                New DataColumn(COL_REMINDER_STATUS, GetType(String)),
                New DataColumn(COL_REMINDER_INTERVAL, GetType(String)),
                New DataColumn(COL_REMINDER_DAILY, GetType(String)),
                New DataColumn(COL_REMINDER_SPECIFIC_TIME, GetType(DateTime)),
                New DataColumn(COL_REMINDER_CREATED_TIME, GetType(DateTime)),
                New DataColumn(COL_REMINDER_UPDATED_TIME, GetType(DateTime)),
                New DataColumn(COL_REMINDER_DELETED_TIME, GetType(DateTime)),
                New DataColumn(COL_REMINDER_STARTED_TIME, GetType(DateTime)),
                New DataColumn(COL_REMINDER_NOTIFIED_TIME, GetType(DateTime)),
                New DataColumn(COL_REMINDER_NEXT_NOTIFY_TIME, GetType(DateTime)),
                New DataColumn(COL_NOTIFICATION_DURATION, GetType(Integer)),
                New DataColumn(COL_NOTIFICATION_SOUND, GetType(String)),
                New DataColumn(COL_NOTIFICATION_MESSAGE, GetType(String)),
                New DataColumn(COL_NOTIFICATION_FONT, GetType(String)),
                New DataColumn(COL_NOTIFICATION_BACKCOLOR, GetType(String)),
                New DataColumn(COL_NOTIFICATION_FORECOLOR, GetType(String)),
                New DataColumn(COL_NOTIFICATION_WIDTH, GetType(Integer)),
                New DataColumn(COL_NOTIFICATION_HEIGHT, GetType(Integer))})
        'gReminderTable.Columns(COL_REMINDER_ID).Unique = True
        'gReminderTable.Columns(COL_REMINDER_ID).ReadOnly = True
        'gReminderTable.Columns(COL_REMINDER_ID).AutoIncrement = True
        'gReminderTable.Columns(COL_REMINDER_ID).AutoIncrementSeed = 1
        'gReminderTable.Columns(COL_REMINDER_ID).AutoIncrementStep = 1


        Try
            gReminderTable = DirectCast(binaryFormatter.Deserialize(fileReader), DataTable)
        Catch ex As SerializationException
            Console.WriteLine("loadReminders: DeSerialization failed. Reason: " & ex.Message)
        Catch ex As TargetInvocationException
            Dim iEX = ex.InnerException
            MsgBox("TargetInvocationException catched: " + iEX.Message)
        Finally
            fileReader.Close()
        End Try

    End Sub

    Private Sub loadRemindersHistory()
        Dim fileReader As New FileStream(getRemindersHistoryDBPath(), FileMode.OpenOrCreate, FileAccess.Read)
        Dim binaryFormatter As New BinaryFormatter
        gReminderHistoryTable = gReminderTable.Clone

        Try
            gReminderHistoryTable = DirectCast(binaryFormatter.Deserialize(fileReader), DataTable)
        Catch ex As SerializationException
            Console.WriteLine("loadRemindersHistory: DeSerialization failed. Reason: " & ex.Message)
        Catch ex As TargetInvocationException
            Dim iEX = ex.InnerException
            MsgBox("TargetInvocationException catched: " + iEX.Message)
        Finally
            fileReader.Close()
        End Try

    End Sub

    Public Sub startAllRunningStatusReminders()

        For Each reminderRow As DataRow In gReminderTable.Rows
            Dim reminderStatus As String = reminderRow(COL_REMINDER_STATUS)
            If reminderStatus = REMINDER_STATUS_RUNNING Then
                Dim reminderId As Integer = reminderRow.Item(COL_REMINDER_ID)
                startReminder(reminderId)
            End If
        Next

    End Sub

    Public Sub stopRemindersToExit()

        gReminderTimer.Stop()
        gRemainingTimeToNotificationTimer.Stop()

        For Each runningReminderItem As KeyValuePair(Of Integer, RunningReminder) In gRunnningRemindersMap
            Dim runningReminder As RunningReminder = runningReminderItem.Value
            Dim toastNotificationForm As ReminderNotification = runningReminder.toastNotificationForm
            toastNotificationForm.Close()
        Next

    End Sub

    Public Function createNewReminderRow() As DataRow
        Return gReminderTable.NewRow()
    End Function

    Public Sub commitNewReminderRow(reminderRow As DataRow)
        My.Settings.last_reminder_id += 1
        My.Settings.Save()
        reminderRow(COL_REMINDER_ID) = My.Settings.last_reminder_id
        gReminderTable.Rows.Add(reminderRow)
        saveDataInPermenantStorage(gReminderTable)
        commitNewReminderHistoryRow(reminderRow)
    End Sub

    Public Sub commitNewReminderHistoryRow(ByVal reminderRow As DataRow)
        Try
            Dim remindersHistoryTable As DataTable = getReminderHistoryTable()
            Dim reminderRowClone As DataRow = cloneReminderRow(reminderRow, remindersHistoryTable.NewRow())
            remindersHistoryTable.Rows.InsertAt(reminderRowClone, 0)
            saveDataInPermenantStorage(remindersHistoryTable, STORAGE_REMINDER_HISTORY_OPERATION)
        Catch ex As Exception
            Console.WriteLine("commitNewReminderHistoryRow:  error = " + ex.Message)
        End Try

    End Sub

    Public Sub commitUpdatedReminderRow(reminderRow As DataRow)
        saveDataInPermenantStorage(gReminderTable)
        commitUpdatedReminderHistoryRow(reminderRow)
    End Sub

    Public Sub commitUpdatedReminderHistoryRow(ByVal reminderRow As DataRow)
        Dim remindersHistoryTable As DataTable = getReminderHistoryTable()
        Dim reminderId As Integer = reminderRow(COL_REMINDER_ID)
        Dim reminderHistoryRow As DataRow = getReminderHistoryRow(reminderId)

        If reminderHistoryRow IsNot Nothing Then
            remindersHistoryTable.Rows.Remove(reminderHistoryRow)
        End If

        commitNewReminderHistoryRow(reminderRow)

    End Sub

    Public Sub commitDeletedReminderRow(ByVal reminderRow As DataRow)
        Dim reminderRowClone As DataRow = cloneReminderRow(reminderRow, getReminderHistoryTable.NewRow())

        gReminderTable.Rows.Remove(reminderRow)
        saveDataInPermenantStorage(gReminderTable)

        commitDeletedReminderHistoryRow(reminderRowClone)
    End Sub

    Public Sub commitDeletedReminderHistoryRow(reminderRowClone As DataRow)
        Dim remindersHistoryTable As DataTable = getReminderHistoryTable()
        Dim reminderId As Integer = reminderRowClone(COL_REMINDER_ID)
        Dim reminderHistoryRow As DataRow = getReminderHistoryRow(reminderId)

        If reminderHistoryRow IsNot Nothing Then
            remindersHistoryTable.Rows.Remove(reminderHistoryRow)
        End If

        reminderRowClone(COL_REMINDER_DELETED_TIME) = DateTime.Now
        remindersHistoryTable.Rows.InsertAt(reminderRowClone, 0)
        saveDataInPermenantStorage(remindersHistoryTable, STORAGE_REMINDER_HISTORY_OPERATION)
    End Sub

    Public Function cloneReminderRow(ByVal reminderRow As DataRow, reminderRowClone As DataRow) As DataRow
        reminderRowClone(COL_REMINDER_ID) = reminderRow(COL_REMINDER_ID)
        reminderRowClone(COL_REMINDER_TYPE) = reminderRow(COL_REMINDER_TYPE)
        reminderRowClone(COL_REMINDER_REPEAT_MAX) = reminderRow(COL_REMINDER_REPEAT_MAX)
        reminderRowClone(COL_REMINDER_REPEAT_ELAPSED) = reminderRow(COL_REMINDER_REPEAT_ELAPSED)
        reminderRowClone(COL_REMINDER_STATUS) = reminderRow(COL_REMINDER_STATUS)
        reminderRowClone(COL_REMINDER_INTERVAL) = reminderRow(COL_REMINDER_INTERVAL)
        reminderRowClone(COL_REMINDER_DAILY) = reminderRow(COL_REMINDER_DAILY)
        reminderRowClone(COL_REMINDER_SPECIFIC_TIME) = reminderRow(COL_REMINDER_SPECIFIC_TIME)
        reminderRowClone(COL_REMINDER_CREATED_TIME) = reminderRow(COL_REMINDER_CREATED_TIME)
        reminderRowClone(COL_REMINDER_UPDATED_TIME) = reminderRow(COL_REMINDER_UPDATED_TIME)
        reminderRowClone(COL_REMINDER_STARTED_TIME) = reminderRow(COL_REMINDER_STARTED_TIME)
        reminderRowClone(COL_REMINDER_NOTIFIED_TIME) = reminderRow(COL_REMINDER_NOTIFIED_TIME)
        reminderRowClone(COL_REMINDER_NEXT_NOTIFY_TIME) = reminderRow(COL_REMINDER_NEXT_NOTIFY_TIME)
        reminderRowClone(COL_NOTIFICATION_DURATION) = reminderRow(COL_NOTIFICATION_DURATION)
        reminderRowClone(COL_NOTIFICATION_SOUND) = reminderRow(COL_NOTIFICATION_SOUND)
        reminderRowClone(COL_NOTIFICATION_MESSAGE) = reminderRow(COL_NOTIFICATION_MESSAGE)
        reminderRowClone(COL_NOTIFICATION_FONT) = reminderRow(COL_NOTIFICATION_FONT)
        reminderRowClone(COL_NOTIFICATION_BACKCOLOR) = reminderRow(COL_NOTIFICATION_BACKCOLOR)
        reminderRowClone(COL_NOTIFICATION_FORECOLOR) = reminderRow(COL_NOTIFICATION_FORECOLOR)
        reminderRowClone(COL_NOTIFICATION_WIDTH) = reminderRow(COL_NOTIFICATION_WIDTH)
        reminderRowClone(COL_NOTIFICATION_HEIGHT) = reminderRow(COL_NOTIFICATION_HEIGHT)

        Return reminderRowClone
    End Function


    Public Function getReminderRow(reminderId As Integer) As DataRow
        gReminderTable.PrimaryKey = New DataColumn() {gReminderTable.Columns(COL_REMINDER_ID)}
        If gReminderTable.Rows.Count <= 0 Then
            Return Nothing
        End If
        Return gReminderTable.Rows.Find(reminderId)
    End Function

    Public Function getReminderHistoryRow(reminderId As Integer) As DataRow
        Dim reminderHistoryTable As DataTable = getReminderHistoryTable()
        reminderHistoryTable.PrimaryKey = New DataColumn() {reminderHistoryTable.Columns(COL_REMINDER_ID)}
        If reminderHistoryTable.Rows.Count <= 0 Then
            Return Nothing
        End If
        Return reminderHistoryTable.Rows.Find(reminderId)
    End Function

    Public Function getReminderStatus(reminderId As Integer) As String
        Dim reminderRow As DataRow = getReminderRow(reminderId)
        If reminderRow Is Nothing Then
            Return REMINDER_STATUS_NONE
        End If
        Return reminderRow.Item(COL_REMINDER_STATUS)
    End Function

    Public Sub updateReminderStatus(reminderId As Integer, reminderStatus As String)
        Dim reminderRow As DataRow = getReminderRow(reminderId)
        If reminderRow Is Nothing Then
            Return
        End If
        reminderRow.Item(COL_REMINDER_STATUS) = reminderStatus
    End Sub

    Public Sub startReminder(reminderId As Integer)
        If gReminderTimer.Enabled = False Then
            gReminderTimer.Start()
        End If

        Dim reminderRow As DataRow = getReminderRow(reminderId)
        If reminderRow Is Nothing Then
            Return
        End If

        gRunnningRemindersMap.Item(reminderId) = New RunningReminder(reminderRow, New ReminderNotification)

        reminderRow.Item(COL_REMINDER_STATUS) = REMINDER_STATUS_RUNNING
        reminderRow.Item(COL_REMINDER_STARTED_TIME) = DateTime.Now
        reminderRow.Item(COL_REMINDER_REPEAT_ELAPSED) = 0

        updateNextNotifyTime(reminderRow)

        'Dont change the order. This line shoule come after updating the reminder to 'running' status.
        updateStatusBar(reminderRow)

        commitUpdatedReminderRow(reminderRow)

    End Sub

    Private Sub updateNextNotifyTime(reminderRow As DataRow)
        Dim reminderType As String = reminderRow.Item(COL_REMINDER_TYPE)

        Select Case reminderType
            Case REMINDER_TYPE_INTERVAL
                reminderRow.Item(COL_REMINDER_NEXT_NOTIFY_TIME) = DateTime.Now.AddSeconds(convertFormattedIntervalToSeconds(reminderRow.Item(COL_REMINDER_INTERVAL)))
            Case REMINDER_TYPE_DAILY
                reminderRow.Item(COL_REMINDER_NEXT_NOTIFY_TIME) = getNextNotificationTimeForDailyReminder(reminderRow)
            Case REMINDER_TYPE_SPECIFIC_TIME
                reminderRow.Item(COL_REMINDER_NEXT_NOTIFY_TIME) = reminderRow.Item(COL_REMINDER_SPECIFIC_TIME)
        End Select

    End Sub

    Private Sub updateRepeatElapsed(reminderRow As DataRow)
        Dim reminderType As String = reminderRow.Item(COL_REMINDER_TYPE)

        Select Case reminderType
            Case REMINDER_TYPE_INTERVAL
                reminderRow(COL_REMINDER_REPEAT_ELAPSED) += 1
            Case REMINDER_TYPE_DAILY
                'to cehck if both dates falls in same week
                Dim notifiedTime As DateTime = reminderRow(COL_REMINDER_NOTIFIED_TIME)
                Dim nextNotifyTime As DateTime = reminderRow(COL_REMINDER_NEXT_NOTIFY_TIME)

                Dim dayOftheWeek As Integer = If(notifiedTime.DayOfWeek = 0, 7, notifiedTime.DayOfWeek)
                Dim mondayOfNotifiedTime As DateTime = notifiedTime.AddDays((dayOftheWeek - 1) * -1)
                dayOftheWeek = If(nextNotifyTime.DayOfWeek = 0, 7, nextNotifyTime.DayOfWeek)
                Dim mondayOfNextNotifyTime As DateTime = nextNotifyTime.AddDays((dayOftheWeek - 1) * -1)
                If mondayOfNotifiedTime.Date <> mondayOfNextNotifyTime.Date Then
                    'Increase occurance as the next notification falls in next week
                    reminderRow(COL_REMINDER_REPEAT_ELAPSED) += 1
                End If

            Case REMINDER_TYPE_SPECIFIC_TIME
                reminderRow(COL_REMINDER_REPEAT_ELAPSED) += 1
        End Select

    End Sub

    Public Sub stopReminder(reminderId As Integer)
        Dim runningReminder As RunningReminder = gRunnningRemindersMap.Item(reminderId)
        Dim reminderRow As DataRow = runningReminder.reminderRow

        If reminderRow Is Nothing Then
            Return
        End If

        gRunnningRemindersMap.Remove(reminderId)

        reminderRow.Item(COL_REMINDER_STATUS) = REMINDER_STATUS_NOT_RUNNING
        reminderRow.Item(COL_REMINDER_NEXT_NOTIFY_TIME) = DBNull.Value

        'Dont change the order. This line shoule come after updating the reminder to 'not running' status.
        updateStatusBar(reminderRow)
        gReminderUpdateObserver.reminderStopped()

        commitUpdatedReminderRow(reminderRow)

        Dim toastNotificationForm As ReminderNotification = runningReminder.toastNotificationForm
        toastNotificationForm.Close()
    End Sub

    Public Sub updateStatusBar(reminderRow As DataRow)
        Dim reminderId As Integer = reminderRow(COL_REMINDER_ID)
        Dim reminderStatus As String = reminderRow(COL_REMINDER_STATUS)

        If reminderStatus = REMINDER_STATUS_RUNNING Then
            gReminderUpdateObserver.remainingTimeChanged("This reminder is running")
            gRemainingTimeToNotificationTimer.Tag = reminderId
            gRemainingTimeToNotificationTimer.Start()
        ElseIf reminderStatus = REMINDER_STATUS_NOT_RUNNING Then
            gReminderUpdateObserver.remainingTimeChanged("This reminder is not running")
            gRemainingTimeToNotificationTimer.Tag = -1
            gRemainingTimeToNotificationTimer.Stop()
        End If

    End Sub

    Private Sub reminderTimer_tick(ByVal sender As Object, ByVal e As EventArgs)

        For Each runningReminderItem As KeyValuePair(Of Integer, RunningReminder) In gRunnningRemindersMap
            Dim runningReminder As RunningReminder = runningReminderItem.Value
            Dim reminderRow As DataRow = runningReminder.reminderRow

            If reminderRow Is Nothing Then
                Return
            End If

            Dim nextNotifyTime As DateTime = reminderRow(COL_REMINDER_NEXT_NOTIFY_TIME)
            Dim currentTime As DateTime = DateTime.Now
            Dim reminderId As Integer = runningReminderItem.Key
            Dim reminderStatus As String = reminderRow(COL_REMINDER_STATUS)
            Dim toastNotificationForm As ReminderNotification = runningReminder.toastNotificationForm

            If reminderStatus = REMINDER_STATUS_RUNNING AndAlso reminderRow(COL_REMINDER_REPEAT_ELAPSED) >= reminderRow(COL_REMINDER_REPEAT_MAX) Then
                If toastNotificationForm.Visible = False Then
                    stopReminder(reminderId)
                End If
                Return
            End If

            If nextNotifyTime <= currentTime Then
                toastNotificationForm = New ReminderNotification
                runningReminder.toastNotificationForm = toastNotificationForm
                toastNotificationForm.showNotification(reminderRow)
                reminderRow(COL_REMINDER_NOTIFIED_TIME) = DateTime.Now
                updateNextNotifyTime(reminderRow)
                'This line should come after updating next notify time
                updateRepeatElapsed(reminderRow)
                commitUpdatedReminderRow(reminderRow)
            End If
        Next

    End Sub


    Private Sub remainingTimeToNotificationTimer_tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim reminderId As Integer = gRemainingTimeToNotificationTimer.Tag
        If reminderId = -1 Then
            Return
        End If

        Dim reminderRow As DataRow = getReminderRow(reminderId)
        If reminderRow Is Nothing Then
            Return
        End If

        If reminderRow(COL_REMINDER_STATUS) = REMINDER_STATUS_RUNNING AndAlso reminderRow(COL_REMINDER_REPEAT_ELAPSED) >= reminderRow(COL_REMINDER_REPEAT_MAX) Then
            gReminderUpdateObserver.remainingTimeChanged("Currently notification is being shown for this reminder")
            Return
        End If

        Dim currentTime As DateTime = DateTime.Now
        Dim nextNotifyTime As DateTime = reminderRow(COL_REMINDER_NEXT_NOTIFY_TIME)
        Dim remainingTime As Double = nextNotifyTime.Subtract(currentTime).TotalSeconds

        If remainingTime < 2 And remainingTime > 0 Then
            gReminderUpdateObserver.remainingTimeChanged("Notification is about to be shown")
        ElseIf remainingTime <= 0 Then
            gReminderUpdateObserver.remainingTimeChanged("Currently notification is being shown for this reminder")
        Else
            gReminderUpdateObserver.remainingTimeChanged(getFormattedIntervalFromSeconds(remainingTime))
        End If

    End Sub


    Private Function getNextNotificationTimeForDailyReminder(reminderRow As DataRow) As DateTime
        Dim nextNotificationTime As DateTime = Nothing

        Dim dailyReminderTime As String = reminderRow(COL_REMINDER_DAILY)
        Dim dailyReminderTimeArray As Array = dailyReminderTime.Split(" ")
        Dim daysArray As Array = dailyReminderTimeArray(0).ToString.Split("|")
        Dim timeStr As String = dailyReminderTimeArray(1) + " " + dailyReminderTimeArray(2)
        Dim reminderTime As DateTime = DateTime.ParseExact(timeStr, "hh:mm:ss tt", CultureInfo.InvariantCulture)

        Dim dateTimeNow As DateTime = DateTime.Now
        Dim dayOftheWeek As Integer = dateTimeNow.DayOfWeek
        dayOftheWeek = If(dayOftheWeek = 0, 7, dayOftheWeek)

        For Each day As String In daysArray
            Dim indexOfReminderDay As Integer = daysToIndexMap(day)
            Dim daysToAdd As Integer = If(indexOfReminderDay <= dayOftheWeek, (dayOftheWeek - indexOfReminderDay) * -1, (indexOfReminderDay - dayOftheWeek))
            Dim reminderDateTime As DateTime = dateTimeNow.AddDays(daysToAdd)
            reminderDateTime = New DateTime(reminderDateTime.Year, reminderDateTime.Month, reminderDateTime.Day,
                                                    reminderTime.Hour, reminderTime.Minute, reminderTime.Second, 0)
            If reminderDateTime >= dateTimeNow Then
                nextNotificationTime = reminderDateTime
                Exit For
            End If
        Next

        If nextNotificationTime = Nothing Then
            Dim indexOfReminderDayNextWeek As Integer = daysToIndexMap(daysArray(0))
            Dim daysToAdd As Integer = (7 - dayOftheWeek) + indexOfReminderDayNextWeek
            Dim reminderDateTime As DateTime = dateTimeNow.AddDays(daysToAdd)
            nextNotificationTime = New DateTime(reminderDateTime.Year, reminderDateTime.Month, reminderDateTime.Day,
                                                    reminderTime.Hour, reminderTime.Minute, reminderTime.Second, 0)
        End If
        Return nextNotificationTime
    End Function
End Class
