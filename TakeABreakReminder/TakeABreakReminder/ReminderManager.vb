Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Imports NLog

Public NotInheritable Class ReminderManager
    Shared log As Logger = LogManager.GetCurrentClassLogger()
    Private gReminderMap As New Hashtable

    Private Shared classLocker As New Object()
    Private Shared objSingleton As ReminderManager

    Private Sub New()
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

    Public Function saveReminder(reminderId As Integer, reminder As Reminder) As Boolean

        gReminderMap.Item(reminderId) = reminder

        Dim fileWriter As New FileStream("Reminders.dat", FileMode.Create, FileAccess.Write, FileShare.None)
        Dim binaryFormatter As New BinaryFormatter

        Try
            binaryFormatter.Serialize(fileWriter, gReminderMap)
        Catch e As SerializationException
            log.Debug("saveReminder: Serialization failed. Reason: " & e.Message)
            ''Throw
        Finally
            fileWriter.Close()
        End Try

        Return True
    End Function

    Private Sub saveReminderTable(dataTable As DataTable)

        Dim fileWriter As New FileStream("Reminders.dat", FileMode.Create, FileAccess.Write, FileShare.None)
        Dim binaryFormatter As New BinaryFormatter

        Try
            binaryFormatter.Serialize(fileWriter, dataTable)
        Catch ex As SerializationException
            Console.WriteLine("saveReminder: Serialization failed. Reason: " & ex.Message)
            ''Throw
        Finally
            fileWriter.Close()
        End Try

    End Sub

    Public Sub cleanSavedReminderTable()

        Dim fileWriter As New FileStream("Reminders.dat", FileMode.Create, FileAccess.Write, FileShare.None)
        fileWriter.Close()
    End Sub

    Public Function getReminderTable() As DataTable

        Dim fileReader As New FileStream("Reminders.dat", FileMode.OpenOrCreate, FileAccess.Read)
        Dim binaryFormatter As New BinaryFormatter
        Dim dataTable As DataTable = New DataTable

        Try
            dataTable = DirectCast(binaryFormatter.Deserialize(fileReader), DataTable)
        Catch ex As SerializationException
            Console.WriteLine("loadReminders: DeSerialization failed. Reason: " & ex.Message)
        Finally
            fileReader.Close()
        End Try


        log.Debug("dataTable rows count: " + dataTable.Rows.Count.ToString)
        Return dataTable
    End Function

    Public Function getReminder(reminderId As Integer) As Reminder
        Dim reminder As Reminder = gReminderMap.Item(reminderId)
        Return reminder
    End Function

    Public Function getReminders() As Hashtable
        Return gReminderMap
    End Function

    Public Function loadReminders() As Boolean

        Dim fileReader As New FileStream("Reminders.dat", FileMode.OpenOrCreate, FileAccess.Read)
        Dim binaryFormatter As New BinaryFormatter

        Try
            gReminderMap = DirectCast(binaryFormatter.Deserialize(fileReader), Hashtable)
        Catch e As SerializationException
            log.Debug("loadReminders: DeSerialization failed. Reason: " & e.Message)
        Finally
            fileReader.Close()
        End Try

        Return True
    End Function
End Class
