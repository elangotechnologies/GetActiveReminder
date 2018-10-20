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
        Me.reminder_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_created_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_updated_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_deleted_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_repeat_max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_repeat_elapsed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_interval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_daily = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_specific_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_started_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_notified_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_next_notify_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_sound = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_font = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_backcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_forecolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_meta_font = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_meta_forecolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notification_height = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dgReminderHistoryDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.reminder_id, Me.reminder_type, Me.reminder_created_time, Me.reminder_updated_time, Me.reminder_deleted_time, Me.reminder_repeat_max, Me.reminder_repeat_elapsed, Me.reminder_status, Me.reminder_interval, Me.reminder_daily, Me.reminder_specific_time, Me.reminder_started_time, Me.reminder_notified_time, Me.reminder_next_notify_time, Me.notification_duration, Me.notification_sound, Me.notification_message, Me.notification_font, Me.notification_backcolor, Me.notification_forecolor, Me.notification_meta_font, Me.notification_meta_forecolor, Me.notification_width, Me.notification_height})
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
        'reminder_id
        '
        Me.reminder_id.DataPropertyName = "reminder_id"
        Me.reminder_id.Frozen = True
        Me.reminder_id.HeaderText = "Id"
        Me.reminder_id.Name = "reminder_id"
        Me.reminder_id.ReadOnly = True
        Me.reminder_id.Width = 50
        '
        'reminder_type
        '
        Me.reminder_type.DataPropertyName = "reminder_type"
        Me.reminder_type.Frozen = True
        Me.reminder_type.HeaderText = "Type"
        Me.reminder_type.Name = "reminder_type"
        Me.reminder_type.ReadOnly = True
        '
        'reminder_created_time
        '
        Me.reminder_created_time.DataPropertyName = "reminder_created_time"
        DataGridViewCellStyle3.Format = "dd-MMM-yy hh:mm:ss tt"
        DataGridViewCellStyle3.NullValue = "none"
        Me.reminder_created_time.DefaultCellStyle = DataGridViewCellStyle3
        Me.reminder_created_time.HeaderText = "Created"
        Me.reminder_created_time.Name = "reminder_created_time"
        Me.reminder_created_time.ReadOnly = True
        Me.reminder_created_time.Width = 165
        '
        'reminder_updated_time
        '
        Me.reminder_updated_time.DataPropertyName = "reminder_updated_time"
        DataGridViewCellStyle4.Format = "dd-MMM-yy hh:mm:ss tt"
        DataGridViewCellStyle4.NullValue = "none"
        Me.reminder_updated_time.DefaultCellStyle = DataGridViewCellStyle4
        Me.reminder_updated_time.HeaderText = "Updated"
        Me.reminder_updated_time.Name = "reminder_updated_time"
        Me.reminder_updated_time.ReadOnly = True
        Me.reminder_updated_time.Width = 165
        '
        'reminder_deleted_time
        '
        Me.reminder_deleted_time.DataPropertyName = "reminder_deleted_time"
        DataGridViewCellStyle5.Format = "dd-MMM-yy hh:mm:ss tt"
        DataGridViewCellStyle5.NullValue = "none"
        Me.reminder_deleted_time.DefaultCellStyle = DataGridViewCellStyle5
        Me.reminder_deleted_time.HeaderText = "Deleted"
        Me.reminder_deleted_time.Name = "reminder_deleted_time"
        Me.reminder_deleted_time.ReadOnly = True
        Me.reminder_deleted_time.Width = 165
        '
        'reminder_repeat_max
        '
        Me.reminder_repeat_max.DataPropertyName = "reminder_repeat_max"
        Me.reminder_repeat_max.HeaderText = "Repeat"
        Me.reminder_repeat_max.Name = "reminder_repeat_max"
        Me.reminder_repeat_max.ReadOnly = True
        '
        'reminder_repeat_elapsed
        '
        Me.reminder_repeat_elapsed.DataPropertyName = "reminder_repeat_elapsed"
        Me.reminder_repeat_elapsed.HeaderText = "Repeated"
        Me.reminder_repeat_elapsed.Name = "reminder_repeat_elapsed"
        Me.reminder_repeat_elapsed.ReadOnly = True
        '
        'reminder_status
        '
        Me.reminder_status.DataPropertyName = "reminder_status"
        Me.reminder_status.HeaderText = "Status"
        Me.reminder_status.Name = "reminder_status"
        Me.reminder_status.ReadOnly = True
        Me.reminder_status.Width = 90
        '
        'reminder_interval
        '
        Me.reminder_interval.DataPropertyName = "reminder_interval"
        DataGridViewCellStyle6.NullValue = "none"
        Me.reminder_interval.DefaultCellStyle = DataGridViewCellStyle6
        Me.reminder_interval.HeaderText = "Interval"
        Me.reminder_interval.Name = "reminder_interval"
        Me.reminder_interval.ReadOnly = True
        Me.reminder_interval.Width = 170
        '
        'reminder_daily
        '
        Me.reminder_daily.DataPropertyName = "reminder_daily"
        Me.reminder_daily.HeaderText = "Daily"
        Me.reminder_daily.Name = "reminder_daily"
        Me.reminder_daily.ReadOnly = True
        Me.reminder_daily.Width = 280
        '
        'reminder_specific_time
        '
        Me.reminder_specific_time.DataPropertyName = "reminder_specific_time"
        DataGridViewCellStyle7.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle7.NullValue = "none"
        Me.reminder_specific_time.DefaultCellStyle = DataGridViewCellStyle7
        Me.reminder_specific_time.HeaderText = "Specific"
        Me.reminder_specific_time.Name = "reminder_specific_time"
        Me.reminder_specific_time.ReadOnly = True
        Me.reminder_specific_time.Width = 165
        '
        'reminder_started_time
        '
        Me.reminder_started_time.DataPropertyName = "reminder_started_time"
        DataGridViewCellStyle8.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle8.NullValue = "none"
        Me.reminder_started_time.DefaultCellStyle = DataGridViewCellStyle8
        Me.reminder_started_time.HeaderText = "Started"
        Me.reminder_started_time.Name = "reminder_started_time"
        Me.reminder_started_time.ReadOnly = True
        Me.reminder_started_time.Width = 165
        '
        'reminder_notified_time
        '
        Me.reminder_notified_time.DataPropertyName = "reminder_notified_time"
        DataGridViewCellStyle9.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle9.NullValue = "none"
        Me.reminder_notified_time.DefaultCellStyle = DataGridViewCellStyle9
        Me.reminder_notified_time.HeaderText = "Notified"
        Me.reminder_notified_time.Name = "reminder_notified_time"
        Me.reminder_notified_time.ReadOnly = True
        Me.reminder_notified_time.Width = 165
        '
        'reminder_next_notify_time
        '
        Me.reminder_next_notify_time.DataPropertyName = "reminder_next_notify_time"
        DataGridViewCellStyle10.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle10.NullValue = "none"
        Me.reminder_next_notify_time.DefaultCellStyle = DataGridViewCellStyle10
        Me.reminder_next_notify_time.HeaderText = "Next Notify"
        Me.reminder_next_notify_time.Name = "reminder_next_notify_time"
        Me.reminder_next_notify_time.ReadOnly = True
        Me.reminder_next_notify_time.Width = 165
        '
        'notification_duration
        '
        Me.notification_duration.DataPropertyName = "notification_duration"
        DataGridViewCellStyle11.Format = "0 secs"
        DataGridViewCellStyle11.NullValue = "0 secs"
        Me.notification_duration.DefaultCellStyle = DataGridViewCellStyle11
        Me.notification_duration.HeaderText = "Notification Duration"
        Me.notification_duration.Name = "notification_duration"
        Me.notification_duration.ReadOnly = True
        Me.notification_duration.Width = 90
        '
        'notification_sound
        '
        Me.notification_sound.DataPropertyName = "notification_sound"
        Me.notification_sound.HeaderText = "Notification Sound"
        Me.notification_sound.Name = "notification_sound"
        Me.notification_sound.ReadOnly = True
        '
        'notification_message
        '
        Me.notification_message.DataPropertyName = "notification_message"
        Me.notification_message.HeaderText = "Notification Message"
        Me.notification_message.Name = "notification_message"
        Me.notification_message.ReadOnly = True
        Me.notification_message.Width = 200
        '
        'notification_font
        '
        Me.notification_font.DataPropertyName = "notification_font"
        Me.notification_font.HeaderText = "Notification Font"
        Me.notification_font.Name = "notification_font"
        Me.notification_font.ReadOnly = True
        '
        'notification_backcolor
        '
        Me.notification_backcolor.DataPropertyName = "notification_backcolor"
        Me.notification_backcolor.HeaderText = "Notification BackColor"
        Me.notification_backcolor.Name = "notification_backcolor"
        Me.notification_backcolor.ReadOnly = True
        Me.notification_backcolor.Width = 90
        '
        'notification_forecolor
        '
        Me.notification_forecolor.DataPropertyName = "notification_forecolor"
        Me.notification_forecolor.HeaderText = "Notification ForeColor"
        Me.notification_forecolor.Name = "notification_forecolor"
        Me.notification_forecolor.ReadOnly = True
        Me.notification_forecolor.Width = 90
        '
        'notification_meta_font
        '
        Me.notification_meta_font.DataPropertyName = "notification_meta_font"
        Me.notification_meta_font.HeaderText = "Notification Info Font"
        Me.notification_meta_font.Name = "notification_meta_font"
        Me.notification_meta_font.ReadOnly = True
        '
        'notification_meta_forecolor
        '
        Me.notification_meta_forecolor.DataPropertyName = "notification_meta_forecolor"
        Me.notification_meta_forecolor.HeaderText = "Notification Info Color"
        Me.notification_meta_forecolor.Name = "notification_meta_forecolor"
        Me.notification_meta_forecolor.ReadOnly = True
        '
        'notification_width
        '
        Me.notification_width.DataPropertyName = "notification_width"
        Me.notification_width.HeaderText = "Notification Width"
        Me.notification_width.Name = "notification_width"
        Me.notification_width.ReadOnly = True
        Me.notification_width.Width = 90
        '
        'notification_height
        '
        Me.notification_height.DataPropertyName = "notification_height"
        Me.notification_height.HeaderText = "Notification Height"
        Me.notification_height.Name = "notification_height"
        Me.notification_height.ReadOnly = True
        Me.notification_height.Width = 90
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
    Friend WithEvents reminder_id As DataGridViewTextBoxColumn
    Friend WithEvents reminder_type As DataGridViewTextBoxColumn
    Friend WithEvents reminder_created_time As DataGridViewTextBoxColumn
    Friend WithEvents reminder_updated_time As DataGridViewTextBoxColumn
    Friend WithEvents reminder_deleted_time As DataGridViewTextBoxColumn
    Friend WithEvents reminder_repeat_max As DataGridViewTextBoxColumn
    Friend WithEvents reminder_repeat_elapsed As DataGridViewTextBoxColumn
    Friend WithEvents reminder_status As DataGridViewTextBoxColumn
    Friend WithEvents reminder_interval As DataGridViewTextBoxColumn
    Friend WithEvents reminder_daily As DataGridViewTextBoxColumn
    Friend WithEvents reminder_specific_time As DataGridViewTextBoxColumn
    Friend WithEvents reminder_started_time As DataGridViewTextBoxColumn
    Friend WithEvents reminder_notified_time As DataGridViewTextBoxColumn
    Friend WithEvents reminder_next_notify_time As DataGridViewTextBoxColumn
    Friend WithEvents notification_duration As DataGridViewTextBoxColumn
    Friend WithEvents notification_sound As DataGridViewTextBoxColumn
    Friend WithEvents notification_message As DataGridViewTextBoxColumn
    Friend WithEvents notification_font As DataGridViewTextBoxColumn
    Friend WithEvents notification_backcolor As DataGridViewTextBoxColumn
    Friend WithEvents notification_forecolor As DataGridViewTextBoxColumn
    Friend WithEvents notification_meta_font As DataGridViewTextBoxColumn
    Friend WithEvents notification_meta_forecolor As DataGridViewTextBoxColumn
    Friend WithEvents notification_width As DataGridViewTextBoxColumn
    Friend WithEvents notification_height As DataGridViewTextBoxColumn
End Class
