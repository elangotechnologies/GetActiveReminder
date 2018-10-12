<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemindersHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgReminderHistoryDetails = New System.Windows.Forms.DataGridView()
        Me.colReminderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderCreateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderLastUpdatedTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderLastDeletedTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderRepeatMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderRepeatElapsed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIntervalDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIntervalDaily = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderSpecificTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderLastNotifiedTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderNextNotifyTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationSound = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationMessage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationFont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationBackColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationForeColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationHeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgReminderHistoryDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgReminderHistoryDetails
        '
        Me.dgReminderHistoryDetails.AllowUserToAddRows = False
        Me.dgReminderHistoryDetails.AllowUserToDeleteRows = False
        Me.dgReminderHistoryDetails.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgReminderHistoryDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgReminderHistoryDetails.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.dgReminderHistoryDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgReminderHistoryDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgReminderHistoryDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReminderHistoryDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgReminderHistoryDetails.ColumnHeadersHeight = 65
        Me.dgReminderHistoryDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReminderId, Me.colReminderType, Me.colReminderCreateTime, Me.colReminderLastUpdatedTime, Me.colReminderLastDeletedTime, Me.colReminderRepeatMax, Me.colReminderRepeatElapsed, Me.colReminderStatus, Me.colIntervalDuration, Me.colIntervalDaily, Me.colReminderSpecificTime, Me.colReminderStartTime, Me.colReminderLastNotifiedTime, Me.colReminderNextNotifyTime, Me.colNotificationDuration, Me.colNotificationSound, Me.colNotificationMessage, Me.colNotificationFont, Me.colNotificationBackColor, Me.colNotificationForeColor, Me.colNotificationWidth, Me.colNotificationHeight})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReminderHistoryDetails.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgReminderHistoryDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReminderHistoryDetails.EnableHeadersVisualStyles = False
        Me.dgReminderHistoryDetails.GridColor = System.Drawing.Color.DarkGray
        Me.dgReminderHistoryDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgReminderHistoryDetails.MultiSelect = False
        Me.dgReminderHistoryDetails.Name = "dgReminderHistoryDetails"
        Me.dgReminderHistoryDetails.ReadOnly = True
        Me.dgReminderHistoryDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReminderHistoryDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgReminderHistoryDetails.RowHeadersVisible = False
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Teal
        Me.dgReminderHistoryDetails.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgReminderHistoryDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReminderHistoryDetails.Size = New System.Drawing.Size(1710, 833)
        Me.dgReminderHistoryDetails.TabIndex = 34
        '
        'colReminderId
        '
        Me.colReminderId.DataPropertyName = "reminder_id"
        Me.colReminderId.Frozen = True
        Me.colReminderId.HeaderText = "Id"
        Me.colReminderId.Name = "colReminderId"
        Me.colReminderId.ReadOnly = True
        Me.colReminderId.Width = 50
        '
        'colReminderType
        '
        Me.colReminderType.DataPropertyName = "reminder_type"
        Me.colReminderType.Frozen = True
        Me.colReminderType.HeaderText = "Type"
        Me.colReminderType.Name = "colReminderType"
        Me.colReminderType.ReadOnly = True
        '
        'colReminderCreateTime
        '
        Me.colReminderCreateTime.DataPropertyName = "reminder_created_time"
        DataGridViewCellStyle3.Format = "dd-MMM-yy hh:mm:ss tt"
        DataGridViewCellStyle3.NullValue = "none"
        Me.colReminderCreateTime.DefaultCellStyle = DataGridViewCellStyle3
        Me.colReminderCreateTime.HeaderText = "Created"
        Me.colReminderCreateTime.Name = "colReminderCreateTime"
        Me.colReminderCreateTime.ReadOnly = True
        Me.colReminderCreateTime.Width = 165
        '
        'colReminderLastUpdatedTime
        '
        Me.colReminderLastUpdatedTime.DataPropertyName = "reminder_updated_time"
        DataGridViewCellStyle4.Format = "dd-MMM-yy hh:mm:ss tt"
        DataGridViewCellStyle4.NullValue = "none"
        Me.colReminderLastUpdatedTime.DefaultCellStyle = DataGridViewCellStyle4
        Me.colReminderLastUpdatedTime.HeaderText = "Updated"
        Me.colReminderLastUpdatedTime.Name = "colReminderLastUpdatedTime"
        Me.colReminderLastUpdatedTime.ReadOnly = True
        Me.colReminderLastUpdatedTime.Width = 165
        '
        'colReminderLastDeletedTime
        '
        Me.colReminderLastDeletedTime.DataPropertyName = "reminder_deleted_time"
        DataGridViewCellStyle5.Format = "dd-MMM-yy hh:mm:ss tt"
        DataGridViewCellStyle5.NullValue = "none"
        Me.colReminderLastDeletedTime.DefaultCellStyle = DataGridViewCellStyle5
        Me.colReminderLastDeletedTime.HeaderText = "Deleted"
        Me.colReminderLastDeletedTime.Name = "colReminderLastDeletedTime"
        Me.colReminderLastDeletedTime.ReadOnly = True
        Me.colReminderLastDeletedTime.Width = 165
        '
        'colReminderRepeatMax
        '
        Me.colReminderRepeatMax.DataPropertyName = "reminder_repeat_max"
        Me.colReminderRepeatMax.HeaderText = "Repeat"
        Me.colReminderRepeatMax.Name = "colReminderRepeatMax"
        Me.colReminderRepeatMax.ReadOnly = True
        '
        'colReminderRepeatElapsed
        '
        Me.colReminderRepeatElapsed.DataPropertyName = "reminder_repeat_elapsed"
        Me.colReminderRepeatElapsed.HeaderText = "Repeated"
        Me.colReminderRepeatElapsed.Name = "colReminderRepeatElapsed"
        Me.colReminderRepeatElapsed.ReadOnly = True
        '
        'colReminderStatus
        '
        Me.colReminderStatus.DataPropertyName = "reminder_status"
        Me.colReminderStatus.HeaderText = "Status"
        Me.colReminderStatus.Name = "colReminderStatus"
        Me.colReminderStatus.ReadOnly = True
        Me.colReminderStatus.Width = 90
        '
        'colIntervalDuration
        '
        Me.colIntervalDuration.DataPropertyName = "reminder_interval"
        DataGridViewCellStyle6.NullValue = "none"
        Me.colIntervalDuration.DefaultCellStyle = DataGridViewCellStyle6
        Me.colIntervalDuration.HeaderText = "Interval"
        Me.colIntervalDuration.Name = "colIntervalDuration"
        Me.colIntervalDuration.ReadOnly = True
        Me.colIntervalDuration.Width = 170
        '
        'colIntervalDaily
        '
        Me.colIntervalDaily.DataPropertyName = "reminder_daily"
        Me.colIntervalDaily.HeaderText = "Daily"
        Me.colIntervalDaily.Name = "colIntervalDaily"
        Me.colIntervalDaily.ReadOnly = True
        Me.colIntervalDaily.Width = 280
        '
        'colReminderSpecificTime
        '
        Me.colReminderSpecificTime.DataPropertyName = "reminder_specific_time"
        DataGridViewCellStyle7.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle7.NullValue = "none"
        Me.colReminderSpecificTime.DefaultCellStyle = DataGridViewCellStyle7
        Me.colReminderSpecificTime.HeaderText = "Specific"
        Me.colReminderSpecificTime.Name = "colReminderSpecificTime"
        Me.colReminderSpecificTime.ReadOnly = True
        Me.colReminderSpecificTime.Width = 165
        '
        'colReminderStartTime
        '
        Me.colReminderStartTime.DataPropertyName = "reminder_started_time"
        DataGridViewCellStyle8.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle8.NullValue = "none"
        Me.colReminderStartTime.DefaultCellStyle = DataGridViewCellStyle8
        Me.colReminderStartTime.HeaderText = "Started"
        Me.colReminderStartTime.Name = "colReminderStartTime"
        Me.colReminderStartTime.ReadOnly = True
        Me.colReminderStartTime.Width = 165
        '
        'colReminderLastNotifiedTime
        '
        Me.colReminderLastNotifiedTime.DataPropertyName = "reminder_notified_time"
        DataGridViewCellStyle9.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle9.NullValue = "none"
        Me.colReminderLastNotifiedTime.DefaultCellStyle = DataGridViewCellStyle9
        Me.colReminderLastNotifiedTime.HeaderText = "Notified"
        Me.colReminderLastNotifiedTime.Name = "colReminderLastNotifiedTime"
        Me.colReminderLastNotifiedTime.ReadOnly = True
        Me.colReminderLastNotifiedTime.Width = 165
        '
        'colReminderNextNotifyTime
        '
        Me.colReminderNextNotifyTime.DataPropertyName = "reminder_next_notify_time"
        DataGridViewCellStyle10.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle10.NullValue = "none"
        Me.colReminderNextNotifyTime.DefaultCellStyle = DataGridViewCellStyle10
        Me.colReminderNextNotifyTime.HeaderText = "Next Notify"
        Me.colReminderNextNotifyTime.Name = "colReminderNextNotifyTime"
        Me.colReminderNextNotifyTime.ReadOnly = True
        Me.colReminderNextNotifyTime.Width = 165
        '
        'colNotificationDuration
        '
        Me.colNotificationDuration.DataPropertyName = "notification_duration"
        DataGridViewCellStyle11.Format = "0 secs"
        DataGridViewCellStyle11.NullValue = "0 secs"
        Me.colNotificationDuration.DefaultCellStyle = DataGridViewCellStyle11
        Me.colNotificationDuration.HeaderText = "Notification Duration"
        Me.colNotificationDuration.Name = "colNotificationDuration"
        Me.colNotificationDuration.ReadOnly = True
        Me.colNotificationDuration.Width = 90
        '
        'colNotificationSound
        '
        Me.colNotificationSound.DataPropertyName = "notification_sound"
        Me.colNotificationSound.HeaderText = "Notification Sound"
        Me.colNotificationSound.Name = "colNotificationSound"
        Me.colNotificationSound.ReadOnly = True
        '
        'colNotificationMessage
        '
        Me.colNotificationMessage.DataPropertyName = "notification_message"
        Me.colNotificationMessage.HeaderText = "Notification Message"
        Me.colNotificationMessage.Name = "colNotificationMessage"
        Me.colNotificationMessage.ReadOnly = True
        Me.colNotificationMessage.Width = 200
        '
        'colNotificationFont
        '
        Me.colNotificationFont.DataPropertyName = "notification_font"
        Me.colNotificationFont.HeaderText = "Notification Font"
        Me.colNotificationFont.Name = "colNotificationFont"
        Me.colNotificationFont.ReadOnly = True
        '
        'colNotificationBackColor
        '
        Me.colNotificationBackColor.DataPropertyName = "notification_backcolor"
        Me.colNotificationBackColor.HeaderText = "Notification BackColor"
        Me.colNotificationBackColor.Name = "colNotificationBackColor"
        Me.colNotificationBackColor.ReadOnly = True
        Me.colNotificationBackColor.Width = 90
        '
        'colNotificationForeColor
        '
        Me.colNotificationForeColor.DataPropertyName = "notification_forecolor"
        Me.colNotificationForeColor.HeaderText = "Notification ForeColor"
        Me.colNotificationForeColor.Name = "colNotificationForeColor"
        Me.colNotificationForeColor.ReadOnly = True
        Me.colNotificationForeColor.Width = 90
        '
        'colNotificationWidth
        '
        Me.colNotificationWidth.DataPropertyName = "notification_width"
        Me.colNotificationWidth.HeaderText = "Notification Width"
        Me.colNotificationWidth.Name = "colNotificationWidth"
        Me.colNotificationWidth.ReadOnly = True
        Me.colNotificationWidth.Width = 90
        '
        'colNotificationHeight
        '
        Me.colNotificationHeight.DataPropertyName = "notification_height"
        Me.colNotificationHeight.HeaderText = "Notification Height"
        Me.colNotificationHeight.Name = "colNotificationHeight"
        Me.colNotificationHeight.ReadOnly = True
        Me.colNotificationHeight.Width = 90
        '
        'RemindersHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1710, 833)
        Me.Controls.Add(Me.dgReminderHistoryDetails)
        Me.KeyPreview = True
        Me.Name = "RemindersHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reminders History"
        CType(Me.dgReminderHistoryDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgReminderHistoryDetails As DataGridView
    Friend WithEvents colReminderId As DataGridViewTextBoxColumn
    Friend WithEvents colReminderType As DataGridViewTextBoxColumn
    Friend WithEvents colReminderCreateTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderLastUpdatedTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderLastDeletedTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderRepeatMax As DataGridViewTextBoxColumn
    Friend WithEvents colReminderRepeatElapsed As DataGridViewTextBoxColumn
    Friend WithEvents colReminderStatus As DataGridViewTextBoxColumn
    Friend WithEvents colIntervalDuration As DataGridViewTextBoxColumn
    Friend WithEvents colIntervalDaily As DataGridViewTextBoxColumn
    Friend WithEvents colReminderSpecificTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderStartTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderLastNotifiedTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderNextNotifyTime As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationDuration As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationSound As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationMessage As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationFont As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationBackColor As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationForeColor As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationWidth As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationHeight As DataGridViewTextBoxColumn
End Class
