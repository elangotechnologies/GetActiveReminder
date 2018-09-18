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
    Private gRemainingTimeToNotificationTimer As New Timer
    Private gRemainingTimeObserver As IRemainingTimeObserver

    Private Shared classLocker As New Object()
    Private Shared objSingleton As ReminderManager

    Private Sub New()
        '' cleanSavedReminderTable()
        loadReminders()
        AddHandler gRemainingTimeToNotificationTimer.Tick, AddressOf remainingTimeToNotificationTimer_tick
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
        Public timer As Timer
        Public reminderRow As DataRow
        Public toastNotificationForm As ToastNotificationForm

        Public Sub New(timer As Timer, reminderRow As DataRow, toastNotificationForm As ToastNotificationForm)
            Me.timer = timer
            Me.reminderRow = reminderRow
            Me.toastNotificationForm = toastNotificationForm
        End Sub
    End Class

    Public Interface IRemainingTimeObserver
        Sub remainingTimeChanged(remainingTimeStr As String)
    End Interface

    Public Function getReminderTable() As DataTable
        Return gReminderTable
    End Function

    Public Sub registerForRemainingTime(remainingTimeObserver As IRemainingTimeObserver)
        gRemainingTimeObserver = remainingTimeObserver
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
        gReminderTable.Columns.AddRange(New DataColumn(16) _
                {New DataColumn(COL_REMINDER_ID, GetType(Integer)),
                New DataColumn(COL_REMINDER_TYPE, GetType(String)),
                New DataColumn(COL_REMINDER_STATUS, GetType(String)),
                New DataColumn(COL_REMINDER_INTERVAL, GetType(String)),
                New DataColumn(COL_REMINDER_CREATED_TIME, GetType(DateTime)),
                New DataColumn(COL_REMINDER_UPDATED_TIME, GetType(DateTime)),
                New DataColumn(COL_REMINDER_STARTED_TIME, GetType(DateTime)),
                New DataColumn(COL_REMINDER_NOTIFIED_TIME, GetType(DateTime)),
                New DataColumn(COL_NOTIFICATION_DURATION, GetType(Integer)),
                New DataColumn(COL_NOTIFICATION_SOUND, GetType(String)),
                New DataColumn(COL_NOTIFICATION_MESSAGE, GetType(String)),
                New DataColumn(COL_NOTIFICATION_FONT, GetType(String)),
                New DataColumn(COL_NOTIFICATION_BACKCOLOR, GetType(String)),
                New DataColumn(COL_NOTIFICATION_FORECOLOR, GetType(String)),
                New DataColumn(COL_NOTIFICATION_WIDTH, GetType(Integer)),
                New DataColumn(COL_NOTIFICATION_HEIGHT, GetType(Integer)),
                New DataColumn(COL_NOTIFICATION_VISIBLE_STATUS, GetType(Integer))})
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
        Return gReminderTable.Rows.Find(reminderId)
    End Function

    Public Function getReminderStatus(reminderId As Integer) As String
        Dim reminderRow As DataRow = getReminderRow(reminderId)
        Return reminderRow.Item(COL_REMINDER_STATUS)
    End Function

    Public Sub updateReminderStatus(reminderId As Integer, reminderStatus As String)
        Dim reminderRow As DataRow = getReminderRow(reminderId)
        reminderRow.Item(COL_REMINDER_STATUS) = reminderStatus
    End Sub

    Public Sub startReminder(reminderId As Integer)
        Dim reminderRow As DataRow = getReminderRow(reminderId)

        Dim reminderIntervalTimer As New Timer
        reminderIntervalTimer.Interval = convertFormattedIntervalToMilliseconds(reminderRow.Item(COL_REMINDER_INTERVAL))
        reminderIntervalTimer.Enabled = False
        reminderIntervalTimer.Tag = reminderId
        gRunnningRemindersMap.Item(reminderId) = New RunningReminder(reminderIntervalTimer, reminderRow, New ToastNotificationForm)
        reminderIntervalTimer.Start()

        reminderRow.Item(COL_REMINDER_STARTED_TIME) = DateTime.Now
        reminderRow.Item(COL_REMINDER_STATUS) = REMINDER_STATUS_RUNNING

        commitUpdatedReminderRow()

        AddHandler reminderIntervalTimer.Tick, AddressOf reminderIntervalTimer_tick

    End Sub

    Public Sub stopReminder(reminderId As Integer)
        Dim reminderRow As DataRow = getReminderRow(reminderId)

        Dim runningReminder As RunningReminder = gRunnningRemindersMap.Item(reminderId)
        Dim reminderIntervalTimer As Timer = runningReminder.timer
        ''For Actual Reminder Timer stop
        reminderIntervalTimer.Stop()

        reminderRow.Item(COL_REMINDER_STATUS) = REMINDER_STATUS_NOT_RUNNING
        reminderRow.Item(COL_REMINDER_STARTED_TIME) = DBNull.Value
        reminderRow.Item(COL_REMINDER_NOTIFIED_TIME) = DBNull.Value

        'Dont change the order. This line shoule come after updating the reminder to not running status.
        updateStatusBar(reminderId)

        commitUpdatedReminderRow()

        Dim toastNotificationForm As ToastNotificationForm = runningReminder.toastNotificationForm
        toastNotificationForm.Close()
    End Sub

    Public Sub updateStatusBar(reminderId As Integer)
        Dim reminderRow As DataRow = getReminderRow(reminderId)
        Dim reminderStatus As String = reminderRow.Item(COL_REMINDER_STATUS)

        If reminderStatus = REMINDER_STATUS_RUNNING Then
            gRemainingTimeObserver.remainingTimeChanged("This reminder is running")
            gRemainingTimeToNotificationTimer.Tag = reminderId
            gRemainingTimeToNotificationTimer.Start()
        ElseIf reminderStatus = REMINDER_STATUS_NOT_RUNNING Then
            gRemainingTimeObserver.remainingTimeChanged("This reminder is not running")
            gRemainingTimeToNotificationTimer.Tag = -1
            gRemainingTimeToNotificationTimer.Stop()
        End If

    End Sub

    Public Sub clearRemainingTimeToNotification(reminderId As Integer, statusBarLabel As ToolStripStatusLabel)
        Dim reminderRow As DataRow = getReminderRow(reminderId)

        statusBarLabel.Text = "This reminder is not running currently"
        statusBarLabel.ForeColor = Color.Red

        gRemainingTimeToNotificationTimer.Stop()
    End Sub

    Private Sub reminderIntervalTimer_tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim reminderIntervalTimer As Timer = sender
        Dim reminderId As Integer = reminderIntervalTimer.Tag

        Dim runningReminder As RunningReminder = gRunnningRemindersMap.Item(reminderId)
        Dim reminderRow As DataRow = runningReminder.reminderRow

        Dim toastNotificationForm As ToastNotificationForm = New ToastNotificationForm
        runningReminder.toastNotificationForm = toastNotificationForm
        toastNotificationForm.showNotification(reminderRow)

        reminderRow(COL_REMINDER_NOTIFIED_TIME) = DateTime.Now
        commitUpdatedReminderRow()

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

        Dim lastNotifiedTime As DateTime = If(IsDBNull(reminderRow.Item(COL_REMINDER_NOTIFIED_TIME)), Nothing, reminderRow.Item(COL_REMINDER_NOTIFIED_TIME))
        If lastNotifiedTime = Nothing Then
            lastNotifiedTime = If(IsDBNull(reminderRow.Item(COL_REMINDER_STARTED_TIME)), Nothing, reminderRow.Item(COL_REMINDER_STARTED_TIME))
        End If

        If lastNotifiedTime = Nothing Then
            Return
        End If

        Dim currentTime As DateTime = DateTime.Now
        Dim elapsedTime As Double = currentTime.Subtract(lastNotifiedTime).TotalMilliseconds
        Dim intervalDuration As Double = convertFormattedIntervalToMilliseconds(reminderRow.Item(COL_REMINDER_INTERVAL))
        Dim remainingTime As Double = intervalDuration - elapsedTime

        gRemainingTimeObserver.remainingTimeChanged(getFormattedInterval(remainingTime))
    End Sub



End Class
