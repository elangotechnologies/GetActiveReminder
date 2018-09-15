
Imports TakeABreakReminder

<Serializable()>
Public Class Reminder
    Private _type As Integer
    Private _startedTime As DateTime
    Private _durationHours As Integer
    Private _durationMinutes As Integer
    Private _durationSeconds As Integer
    Private _notification As Notification

    Public Sub New(type As Integer)
        _type = type
    End Sub

    Public Sub New(type As Integer, durationHours As Integer, durationMinutes As Integer, durationSeconds As Integer)
        _type = type
        _durationHours = durationHours
        _durationMinutes = durationMinutes
        _durationSeconds = durationSeconds
    End Sub

    Public Property Type As Integer
        Get
            Return _type
        End Get
        Set(value As Integer)
            _type = value
        End Set
    End Property

    Public Property DurationHours As Integer
        Get
            Return _durationHours
        End Get
        Set(value As Integer)
            _durationHours = value
        End Set
    End Property

    Public Property DurationMinutes As Integer
        Get
            Return _durationMinutes
        End Get
        Set(value As Integer)
            _durationMinutes = value
        End Set
    End Property

    Public Property DurationSeconds As Integer
        Get
            Return _durationSeconds
        End Get
        Set(value As Integer)
            _durationSeconds = value
        End Set
    End Property

    Public Property StartedTime As Date
        Get
            Return _startedTime
        End Get
        Set(value As Date)
            _startedTime = value
        End Set
    End Property

    Private Property Notification1 As Notification
        Get
            Return _notification
        End Get
        Set(value As Notification)
            _notification = value
        End Set
    End Property

    Private Class Notification
        Private _notificationDuaration As Integer
        Private _notificationMessage As String
        Private _notificationFont As Font
        Private _notificationBackColor As Color
        Private _notificationForeColor As Color
        Private _notificationSound As String
        Private _notificationWidth As Integer
        Private _notificationHeight As Integer

        Public Property NotificationDuaration As Integer
            Get
                Return _notificationDuaration
            End Get
            Set(value As Integer)
                _notificationDuaration = value
            End Set
        End Property

        Public Property NotificationMessage As String
            Get
                Return _notificationMessage
            End Get
            Set(value As String)
                _notificationMessage = value
            End Set
        End Property

        Public Property NotificationFont As Font
            Get
                Return _notificationFont
            End Get
            Set(value As Font)
                _notificationFont = value
            End Set
        End Property

        Public Property NotificationBackColor As Color
            Get
                Return _notificationBackColor
            End Get
            Set(value As Color)
                _notificationBackColor = value
            End Set
        End Property

        Public Property NotificationForeColor As Color
            Get
                Return _notificationForeColor
            End Get
            Set(value As Color)
                _notificationForeColor = value
            End Set
        End Property

        Public Property NotificationSound As String
            Get
                Return _notificationSound
            End Get
            Set(value As String)
                _notificationSound = value
            End Set
        End Property

        Public Property NotificationWidth As Integer
            Get
                Return _notificationWidth
            End Get
            Set(value As Integer)
                _notificationWidth = value
            End Set
        End Property

        Public Property NotificationHeight As Integer
            Get
                Return _notificationHeight
            End Get
            Set(value As Integer)
                _notificationHeight = value
            End Set
        End Property
    End Class
End Class
