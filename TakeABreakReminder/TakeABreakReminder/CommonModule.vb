Imports System.ComponentModel
Imports System.Globalization
Imports NLog

Module CommonModule
    Public log As Logger = LogManager.GetCurrentClassLogger()

    Public Const REMINDER_TYPE_NONE As String = "none"
    Public Const REMINDER_TYPE_INTERVAL As String = "Interval"
    Public Const REMINDER_TYPE_DAILY As String = "Daily"
    Public Const REMINDER_TYPE_SPECIFIC_TIME As String = "Specific"

    Public Const OPERATION_NONE As Integer = -1
    Public Const OPERATION_SCREEN_LOADED As Integer = 0
    Public Const OPERATION_SCREEN_CLEARED As Integer = 1
    Public Const OPERATION_SCREEN_VALUES_RESET As Integer = 2
    Public Const OPERATION_ADD_STARTED As Integer = 3
    Public Const OPERATION_ADD_COMPLETED As Integer = 4
    Public Const OPERATION_CLONE_COMPLETED As Integer = 5
    Public Const OPERATION_ADD_CANCELED As Integer = 6
    Public Const OPERATION_EDIT_STARTED As Integer = 7
    Public Const OPERATION_EDIT_COMPLETED As Integer = 8
    Public Const OPERATION_EDIT_CANCELED As Integer = 9
    Public Const OPERATION_DELETE_COMPLETED As Integer = 10
    Public Const OPERATION_REMINDER_STARTED As Integer = 11
    Public Const OPERATION_REMINDER_STOPPED As Integer = 12
    Public Const OPERATION_REMINDER_SELECTED As Integer = 13
    Public Const OPERATION_REMINDER_TYPE_INTERVAL_CHECKED As Integer = 14
    Public Const OPERATION_REMINDER_TYPE_DAILY_CHECKED As Integer = 15
    Public Const OPERATION_REMINDER_TYPE_SPECIFIC_CHECKED As Integer = 16
    Public Const OPERATION_REMINDER_TYPE_INTERVAL_UNCHECKED As Integer = 17
    Public Const OPERATION_REMINDER_TYPE_DAILY_UNCHECKED As Integer = 18
    Public Const OPERATION_REMINDER_TYPE_SPECIFIC_UNCHECKED As Integer = 19

    Public Const REMINDER_NOTIFICATION_VISIBLE_STATUS_NONE As Integer = 0
    Public Const REMINDER_NOTIFICATION_VISIBLE_STATUS_SHOWING As Integer = 1

    Public Const REMINDER_STATUS_NONE As String = "none"
    Public Const REMINDER_STATUS_RUNNING As String = "running"
    Public Const REMINDER_STATUS_NOT_RUNNING As String = "not running"

    Public Const COL_REMINDER_ID As String = "reminder_id"
    Public Const COL_REMINDER_TYPE As String = "reminder_type"
    Public Const COL_REMINDER_REPEAT_MAX As String = "reminder_repeat_max"
    Public Const COL_REMINDER_REPEAT_ELAPSED As String = "reminder_repeat_elapsed"
    Public Const COL_REMINDER_STATUS As String = "reminder_status"
    Public Const COL_REMINDER_INTERVAL As String = "reminder_interval"
    Public Const COL_REMINDER_SPECIFIC_TIME As String = "reminder_specific_time"
    Public Const COL_REMINDER_DAILY As String = "reminder_daily"
    Public Const COL_REMINDER_CREATED_TIME As String = "reminder_created_time"
    Public Const COL_REMINDER_UPDATED_TIME As String = "reminder_updated_time"
    Public Const COL_REMINDER_DELETED_TIME As String = "reminder_deleted_time"
    Public Const COL_REMINDER_STARTED_TIME As String = "reminder_started_time"
    Public Const COL_REMINDER_NOTIFIED_TIME As String = "reminder_notified_time"
    Public Const COL_REMINDER_NEXT_NOTIFY_TIME As String = "reminder_next_notify_time"
    Public Const COL_NOTIFICATION_DURATION As String = "notification_duration"
    Public Const COL_NOTIFICATION_SOUND As String = "notification_sound"
    Public Const COL_NOTIFICATION_MESSAGE As String = "notification_message"
    Public Const COL_NOTIFICATION_FONT As String = "notification_font"
    Public Const COL_NOTIFICATION_BACKCOLOR As String = "notification_backcolor"
    Public Const COL_NOTIFICATION_FORECOLOR As String = "notification_forecolor"
    Public Const COL_NOTIFICATION_META_FORECOLOR As String = "notification_meta_forecolor"
    Public Const COL_NOTIFICATION_WIDTH As String = "notification_width"
    Public Const COL_NOTIFICATION_HEIGHT As String = "notification_height"

    Public Const STORAGE_REMINDER_OPERATION As Integer = 0
    Public Const STORAGE_REMINDER_HISTORY_OPERATION As Integer = 1

    Public Const HOURS_MILLISECONDS_CONVERTER As Double = 60 * 60 * 1000
    Public Const MINUTES_MILLISECONDS_CONVERTER As Double = 60 * 1000
    Public Const SECONDS_MILLISECONDS_CONVERTER As Double = 1000

    Public Const HOURS_SECONDS_CONVERTER As Double = 60 * 60
    Public Const MINUTES_SECONDS_CONVERTER As Double = 60

    Public Const REMINDER_INTERVAL_MINIMUM_LIMIT_SECONDS As Double = 5

    Public Const REMINDER_ID_NONE As Integer = -1

    Public Const NOTIFICATION_GAP_OFFSET As Integer = 10

    Public gVisibleNotifications As New List(Of ReminderNotification)

    Public gSumOfNotificationHeights As Integer = 0

    Private BUTTON_FOCUSED_OFFSET As Integer = 20

    Public ReadOnly indexToDaysMap As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) From {{1, "Mon"}, {2, "Tue"}, {3, "Wed"}, {4, "Thu"}, {5, "Fri"}, {6, "Sat"}, {7, "Sun"}}
    Public ReadOnly daysToIndexMap As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) From {{"Mon", 1}, {"Tue", 2}, {"Wed", 3}, {"Thu", 4}, {"Fri", 5}, {"Sat", 6}, {"Sun", 7}}

    Public gButtonsMap As New Dictionary(Of PictureBox, ButtonAppearanceDetails)

    Class ButtonAppearanceDetails
        Public defaultSize As Size
        Public focusedSize As Size
        Sub New(size As Size)
            defaultSize = size
            focusedSize = New Size(size.Width + BUTTON_FOCUSED_OFFSET, size.Height + BUTTON_FOCUSED_OFFSET)
        End Sub
    End Class

    Public Function getFontObjFromDisplayFormat(fontDisplayString As String) As Font
        Dim typeConverter As TypeConverter = TypeDescriptor.GetConverter(GetType(Font))
        Dim cultureInfo As CultureInfo = CultureInfo.CurrentUICulture
        Dim fontObject As Font = DirectCast(typeConverter.ConvertFromString(Nothing, System.Globalization.CultureInfo.CreateSpecificCulture(cultureInfo.ToString), fontDisplayString), Font)

        Return fontObject
    End Function

    Public Function getFormattedIntervalFromMilliseconds(milliseconds As Double) As String
        Dim hours As Integer = Math.Floor(milliseconds / HOURS_MILLISECONDS_CONVERTER)
        milliseconds = milliseconds Mod HOURS_MILLISECONDS_CONVERTER
        Dim minutes As Integer = Math.Floor(milliseconds / MINUTES_MILLISECONDS_CONVERTER)
        milliseconds = milliseconds Mod MINUTES_MILLISECONDS_CONVERTER
        Dim seconds As Integer = Math.Floor(milliseconds / SECONDS_MILLISECONDS_CONVERTER)

        Return getFormattedInterval(hours, minutes, seconds)
    End Function

    Public Function getFormattedIntervalFromSeconds(seconds As Double) As String
        Dim hours As Integer = Math.Floor(seconds / HOURS_SECONDS_CONVERTER)
        seconds = seconds Mod HOURS_SECONDS_CONVERTER
        Dim minutes As Integer = Math.Floor(seconds / MINUTES_SECONDS_CONVERTER)
        seconds = seconds Mod MINUTES_SECONDS_CONVERTER

        Return getFormattedInterval(hours, minutes, seconds)
    End Function

    Public Function getFormattedInterval(hours As Integer, minutes As Integer, seconds As Integer) As String
        Return hours.ToString("00") + " hrs, " + minutes.ToString("00") + " mins, " + seconds.ToString("00") + " secs"
    End Function

    Public Function convertTimeToSeconds(hours As Integer, minutes As Integer, seconds As Integer) As Double
        Return hours * HOURS_SECONDS_CONVERTER + minutes * MINUTES_SECONDS_CONVERTER + seconds
    End Function

    Public Function convertTimeToMilliseconds(hours As Integer, minutes As Integer, seconds As Integer) As Double
        Return hours * HOURS_MILLISECONDS_CONVERTER + minutes * MINUTES_MILLISECONDS_CONVERTER + seconds * SECONDS_MILLISECONDS_CONVERTER
    End Function

    Public Function convertMilliSecondsToSeconds(milliseconds As Double) As Double
        Return milliseconds / SECONDS_MILLISECONDS_CONVERTER
    End Function

    Public Function convertFormattedIntervalToMilliseconds(ByVal formattedInterval As String) As Double
        formattedInterval = formattedInterval.Replace("hrs", "").Replace("mins", "").Replace("secs", "").Replace(" ", "")
        Dim timeArray = formattedInterval.Split(",")

        Dim hours As Integer = Integer.Parse(timeArray(0))
        Dim minutes As Integer = Integer.Parse(timeArray(1))
        Dim seconds As Integer = Integer.Parse(timeArray(2))

        Return convertTimeToMilliseconds(hours, minutes, seconds)
    End Function

    Public Function convertFormattedIntervalToSeconds(ByVal formattedInterval As String) As Double
        formattedInterval = formattedInterval.Replace("hrs", "").Replace("mins", "").Replace("secs", "").Replace(" ", "")
        Dim timeArray = formattedInterval.Split(",")

        Dim hours As Integer = Integer.Parse(timeArray(0))
        Dim minutes As Integer = Integer.Parse(timeArray(1))
        Dim seconds As Integer = Integer.Parse(timeArray(2))

        Return convertTimeToSeconds(hours, minutes, seconds)
    End Function

    Public Function getFontInDisplayFormat(myFont As Font) As String
        Dim fontFamilyName As String = myFont.FontFamily.GetName(0).ToString
        Dim fontSize As String = myFont.Size.ToString
        Dim fontStyle As String = myFont.Style.ToString

        Return fontFamilyName + ", " + fontSize + "pt, style=" + fontStyle
    End Function


    Public Sub setDataGrid(lDataGridView As DataGridView, lDataTable As DataTable)
        Dim lBindingSource As New BindingSource()
        lBindingSource.DataSource = lDataTable
        lDataGridView.DataSource = lBindingSource
        lDataGridView.ClearSelection()
        If lDataTable.Rows.Count > 0 Then
            ''lDataGridView.FirstDisplayedScrollingRowIndex = lDataTable.Rows.Count - 1
            lDataGridView.FirstDisplayedScrollingRowIndex = 0
        End If
    End Sub

    Sub clearDataSet(lDataGridView As DataGridView)
        Dim lDataBindingSource As BindingSource = lDataGridView.DataSource
        If lDataBindingSource Is Nothing Then
            Return
        End If
        Dim lDataTableFromBinding As DataTable = lDataBindingSource.DataSource
        lDataTableFromBinding.Rows.Clear()
    End Sub

    Public Function getHoursFromTotalMilliseconds(milliseconds As Double) As Integer
        Return Math.Floor(milliseconds / HOURS_MILLISECONDS_CONVERTER)
    End Function

    Public Function getMinutesFromTotalMilliseconds(milliseconds As Double) As Integer
        Return Math.Floor((milliseconds Mod HOURS_MILLISECONDS_CONVERTER) / MINUTES_MILLISECONDS_CONVERTER)
    End Function

    Public Function getSecondsFromTotalMilliseconds(milliseconds As Double) As Integer
        Return Math.Floor(((milliseconds Mod HOURS_MILLISECONDS_CONVERTER) Mod MINUTES_MILLISECONDS_CONVERTER) / SECONDS_MILLISECONDS_CONVERTER)
    End Function

    Public Function getHoursFromTotalSeconds(seconds As Double) As Integer
        Return Math.Floor(seconds / HOURS_SECONDS_CONVERTER)
    End Function

    Public Function getMinutesFromTotalSeconds(seconds As Double) As Integer
        Return Math.Floor((seconds Mod HOURS_SECONDS_CONVERTER) / MINUTES_SECONDS_CONVERTER)
    End Function

    Public Function getSecondsFromTotalSeconds(seconds As Double) As Integer
        Return ((seconds Mod HOURS_SECONDS_CONVERTER) Mod MINUTES_SECONDS_CONVERTER)
    End Function

    Public Sub updateVisibleNotificationPositions()

        Dim sumOfNotificationsHeight As Integer = 0
        For Each notificationForm As ReminderNotification In gVisibleNotifications
            sumOfNotificationsHeight += notificationForm.Height + NOTIFICATION_GAP_OFFSET
            Dim yPosition As Integer = Screen.PrimaryScreen.WorkingArea.Height - sumOfNotificationsHeight
            notificationForm.Location = New Point(notificationForm.Location.X, yPosition)
        Next

    End Sub

    Public Function getVisibleNotificationsTotalHeight() As Integer

        Dim sumOfNotificationsHeight As Integer = 0

        For Each notificationForm As ReminderNotification In gVisibleNotifications
            sumOfNotificationsHeight += notificationForm.Height + NOTIFICATION_GAP_OFFSET
        Next

        Return sumOfNotificationsHeight

    End Function

    Public Sub addButtonAppearnceEventHandlers(buttonsList As List(Of PictureBox))
        For Each button As PictureBox In buttonsList
            AddHandler button.MouseEnter, AddressOf onButtonMouseEnter
            AddHandler button.MouseUp, AddressOf onButtonMouseUp
            AddHandler button.MouseLeave, AddressOf onButtonMouseLeave
            AddHandler button.MouseDown, AddressOf onButtonMouseDown
            gButtonsMap(button) = New ButtonAppearanceDetails(button.Size)
        Next
    End Sub

    Private Sub onButtonMouseEnter(sender As Object, e As EventArgs)
        Dim buttonAppreanceDetails As ButtonAppearanceDetails = gButtonsMap(sender)
        If sender.Size <> buttonAppreanceDetails.focusedSize Then
            sender.Size = buttonAppreanceDetails.focusedSize
            setButtonLocation(sender, BUTTON_FOCUSED_OFFSET)
        End If
    End Sub

    Private Sub onButtonMouseUp(sender As Object, e As MouseEventArgs)
        Dim buttonAppreanceDetails As ButtonAppearanceDetails = gButtonsMap(sender)
        If sender.Size <> buttonAppreanceDetails.focusedSize AndAlso sender.ClientRectangle.Contains(sender.PointToClient(Control.MousePosition)) Then
            sender.Size = buttonAppreanceDetails.focusedSize
            setButtonLocation(sender, BUTTON_FOCUSED_OFFSET)
        End If
    End Sub

    Private Sub onButtonMouseLeave(sender As Object, e As EventArgs)
        showNormalButtonAppearance(sender, e)
    End Sub

    Private Sub onButtonMouseDown(sender As Object, e As MouseEventArgs)
        showNormalButtonAppearance(sender, e)
    End Sub


    Private Sub showNormalButtonAppearance(sender As Object, e As EventArgs)
        Dim buttonAppreanceDetails As ButtonAppearanceDetails = gButtonsMap(sender)
        If sender.Size <> buttonAppreanceDetails.defaultSize Then
            sender.Size = buttonAppreanceDetails.defaultSize
            setButtonLocation(sender, BUTTON_FOCUSED_OFFSET * -1)
        End If
    End Sub

    'Private Sub showFocusedButtonAppearance(sender As Object, e As EventArgs)
    '    Dim buttonAppreanceDetails As ButtonAppearanceDetails = gButtonsMap(sender)
    '    If sender.Size <> buttonAppreanceDetails.focusedSize Then
    '        sender.Size = buttonAppreanceDetails.focusedSize
    '        setButtonLocation(sender, BUTTON_FOCUSED_OFFSET)
    '    End If
    'End Sub

    Public Sub setButtonLocation(button As Object, offset As Integer)
        button.Location = New Point(button.Location.X + ((offset / 2) * -1), button.Location.Y + ((offset / 2) * -1))
    End Sub

End Module
