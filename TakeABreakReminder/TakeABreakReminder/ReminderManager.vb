Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Imports NLog
Imports System.Reflection
Imports System.ComponentModel
Imports System.Globalization
Imports TakeABreakReminder

Public NotInheritable Class ReminderManager
    Shared log As Logger = LogManager.GetCurrentClassLogger()
    Private gReminderTable As DataTable
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
        Public toastNotificationForm As ToastNotificationForm

        Public Sub New(reminderRow As DataRow, toastNotificationForm As ToastNotificationForm)
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

    Public Sub registerForRemainingTime(reminderUpdateObserver As IReminderUpdateObserver)
        gReminderUpdateObserver = reminderUpdateObserver
    End Sub


    Private Sub saveRemindersInPermenantStorage(dataTable As DataTable)

        Dim fileWriter As New FileStream("Reminders.dat", FileMode.Create, FileAccess.Write, FileShare.None)
        Dim binaryFormatter As New BinaryFormatter

        Try
            binaryFormatter.Serialize(fileWriter, dataTable)
        Catch ex As SerializationException
            Console.WriteLine("saveReminder: Serialization failed. Reason: " & ex.Message)
        Catch ex As TargetInvocationException
            Dim iEX = ex.InnerException
            MsgBox(iEX.Message)
        Finally
            fileWriter.Close()
        End Try

    End Sub

    Public Sub cleanSavedReminderTable()
        Dim fileWriter As FileStream = File.Create("Reminders.dat")
        ''Dim fileWriter As New FileStream("Reminders.dat", FileMode.Create, FileAccess.Write, FileShare.None)
        fileWriter.Close()
    End Sub

    Private Sub loadReminders()
        Dim fileReader As New FileStream("Reminders.dat", FileMode.OpenOrCreate, FileAccess.Read)
        Dim binaryFormatter As New BinaryFormatter
        gReminderTable = New DataTable
        gReminderTable.Columns.AddRange(New DataColumn(20) _
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
        gReminderTable.Columns(COL_REMINDER_ID).AutoIncrement = True
        gReminderTable.Columns(COL_REMINDER_ID).AutoIncrementSeed = 1
        gReminderTable.Columns(COL_REMINDER_ID).AutoIncrementStep = 1

        Try
            gReminderTable = DirectCast(binaryFormatter.Deserialize(fileReader), DataTable)
        Catch ex As SerializationException
            Console.WriteLine("loadReminders: DeSerialization failed. Reason: " & ex.Message)
        Catch ex As TargetInvocationException
            Dim iEX = ex.InnerException
            MsgBox(iEX.Message)
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

    Public Function createNewReminderRow() As DataRow
        Return gReminderTable.NewRow()
    End Function

    Public Sub commitNewReminderRow(reminderRow As DataRow)
        gReminderTable.Rows.Add(reminderRow)
        saveRemindersInPermenantStorage(gReminderTable)
    End Sub

    Public Sub commitUpdatedReminderRow()
        saveRemindersInPermenantStorage(gReminderTable)
    End Sub

    Public Sub commitDeletedReminderRow(reminderRow As DataRow)
        gReminderTable.Rows.Remove(reminderRow)
        saveRemindersInPermenantStorage(gReminderTable)
    End Sub

    Public Function getReminderRow(reminderId As Integer) As DataRow
        gReminderTable.PrimaryKey = New DataColumn() {gReminderTable.Columns(COL_REMINDER_ID)}
        If gReminderTable.Rows.Count <= 0 Then
            Return Nothing
        End If
        Return gReminderTable.Rows.Find(reminderId)
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

        gRunnningRemindersMap.Item(reminderId) = New RunningReminder(reminderRow, New ToastNotificationForm)

        reminderRow.Item(COL_REMINDER_STATUS) = REMINDER_STATUS_RUNNING
        reminderRow.Item(COL_REMINDER_STARTED_TIME) = DateTime.Now
        reminderRow.Item(COL_REMINDER_REPEAT_ELAPSED) = 0

        updateNextNotifyTime(reminderRow)

        'Dont change the order. This line shoule come after updating the reminder to 'running' status.
        updateStatusBar(reminderRow)

        commitUpdatedReminderRow()

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
                log.Debug("mondayOfNotifiedTime: " + mondayOfNotifiedTime.ToString)
                dayOftheWeek = If(nextNotifyTime.DayOfWeek = 0, 7, nextNotifyTime.DayOfWeek)
                Dim mondayOfNextNotifyTime As DateTime = nextNotifyTime.AddDays((dayOftheWeek - 1) * -1)
                log.Debug("mondayOfNextNotifyTime: " + mondayOfNextNotifyTime.ToString)
                If mondayOfNotifiedTime.Date <> mondayOfNextNotifyTime.Date Then
                    'Increase occurance as the next notification falls in next week
                    reminderRow(COL_REMINDER_REPEAT_ELAPSED) += 1
                    log.Debug("Increasing the repeat count")
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

        commitUpdatedReminderRow()

        Dim toastNotificationForm As ToastNotificationForm = runningReminder.toastNotificationForm
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
            Dim toastNotificationForm As ToastNotificationForm = runningReminder.toastNotificationForm

            If reminderStatus = REMINDER_STATUS_RUNNING AndAlso reminderRow(COL_REMINDER_REPEAT_ELAPSED) >= reminderRow(COL_REMINDER_REPEAT_MAX) Then
                If toastNotificationForm.Visible = False Then
                    stopReminder(reminderId)
                End If
                Return
            End If

            If nextNotifyTime <= currentTime Then
                toastNotificationForm = New ToastNotificationForm
                runningReminder.toastNotificationForm = toastNotificationForm
                toastNotificationForm.showNotification(reminderRow)
                reminderRow(COL_REMINDER_NOTIFIED_TIME) = DateTime.Now
                updateNextNotifyTime(reminderRow)
                'This line should come after updating next notify time
                updateRepeatElapsed(reminderRow)
                commitUpdatedReminderRow()
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
            Return
        End If

        Dim currentTime As DateTime = DateTime.Now
        Dim nextNotifyTime As DateTime = reminderRow(COL_REMINDER_NEXT_NOTIFY_TIME)
        Dim remainingTime As Double = nextNotifyTime.Subtract(currentTime).TotalSeconds

        If remainingTime < 0 Then
            Return
        End If

        gReminderUpdateObserver.remainingTimeChanged(getFormattedIntervalFromSeconds(remainingTime))
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
