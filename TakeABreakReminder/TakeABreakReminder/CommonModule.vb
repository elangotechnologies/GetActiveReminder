Imports System.ComponentModel
Imports System.Globalization

Module CommonModule
    Public Const REMINDER_TYPE_INTERVAL As String = "interval"
    Public Const REMINDER_TYPE_DAILY As String = "daily"
    Public Const REMINDER_TYPE_WEEKLY As String = "weekly"
    Public Const REMINDER_TYPE_SPECIFIC_TIME As String = "specific"

    Public Const REMINDER_CREATION_STATUS_NONE As Integer = 0
    Public Const REMINDER_CREATION_STATUS_IN_PROGRESS As Integer = 1

    Public Const REMINDER_NOTIFICATION_VISIBLE_STATUS_NONE As Integer = 0
    Public Const REMINDER_NOTIFICATION_VISIBLE_STATUS_SHOWING As Integer = 1

    Public Const REMINDER_STATUS_RUNNING As String = "running"
    Public Const REMINDER_STATUS_NOT_RUNNING As String = "not running"

    Public Const COL_REMINDER_ID As String = "reminder_id"
    Public Const COL_REMINDER_TYPE As String = "reminder_type"
    Public Const COL_REMINDER_STATUS As String = "reminder_status"
    Public Const COL_REMINDER_INTERVAL As String = "reminder_interval"
    Public Const COL_REMINDER_CREATED_TIME As String = "reminder_created_time"
    Public Const COL_REMINDER_UPDATED_TIME As String = "reminder_updated_time"
    Public Const COL_REMINDER_STARTED_TIME As String = "reminder_started_time"
    Public Const COL_REMINDER_NOTIFIED_TIME As String = "reminder_notified_time"
    Public Const COL_NOTIFICATION_DURATION As String = "notification_duration"
    Public Const COL_NOTIFICATION_SOUND As String = "notification_sound"
    Public Const COL_NOTIFICATION_MESSAGE As String = "notification_message"
    Public Const COL_NOTIFICATION_FONT As String = "notification_font"
    Public Const COL_NOTIFICATION_BACKCOLOR As String = "notification_backcolor"
    Public Const COL_NOTIFICATION_FORECOLOR As String = "notification_forecolor"
    Public Const COL_NOTIFICATION_WIDTH As String = "notification_width"
    Public Const COL_NOTIFICATION_HEIGHT As String = "notification_height"
    Public Const COL_NOTIFICATION_VISIBLE_STATUS As String = "notification_visible_status"

    Public Const HOURS_MILLISECONDS_CONVERTER As Double = 60 * 60 * 1000
    Public Const MINUTES_MILLISECONDS_CONVERTER As Double = 60 * 1000
    Public Const SECONDS_MILLISECONDS_CONVERTER As Double = 1000

    Public Const REMINDER_INTERVAL_MINIMUM_LIMIT As Double = 1 * SECONDS_MILLISECONDS_CONVERTER

    Public Const NOTIFICATION_GAP_OFFSET As Integer = 10

    Public gVisibleNotifications As New List(Of ToastNotificationForm)

    Public gSumOfNotificationHeights As Integer = 0

    Public Function getFontObjFromDisplayFormat(fontDisplayString As String) As Font
        Dim typeConverter As TypeConverter = TypeDescriptor.GetConverter(GetType(Font))
        Dim cultureInfo As CultureInfo = CultureInfo.CurrentUICulture
        Dim fontObject As Font = DirectCast(typeConverter.ConvertFromString(Nothing, System.Globalization.CultureInfo.CreateSpecificCulture(cultureInfo.ToString), fontDisplayString), Font)

        Return fontObject
    End Function

    Public Function getFormattedInterval(milliseconds As Double) As String
        Dim hours As Integer = milliseconds / HOURS_MILLISECONDS_CONVERTER
        milliseconds = milliseconds Mod HOURS_MILLISECONDS_CONVERTER
        Dim minutes As Integer = milliseconds / MINUTES_MILLISECONDS_CONVERTER
        milliseconds = milliseconds Mod MINUTES_MILLISECONDS_CONVERTER
        Dim seconds As Integer = milliseconds / SECONDS_MILLISECONDS_CONVERTER

        Return getFormattedInterval(hours, minutes, seconds)
    End Function

    Public Function getFormattedInterval(hours As Integer, minutes As Integer, seconds As Integer) As String
        Return hours.ToString("00") + " hrs, " + minutes.ToString("00") + " mins, " + seconds.ToString("00") + " secs"
    End Function

    Public Function convertTimeToMilliseconds(hours As Integer, minutes As Integer, seconds As Integer) As Double
        Return hours * HOURS_MILLISECONDS_CONVERTER + minutes * MINUTES_MILLISECONDS_CONVERTER + seconds * SECONDS_MILLISECONDS_CONVERTER
    End Function

    Public Function convertFormattedIntervalToMilliseconds(ByVal formattedInterval As String) As Double
        formattedInterval = formattedInterval.Replace("hrs", "").Replace("mins", "").Replace("secs", "").Replace(" ", "")
        Dim timeArray = formattedInterval.Split(",")

        Dim hours As Integer = Integer.Parse(timeArray(0))
        Dim minutes As Integer = Integer.Parse(timeArray(1))
        Dim seconds As Integer = Integer.Parse(timeArray(2))

        Return hours * HOURS_MILLISECONDS_CONVERTER + minutes * MINUTES_MILLISECONDS_CONVERTER + seconds * SECONDS_MILLISECONDS_CONVERTER
    End Function

    Public Function getFontInDisplayFormat(myFont As Font) As String
        Dim fontFamilyName As String = myFont.FontFamily.GetName(0).ToString
        Dim fontSize As String = myFont.Size.ToString
        Dim fontStyle As String = myFont.Style.ToString

        Return fontFamilyName + ", " + fontSize + "pt, style=" + fontStyle
    End Function

    Sub selectRowAtDataGridByKey(lDataGridView As DataGridView, lDBkeyColumn As String, lKeyValue As Integer)
        Dim lDataBindingSource As BindingSource = lDataGridView.DataSource
        Dim lDataTableFromBinding As DataTable = lDataBindingSource.DataSource
        lDataGridView.DataSource.Position = lDataBindingSource.Find(lDataTableFromBinding.Columns(lDBkeyColumn).ToString, lKeyValue.ToString)
        lDataBindingSource.ResetBindings(False)
    End Sub

    Public Sub setDataGrid(lDataGridView As DataGridView, lDataTable As DataTable)
        Dim lBindingSource As New BindingSource()
        lBindingSource.DataSource = lDataTable
        lDataGridView.DataSource = lBindingSource
        lDataGridView.ClearSelection()
        If lDataTable.Rows.Count > 0 Then
            lDataGridView.FirstDisplayedScrollingRowIndex = lDataTable.Rows.Count - 1
        End If
    End Sub

    Public Function getHours(milliseconds As Double) As Integer
        Return milliseconds / HOURS_MILLISECONDS_CONVERTER
    End Function

    Public Function getMinutes(milliseconds As Double) As Integer
        Return (milliseconds Mod HOURS_MILLISECONDS_CONVERTER) / MINUTES_MILLISECONDS_CONVERTER
    End Function

    Public Function getSeconds(milliseconds As Double) As Integer
        Return ((milliseconds Mod HOURS_MILLISECONDS_CONVERTER) Mod MINUTES_MILLISECONDS_CONVERTER) / SECONDS_MILLISECONDS_CONVERTER
    End Function

    Public Sub updateVisibleNotificationPositions()

        Dim sumOfNotificationsHeight As Integer = 0
        For Each notificationForm As ToastNotificationForm In gVisibleNotifications
            sumOfNotificationsHeight += notificationForm.Height + NOTIFICATION_GAP_OFFSET
            Dim yPosition As Integer = Screen.PrimaryScreen.WorkingArea.Height - sumOfNotificationsHeight
            notificationForm.Location = New Point(notificationForm.Location.X, yPosition)
        Next

    End Sub

    Public Function getVisibleNotificationsTotalHeight() As Integer

        Dim sumOfNotificationsHeight As Integer = 0

        For Each notificationForm As ToastNotificationForm In gVisibleNotifications
            sumOfNotificationsHeight += notificationForm.Height + NOTIFICATION_GAP_OFFSET
        Next

        Return sumOfNotificationsHeight

    End Function

End Module
