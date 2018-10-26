<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.statusLblTimerStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextMenuForTrayIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemShowApp = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblReminderStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssReminderStatusBar = New System.Windows.Forms.StatusStrip()
        Me.fontdialogNotificationFont = New System.Windows.Forms.FontDialog()
        Me.dgReminderDetails = New System.Windows.Forms.DataGridView()
        Me.reminder_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_repeat_max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_repeat_elapsed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_interval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_daily = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_specific_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_created_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_updated_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reminder_deleted_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.radReminderTypeSpecific = New System.Windows.Forms.RadioButton()
        Me.radReminderTypeDaily = New System.Windows.Forms.RadioButton()
        Me.radReminderTypeInterval = New System.Windows.Forms.RadioButton()
        Me.scMainContainer = New System.Windows.Forms.SplitContainer()
        Me.lblIconPlace6 = New System.Windows.Forms.Label()
        Me.btnCloneReminder = New System.Windows.Forms.PictureBox()
        Me.lblIconPlace5 = New System.Windows.Forms.Label()
        Me.lblIconPlace4 = New System.Windows.Forms.Label()
        Me.lblIconPlace3 = New System.Windows.Forms.Label()
        Me.lblIconPlace2 = New System.Windows.Forms.Label()
        Me.lblIconPlace1 = New System.Windows.Forms.Label()
        Me.btnEditReminder = New System.Windows.Forms.PictureBox()
        Me.btnAddReminder = New System.Windows.Forms.PictureBox()
        Me.btnClearScreen = New System.Windows.Forms.PictureBox()
        Me.btnStartStopReminder = New System.Windows.Forms.PictureBox()
        Me.btnDeleteReminder = New System.Windows.Forms.PictureBox()
        Me.scMainContentContainer = New System.Windows.Forms.SplitContainer()
        Me.panelReminderType = New System.Windows.Forms.Panel()
        Me.lblReminderTypeSpecific = New System.Windows.Forms.Label()
        Me.lblReminderTypeDaily = New System.Windows.Forms.Label()
        Me.lblReminderTypeInterval = New System.Windows.Forms.Label()
        Me.grpReminderType = New System.Windows.Forms.GroupBox()
        Me.panelReminderTypeContent = New System.Windows.Forms.Panel()
        Me.lblReminderTypeTip = New System.Windows.Forms.Label()
        Me.scContentContainer = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.scSubContentSpliter = New System.Windows.Forms.SplitContainer()
        Me.panelReminderTimeConfig = New System.Windows.Forms.Panel()
        Me.grpReminderTimeConfig = New System.Windows.Forms.GroupBox()
        Me.grpReminderTypeInterval = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.panelReminderTypeIntervalContent = New System.Windows.Forms.Panel()
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.numSeconds = New System.Windows.Forms.NumericUpDown()
        Me.numMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.grpRepeat = New System.Windows.Forms.GroupBox()
        Me.panelRepeatContent = New System.Windows.Forms.Panel()
        Me.numRepeat = New System.Windows.Forms.NumericUpDown()
        Me.reminderTimePlaceHolder = New System.Windows.Forms.GroupBox()
        Me.grpReminderTypeDaily = New System.Windows.Forms.GroupBox()
        Me.panelReminderTypeDailyContent = New System.Windows.Forms.Panel()
        Me.lvDaily = New System.Windows.Forms.CheckedListBox()
        Me.dtDailyTime = New System.Windows.Forms.DateTimePicker()
        Me.grpReminderTypeSpecific = New System.Windows.Forms.GroupBox()
        Me.panelReminderTypeSpecificContent = New System.Windows.Forms.Panel()
        Me.dtSpecific = New System.Windows.Forms.DateTimePicker()
        Me.lblReminderContentTipLeft = New System.Windows.Forms.Label()
        Me.panelNotificationSettings = New System.Windows.Forms.Panel()
        Me.grpNotificationSettings = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelNotificationSettingsContent = New System.Windows.Forms.Panel()
        Me.btnShowNotificationMetaFontDialog = New System.Windows.Forms.Button()
        Me.txtNotificaitonMetaFont = New System.Windows.Forms.RichTextBox()
        Me.colorPickerMetaForeColor = New ElaColorChooser.ElaColorPicker()
        Me.btnShowNotificationFontDialog = New System.Windows.Forms.Button()
        Me.numNotificationHeight = New System.Windows.Forms.NumericUpDown()
        Me.numNotificationWidth = New System.Windows.Forms.NumericUpDown()
        Me.cmbNotificationSound = New System.Windows.Forms.ComboBox()
        Me.btnPlaySound = New System.Windows.Forms.Button()
        Me.colorPickerForeColor = New ElaColorChooser.ElaColorPicker()
        Me.txtNotificationMessage = New System.Windows.Forms.RichTextBox()
        Me.colorPickerBackColor = New ElaColorChooser.ElaColorPicker()
        Me.cmbNotificationDuration = New System.Windows.Forms.ComboBox()
        Me.txtNotificaitonFont = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblReminderContentTipRight = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReminderHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShortcutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttIconTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttFieldInfoTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.contextMenuForTrayIcon.SuspendLayout()
        Me.ssReminderStatusBar.SuspendLayout()
        CType(Me.dgReminderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scMainContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMainContainer.Panel1.SuspendLayout()
        Me.scMainContainer.Panel2.SuspendLayout()
        Me.scMainContainer.SuspendLayout()
        CType(Me.btnCloneReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClearScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStartStopReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scMainContentContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMainContentContainer.Panel1.SuspendLayout()
        Me.scMainContentContainer.Panel2.SuspendLayout()
        Me.scMainContentContainer.SuspendLayout()
        Me.panelReminderType.SuspendLayout()
        Me.grpReminderType.SuspendLayout()
        Me.panelReminderTypeContent.SuspendLayout()
        CType(Me.scContentContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scContentContainer.Panel1.SuspendLayout()
        Me.scContentContainer.Panel2.SuspendLayout()
        Me.scContentContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.scSubContentSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scSubContentSpliter.Panel1.SuspendLayout()
        Me.scSubContentSpliter.Panel2.SuspendLayout()
        Me.scSubContentSpliter.SuspendLayout()
        Me.panelReminderTimeConfig.SuspendLayout()
        Me.grpReminderTimeConfig.SuspendLayout()
        Me.grpReminderTypeInterval.SuspendLayout()
        Me.panelReminderTypeIntervalContent.SuspendLayout()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRepeat.SuspendLayout()
        Me.panelRepeatContent.SuspendLayout()
        CType(Me.numRepeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReminderTypeDaily.SuspendLayout()
        Me.panelReminderTypeDailyContent.SuspendLayout()
        Me.grpReminderTypeSpecific.SuspendLayout()
        Me.panelReminderTypeSpecificContent.SuspendLayout()
        Me.panelNotificationSettings.SuspendLayout()
        Me.grpNotificationSettings.SuspendLayout()
        Me.panelNotificationSettingsContent.SuspendLayout()
        CType(Me.numNotificationHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNotificationWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusLblTimerStatus
        '
        Me.statusLblTimerStatus.Name = "statusLblTimerStatus"
        Me.statusLblTimerStatus.Size = New System.Drawing.Size(73, 17)
        Me.statusLblTimerStatus.Text = "Timer Status"
        '
        'trayIcon
        '
        Me.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.trayIcon.BalloonTipText = "RemindMe Application"
        Me.trayIcon.BalloonTipTitle = "RemindMe Application"
        Me.trayIcon.ContextMenuStrip = Me.contextMenuForTrayIcon
        Me.trayIcon.Icon = CType(resources.GetObject("trayIcon.Icon"), System.Drawing.Icon)
        Me.trayIcon.Text = "RemindMe Application"
        Me.trayIcon.Visible = True
        '
        'contextMenuForTrayIcon
        '
        Me.contextMenuForTrayIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemExit, Me.menuItemShowApp})
        Me.contextMenuForTrayIcon.Name = "ShowWindowToolStripMenuItem"
        Me.contextMenuForTrayIcon.Size = New System.Drawing.Size(168, 48)
        '
        'menuItemExit
        '
        Me.menuItemExit.Name = "menuItemExit"
        Me.menuItemExit.Size = New System.Drawing.Size(167, 22)
        Me.menuItemExit.Text = "Exit"
        '
        'menuItemShowApp
        '
        Me.menuItemShowApp.Name = "menuItemShowApp"
        Me.menuItemShowApp.Size = New System.Drawing.Size(167, 22)
        Me.menuItemShowApp.Text = "Show Application"
        '
        'lblReminderStatus
        '
        Me.lblReminderStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblReminderStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.lblReminderStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblReminderStatus.ForeColor = System.Drawing.Color.White
        Me.lblReminderStatus.Name = "lblReminderStatus"
        Me.lblReminderStatus.Size = New System.Drawing.Size(226, 25)
        Me.lblReminderStatus.Text = "Reminder not started yet"
        '
        'ssReminderStatusBar
        '
        Me.ssReminderStatusBar.BackColor = System.Drawing.Color.SteelBlue
        Me.ssReminderStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblReminderStatus})
        Me.ssReminderStatusBar.Location = New System.Drawing.Point(0, 932)
        Me.ssReminderStatusBar.Name = "ssReminderStatusBar"
        Me.ssReminderStatusBar.Size = New System.Drawing.Size(1533, 30)
        Me.ssReminderStatusBar.TabIndex = 7
        Me.ssReminderStatusBar.Text = "StatusStrip1"
        '
        'dgReminderDetails
        '
        Me.dgReminderDetails.AllowUserToAddRows = False
        Me.dgReminderDetails.AllowUserToDeleteRows = False
        Me.dgReminderDetails.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgReminderDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgReminderDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgReminderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgReminderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgReminderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReminderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgReminderDetails.ColumnHeadersHeight = 65
        Me.dgReminderDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.reminder_id, Me.reminder_type, Me.reminder_repeat_max, Me.reminder_repeat_elapsed, Me.reminder_status, Me.reminder_interval, Me.reminder_daily, Me.reminder_specific_time, Me.reminder_created_time, Me.reminder_updated_time, Me.reminder_deleted_time, Me.reminder_started_time, Me.reminder_notified_time, Me.reminder_next_notify_time, Me.notification_duration, Me.notification_sound, Me.notification_message, Me.notification_font, Me.notification_backcolor, Me.notification_forecolor, Me.notification_meta_font, Me.notification_meta_forecolor, Me.notification_width, Me.notification_height})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReminderDetails.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgReminderDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReminderDetails.EnableHeadersVisualStyles = False
        Me.dgReminderDetails.GridColor = System.Drawing.Color.DarkGray
        Me.dgReminderDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgReminderDetails.MultiSelect = False
        Me.dgReminderDetails.Name = "dgReminderDetails"
        Me.dgReminderDetails.ReadOnly = True
        Me.dgReminderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReminderDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgReminderDetails.RowHeadersVisible = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Teal
        Me.dgReminderDetails.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgReminderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReminderDetails.Size = New System.Drawing.Size(1438, 247)
        Me.dgReminderDetails.TabIndex = 0
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
        DataGridViewCellStyle3.NullValue = "none"
        Me.reminder_interval.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle4.NullValue = "none"
        Me.reminder_specific_time.DefaultCellStyle = DataGridViewCellStyle4
        Me.reminder_specific_time.HeaderText = "Specific"
        Me.reminder_specific_time.Name = "reminder_specific_time"
        Me.reminder_specific_time.ReadOnly = True
        Me.reminder_specific_time.Width = 165
        '
        'reminder_created_time
        '
        Me.reminder_created_time.DataPropertyName = "reminder_created_time"
        DataGridViewCellStyle5.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle5.NullValue = "none"
        Me.reminder_created_time.DefaultCellStyle = DataGridViewCellStyle5
        Me.reminder_created_time.HeaderText = "Created"
        Me.reminder_created_time.Name = "reminder_created_time"
        Me.reminder_created_time.ReadOnly = True
        Me.reminder_created_time.Visible = False
        Me.reminder_created_time.Width = 165
        '
        'reminder_updated_time
        '
        Me.reminder_updated_time.DataPropertyName = "reminder_updated_time"
        DataGridViewCellStyle6.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle6.NullValue = "none"
        Me.reminder_updated_time.DefaultCellStyle = DataGridViewCellStyle6
        Me.reminder_updated_time.HeaderText = "Updated"
        Me.reminder_updated_time.Name = "reminder_updated_time"
        Me.reminder_updated_time.ReadOnly = True
        Me.reminder_updated_time.Visible = False
        Me.reminder_updated_time.Width = 165
        '
        'reminder_deleted_time
        '
        Me.reminder_deleted_time.DataPropertyName = "reminder_deleted_time"
        Me.reminder_deleted_time.HeaderText = "Deleted"
        Me.reminder_deleted_time.Name = "reminder_deleted_time"
        Me.reminder_deleted_time.ReadOnly = True
        Me.reminder_deleted_time.Visible = False
        '
        'reminder_started_time
        '
        Me.reminder_started_time.DataPropertyName = "reminder_started_time"
        DataGridViewCellStyle7.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle7.NullValue = "none"
        Me.reminder_started_time.DefaultCellStyle = DataGridViewCellStyle7
        Me.reminder_started_time.HeaderText = "Started"
        Me.reminder_started_time.Name = "reminder_started_time"
        Me.reminder_started_time.ReadOnly = True
        Me.reminder_started_time.Width = 165
        '
        'reminder_notified_time
        '
        Me.reminder_notified_time.DataPropertyName = "reminder_notified_time"
        DataGridViewCellStyle8.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle8.NullValue = "none"
        Me.reminder_notified_time.DefaultCellStyle = DataGridViewCellStyle8
        Me.reminder_notified_time.HeaderText = "Notified"
        Me.reminder_notified_time.Name = "reminder_notified_time"
        Me.reminder_notified_time.ReadOnly = True
        Me.reminder_notified_time.Width = 165
        '
        'reminder_next_notify_time
        '
        Me.reminder_next_notify_time.DataPropertyName = "reminder_next_notify_time"
        DataGridViewCellStyle9.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle9.NullValue = "none"
        Me.reminder_next_notify_time.DefaultCellStyle = DataGridViewCellStyle9
        Me.reminder_next_notify_time.HeaderText = "Next Notify"
        Me.reminder_next_notify_time.Name = "reminder_next_notify_time"
        Me.reminder_next_notify_time.ReadOnly = True
        Me.reminder_next_notify_time.Width = 165
        '
        'notification_duration
        '
        Me.notification_duration.DataPropertyName = "notification_duration"
        DataGridViewCellStyle10.Format = "0 secs"
        DataGridViewCellStyle10.NullValue = "0 secs"
        Me.notification_duration.DefaultCellStyle = DataGridViewCellStyle10
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
        'radReminderTypeSpecific
        '
        Me.radReminderTypeSpecific.BackColor = System.Drawing.Color.Transparent
        Me.radReminderTypeSpecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radReminderTypeSpecific.Location = New System.Drawing.Point(311, 7)
        Me.radReminderTypeSpecific.Name = "radReminderTypeSpecific"
        Me.radReminderTypeSpecific.Size = New System.Drawing.Size(173, 24)
        Me.radReminderTypeSpecific.TabIndex = 2
        Me.radReminderTypeSpecific.Text = "Specific Date"
        Me.radReminderTypeSpecific.UseVisualStyleBackColor = False
        '
        'radReminderTypeDaily
        '
        Me.radReminderTypeDaily.BackColor = System.Drawing.Color.Transparent
        Me.radReminderTypeDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radReminderTypeDaily.Location = New System.Drawing.Point(185, 7)
        Me.radReminderTypeDaily.Name = "radReminderTypeDaily"
        Me.radReminderTypeDaily.Size = New System.Drawing.Size(112, 24)
        Me.radReminderTypeDaily.TabIndex = 1
        Me.radReminderTypeDaily.Text = "Daily"
        Me.radReminderTypeDaily.UseVisualStyleBackColor = False
        '
        'radReminderTypeInterval
        '
        Me.radReminderTypeInterval.BackColor = System.Drawing.Color.Transparent
        Me.radReminderTypeInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.radReminderTypeInterval.Location = New System.Drawing.Point(39, 7)
        Me.radReminderTypeInterval.Name = "radReminderTypeInterval"
        Me.radReminderTypeInterval.Size = New System.Drawing.Size(130, 24)
        Me.radReminderTypeInterval.TabIndex = 0
        Me.radReminderTypeInterval.Text = "Interval"
        Me.radReminderTypeInterval.UseVisualStyleBackColor = False
        '
        'scMainContainer
        '
        Me.scMainContainer.BackColor = System.Drawing.Color.Lavender
        Me.scMainContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.scMainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scMainContainer.Location = New System.Drawing.Point(0, 29)
        Me.scMainContainer.Name = "scMainContainer"
        '
        'scMainContainer.Panel1
        '
        Me.scMainContainer.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.scMainContainer.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scMainContainer.Panel1.Controls.Add(Me.lblIconPlace6)
        Me.scMainContainer.Panel1.Controls.Add(Me.btnCloneReminder)
        Me.scMainContainer.Panel1.Controls.Add(Me.lblIconPlace5)
        Me.scMainContainer.Panel1.Controls.Add(Me.lblIconPlace4)
        Me.scMainContainer.Panel1.Controls.Add(Me.lblIconPlace3)
        Me.scMainContainer.Panel1.Controls.Add(Me.lblIconPlace2)
        Me.scMainContainer.Panel1.Controls.Add(Me.lblIconPlace1)
        Me.scMainContainer.Panel1.Controls.Add(Me.btnEditReminder)
        Me.scMainContainer.Panel1.Controls.Add(Me.btnAddReminder)
        Me.scMainContainer.Panel1.Controls.Add(Me.btnClearScreen)
        Me.scMainContainer.Panel1.Controls.Add(Me.btnStartStopReminder)
        Me.scMainContainer.Panel1.Controls.Add(Me.btnDeleteReminder)
        '
        'scMainContainer.Panel2
        '
        Me.scMainContainer.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.scMainContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scMainContainer.Panel2.Controls.Add(Me.scMainContentContainer)
        Me.scMainContainer.Size = New System.Drawing.Size(1533, 903)
        Me.scMainContainer.SplitterDistance = 90
        Me.scMainContainer.SplitterWidth = 1
        Me.scMainContainer.TabIndex = 1
        '
        'lblIconPlace6
        '
        Me.lblIconPlace6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIconPlace6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIconPlace6.ForeColor = System.Drawing.Color.White
        Me.lblIconPlace6.Location = New System.Drawing.Point(19, 542)
        Me.lblIconPlace6.Name = "lblIconPlace6"
        Me.lblIconPlace6.Size = New System.Drawing.Size(51, 23)
        Me.lblIconPlace6.TabIndex = 52
        Me.lblIconPlace6.Text = "place6"
        Me.lblIconPlace6.Visible = False
        '
        'btnCloneReminder
        '
        Me.btnCloneReminder.BackColor = System.Drawing.Color.Transparent
        Me.btnCloneReminder.BackgroundImage = Global.RemindMe.My.Resources.Resources.clone
        Me.btnCloneReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCloneReminder.Location = New System.Drawing.Point(19, 568)
        Me.btnCloneReminder.Name = "btnCloneReminder"
        Me.btnCloneReminder.Size = New System.Drawing.Size(48, 48)
        Me.btnCloneReminder.TabIndex = 51
        Me.btnCloneReminder.TabStop = False
        Me.ttIconTooltip.SetToolTip(Me.btnCloneReminder, "Clone (Ctrl+L)")
        '
        'lblIconPlace5
        '
        Me.lblIconPlace5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIconPlace5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIconPlace5.ForeColor = System.Drawing.Color.White
        Me.lblIconPlace5.Location = New System.Drawing.Point(16, 450)
        Me.lblIconPlace5.Name = "lblIconPlace5"
        Me.lblIconPlace5.Size = New System.Drawing.Size(51, 23)
        Me.lblIconPlace5.TabIndex = 50
        Me.lblIconPlace5.Text = "place5"
        Me.lblIconPlace5.Visible = False
        '
        'lblIconPlace4
        '
        Me.lblIconPlace4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIconPlace4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIconPlace4.ForeColor = System.Drawing.Color.White
        Me.lblIconPlace4.Location = New System.Drawing.Point(16, 357)
        Me.lblIconPlace4.Name = "lblIconPlace4"
        Me.lblIconPlace4.Size = New System.Drawing.Size(51, 23)
        Me.lblIconPlace4.TabIndex = 49
        Me.lblIconPlace4.Text = "place4"
        Me.lblIconPlace4.Visible = False
        '
        'lblIconPlace3
        '
        Me.lblIconPlace3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIconPlace3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIconPlace3.ForeColor = System.Drawing.Color.White
        Me.lblIconPlace3.Location = New System.Drawing.Point(16, 264)
        Me.lblIconPlace3.Name = "lblIconPlace3"
        Me.lblIconPlace3.Size = New System.Drawing.Size(51, 23)
        Me.lblIconPlace3.TabIndex = 48
        Me.lblIconPlace3.Text = "place3"
        Me.lblIconPlace3.Visible = False
        '
        'lblIconPlace2
        '
        Me.lblIconPlace2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIconPlace2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIconPlace2.ForeColor = System.Drawing.Color.White
        Me.lblIconPlace2.Location = New System.Drawing.Point(16, 171)
        Me.lblIconPlace2.Name = "lblIconPlace2"
        Me.lblIconPlace2.Size = New System.Drawing.Size(51, 23)
        Me.lblIconPlace2.TabIndex = 47
        Me.lblIconPlace2.Text = "place2"
        Me.lblIconPlace2.Visible = False
        '
        'lblIconPlace1
        '
        Me.lblIconPlace1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIconPlace1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIconPlace1.ForeColor = System.Drawing.Color.White
        Me.lblIconPlace1.Location = New System.Drawing.Point(16, 78)
        Me.lblIconPlace1.Name = "lblIconPlace1"
        Me.lblIconPlace1.Size = New System.Drawing.Size(51, 23)
        Me.lblIconPlace1.TabIndex = 46
        Me.lblIconPlace1.Text = "place1"
        Me.lblIconPlace1.Visible = False
        '
        'btnEditReminder
        '
        Me.btnEditReminder.BackColor = System.Drawing.Color.Transparent
        Me.btnEditReminder.BackgroundImage = CType(resources.GetObject("btnEditReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnEditReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditReminder.Location = New System.Drawing.Point(19, 197)
        Me.btnEditReminder.Name = "btnEditReminder"
        Me.btnEditReminder.Size = New System.Drawing.Size(48, 48)
        Me.btnEditReminder.TabIndex = 45
        Me.btnEditReminder.TabStop = False
        Me.ttIconTooltip.SetToolTip(Me.btnEditReminder, "Edit (Ctrl+E)")
        '
        'btnAddReminder
        '
        Me.btnAddReminder.BackColor = System.Drawing.Color.Transparent
        Me.btnAddReminder.BackgroundImage = CType(resources.GetObject("btnAddReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnAddReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddReminder.Location = New System.Drawing.Point(19, 104)
        Me.btnAddReminder.Name = "btnAddReminder"
        Me.btnAddReminder.Size = New System.Drawing.Size(48, 48)
        Me.btnAddReminder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddReminder.TabIndex = 41
        Me.btnAddReminder.TabStop = False
        Me.ttIconTooltip.SetToolTip(Me.btnAddReminder, "New (Ctrl + N)")
        '
        'btnClearScreen
        '
        Me.btnClearScreen.BackColor = System.Drawing.Color.Transparent
        Me.btnClearScreen.BackgroundImage = CType(resources.GetObject("btnClearScreen.BackgroundImage"), System.Drawing.Image)
        Me.btnClearScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearScreen.Location = New System.Drawing.Point(19, 476)
        Me.btnClearScreen.Name = "btnClearScreen"
        Me.btnClearScreen.Size = New System.Drawing.Size(48, 48)
        Me.btnClearScreen.TabIndex = 42
        Me.btnClearScreen.TabStop = False
        Me.ttIconTooltip.SetToolTip(Me.btnClearScreen, "Clear (Esc)")
        '
        'btnStartStopReminder
        '
        Me.btnStartStopReminder.BackColor = System.Drawing.Color.Transparent
        Me.btnStartStopReminder.BackgroundImage = CType(resources.GetObject("btnStartStopReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnStartStopReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStartStopReminder.Location = New System.Drawing.Point(19, 290)
        Me.btnStartStopReminder.Name = "btnStartStopReminder"
        Me.btnStartStopReminder.Size = New System.Drawing.Size(48, 48)
        Me.btnStartStopReminder.TabIndex = 43
        Me.btnStartStopReminder.TabStop = False
        Me.ttIconTooltip.SetToolTip(Me.btnStartStopReminder, "Start (Ctrl+R)")
        '
        'btnDeleteReminder
        '
        Me.btnDeleteReminder.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteReminder.BackgroundImage = CType(resources.GetObject("btnDeleteReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteReminder.Location = New System.Drawing.Point(19, 383)
        Me.btnDeleteReminder.Name = "btnDeleteReminder"
        Me.btnDeleteReminder.Size = New System.Drawing.Size(48, 48)
        Me.btnDeleteReminder.TabIndex = 44
        Me.btnDeleteReminder.TabStop = False
        Me.ttIconTooltip.SetToolTip(Me.btnDeleteReminder, "Delete (Ctrl+D)")
        '
        'scMainContentContainer
        '
        Me.scMainContentContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMainContentContainer.Location = New System.Drawing.Point(0, 0)
        Me.scMainContentContainer.Name = "scMainContentContainer"
        Me.scMainContentContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMainContentContainer.Panel1
        '
        Me.scMainContentContainer.Panel1.Controls.Add(Me.panelReminderType)
        Me.scMainContentContainer.Panel1.Controls.Add(Me.lblReminderTypeTip)
        '
        'scMainContentContainer.Panel2
        '
        Me.scMainContentContainer.Panel2.Controls.Add(Me.scContentContainer)
        Me.scMainContentContainer.Size = New System.Drawing.Size(1438, 899)
        Me.scMainContentContainer.SplitterDistance = 93
        Me.scMainContentContainer.SplitterWidth = 1
        Me.scMainContentContainer.TabIndex = 41
        '
        'panelReminderType
        '
        Me.panelReminderType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelReminderType.Controls.Add(Me.lblReminderTypeSpecific)
        Me.panelReminderType.Controls.Add(Me.lblReminderTypeDaily)
        Me.panelReminderType.Controls.Add(Me.lblReminderTypeInterval)
        Me.panelReminderType.Controls.Add(Me.grpReminderType)
        Me.panelReminderType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReminderType.ForeColor = System.Drawing.Color.SaddleBrown
        Me.panelReminderType.Location = New System.Drawing.Point(0, 0)
        Me.panelReminderType.Name = "panelReminderType"
        Me.panelReminderType.Size = New System.Drawing.Size(1438, 93)
        Me.panelReminderType.TabIndex = 0
        Me.panelReminderType.Visible = False
        '
        'lblReminderTypeSpecific
        '
        Me.lblReminderTypeSpecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblReminderTypeSpecific.Location = New System.Drawing.Point(1275, 29)
        Me.lblReminderTypeSpecific.Name = "lblReminderTypeSpecific"
        Me.lblReminderTypeSpecific.Size = New System.Drawing.Size(142, 32)
        Me.lblReminderTypeSpecific.TabIndex = 7
        Me.lblReminderTypeSpecific.Text = "SpecificDate"
        Me.lblReminderTypeSpecific.Visible = False
        '
        'lblReminderTypeDaily
        '
        Me.lblReminderTypeDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblReminderTypeDaily.Location = New System.Drawing.Point(1148, 29)
        Me.lblReminderTypeDaily.Name = "lblReminderTypeDaily"
        Me.lblReminderTypeDaily.Size = New System.Drawing.Size(78, 32)
        Me.lblReminderTypeDaily.TabIndex = 6
        Me.lblReminderTypeDaily.Text = "Daily"
        Me.lblReminderTypeDaily.Visible = False
        '
        'lblReminderTypeInterval
        '
        Me.lblReminderTypeInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblReminderTypeInterval.Location = New System.Drawing.Point(1002, 29)
        Me.lblReminderTypeInterval.Name = "lblReminderTypeInterval"
        Me.lblReminderTypeInterval.Size = New System.Drawing.Size(100, 32)
        Me.lblReminderTypeInterval.TabIndex = 5
        Me.lblReminderTypeInterval.Text = "Interval"
        Me.lblReminderTypeInterval.Visible = False
        '
        'grpReminderType
        '
        Me.grpReminderType.BackColor = System.Drawing.Color.Transparent
        Me.grpReminderType.Controls.Add(Me.panelReminderTypeContent)
        Me.grpReminderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpReminderType.ForeColor = System.Drawing.Color.SaddleBrown
        Me.grpReminderType.Location = New System.Drawing.Point(25, 10)
        Me.grpReminderType.Name = "grpReminderType"
        Me.grpReminderType.Size = New System.Drawing.Size(691, 70)
        Me.grpReminderType.TabIndex = 0
        Me.grpReminderType.TabStop = False
        Me.grpReminderType.Text = "Reminder Type"
        '
        'panelReminderTypeContent
        '
        Me.panelReminderTypeContent.Controls.Add(Me.radReminderTypeInterval)
        Me.panelReminderTypeContent.Controls.Add(Me.radReminderTypeSpecific)
        Me.panelReminderTypeContent.Controls.Add(Me.radReminderTypeDaily)
        Me.panelReminderTypeContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReminderTypeContent.Location = New System.Drawing.Point(3, 26)
        Me.panelReminderTypeContent.Name = "panelReminderTypeContent"
        Me.panelReminderTypeContent.Size = New System.Drawing.Size(685, 41)
        Me.panelReminderTypeContent.TabIndex = 0
        '
        'lblReminderTypeTip
        '
        Me.lblReminderTypeTip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReminderTypeTip.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderTypeTip.ForeColor = System.Drawing.Color.Crimson
        Me.lblReminderTypeTip.Location = New System.Drawing.Point(0, 0)
        Me.lblReminderTypeTip.Name = "lblReminderTypeTip"
        Me.lblReminderTypeTip.Size = New System.Drawing.Size(1438, 93)
        Me.lblReminderTypeTip.TabIndex = 40
        Me.lblReminderTypeTip.Text = "Reminder TYPE configuration appears here..."
        Me.lblReminderTypeTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scContentContainer
        '
        Me.scContentContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scContentContainer.Location = New System.Drawing.Point(0, 0)
        Me.scContentContainer.Name = "scContentContainer"
        Me.scContentContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scContentContainer.Panel1
        '
        Me.scContentContainer.Panel1.AutoScroll = True
        Me.scContentContainer.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.scContentContainer.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scContentContainer.Panel1.Controls.Add(Me.Panel1)
        '
        'scContentContainer.Panel2
        '
        Me.scContentContainer.Panel2.Controls.Add(Me.dgReminderDetails)
        Me.scContentContainer.Size = New System.Drawing.Size(1438, 805)
        Me.scContentContainer.SplitterDistance = 557
        Me.scContentContainer.SplitterWidth = 1
        Me.scContentContainer.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.scSubContentSpliter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1438, 557)
        Me.Panel1.TabIndex = 41
        '
        'scSubContentSpliter
        '
        Me.scSubContentSpliter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.scSubContentSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scSubContentSpliter.Location = New System.Drawing.Point(0, 0)
        Me.scSubContentSpliter.Name = "scSubContentSpliter"
        '
        'scSubContentSpliter.Panel1
        '
        Me.scSubContentSpliter.Panel1.Controls.Add(Me.panelReminderTimeConfig)
        Me.scSubContentSpliter.Panel1.Controls.Add(Me.lblReminderContentTipLeft)
        '
        'scSubContentSpliter.Panel2
        '
        Me.scSubContentSpliter.Panel2.Controls.Add(Me.panelNotificationSettings)
        Me.scSubContentSpliter.Panel2.Controls.Add(Me.lblReminderContentTipRight)
        Me.scSubContentSpliter.Size = New System.Drawing.Size(1434, 553)
        Me.scSubContentSpliter.SplitterDistance = 755
        Me.scSubContentSpliter.SplitterWidth = 1
        Me.scSubContentSpliter.TabIndex = 41
        '
        'panelReminderTimeConfig
        '
        Me.panelReminderTimeConfig.Controls.Add(Me.grpReminderTimeConfig)
        Me.panelReminderTimeConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReminderTimeConfig.Location = New System.Drawing.Point(0, 0)
        Me.panelReminderTimeConfig.Name = "panelReminderTimeConfig"
        Me.panelReminderTimeConfig.Size = New System.Drawing.Size(751, 549)
        Me.panelReminderTimeConfig.TabIndex = 0
        '
        'grpReminderTimeConfig
        '
        Me.grpReminderTimeConfig.Controls.Add(Me.grpReminderTypeInterval)
        Me.grpReminderTimeConfig.Controls.Add(Me.grpRepeat)
        Me.grpReminderTimeConfig.Controls.Add(Me.reminderTimePlaceHolder)
        Me.grpReminderTimeConfig.Controls.Add(Me.grpReminderTypeDaily)
        Me.grpReminderTimeConfig.Controls.Add(Me.grpReminderTypeSpecific)
        Me.grpReminderTimeConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpReminderTimeConfig.ForeColor = System.Drawing.Color.Navy
        Me.grpReminderTimeConfig.Location = New System.Drawing.Point(23, 27)
        Me.grpReminderTimeConfig.Name = "grpReminderTimeConfig"
        Me.grpReminderTimeConfig.Size = New System.Drawing.Size(691, 482)
        Me.grpReminderTimeConfig.TabIndex = 0
        Me.grpReminderTimeConfig.TabStop = False
        Me.grpReminderTimeConfig.Text = "Reminder Time Configuration"
        '
        'grpReminderTypeInterval
        '
        Me.grpReminderTypeInterval.BackColor = System.Drawing.Color.Transparent
        Me.grpReminderTypeInterval.Controls.Add(Me.Label19)
        Me.grpReminderTypeInterval.Controls.Add(Me.panelReminderTypeIntervalContent)
        Me.grpReminderTypeInterval.Controls.Add(Me.Label17)
        Me.grpReminderTypeInterval.Controls.Add(Me.Label18)
        Me.grpReminderTypeInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpReminderTypeInterval.ForeColor = System.Drawing.Color.Navy
        Me.grpReminderTypeInterval.Location = New System.Drawing.Point(98, 23)
        Me.grpReminderTypeInterval.Name = "grpReminderTypeInterval"
        Me.grpReminderTypeInterval.Size = New System.Drawing.Size(358, 125)
        Me.grpReminderTypeInterval.TabIndex = 0
        Me.grpReminderTypeInterval.TabStop = False
        Me.grpReminderTypeInterval.Text = "Interval Duration"
        Me.ttFieldInfoTooltip.SetToolTip(Me.grpReminderTypeInterval, "Remind on each interval expiry for given repeat count")
        Me.grpReminderTypeInterval.Visible = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(237, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 17)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Seconds"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelReminderTypeIntervalContent
        '
        Me.panelReminderTypeIntervalContent.Controls.Add(Me.numHours)
        Me.panelReminderTypeIntervalContent.Controls.Add(Me.numSeconds)
        Me.panelReminderTypeIntervalContent.Controls.Add(Me.numMinutes)
        Me.panelReminderTypeIntervalContent.Location = New System.Drawing.Point(3, 57)
        Me.panelReminderTypeIntervalContent.Name = "panelReminderTypeIntervalContent"
        Me.panelReminderTypeIntervalContent.Size = New System.Drawing.Size(352, 59)
        Me.panelReminderTypeIntervalContent.TabIndex = 0
        '
        'numHours
        '
        Me.numHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numHours.ForeColor = System.Drawing.Color.Navy
        Me.numHours.Location = New System.Drawing.Point(43, 4)
        Me.numHours.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(76, 26)
        Me.numHours.TabIndex = 0
        Me.numHours.Tag = "0"
        Me.ttFieldInfoTooltip.SetToolTip(Me.numHours, "Number of Hours. Min:0, Max: 59")
        '
        'numSeconds
        '
        Me.numSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numSeconds.ForeColor = System.Drawing.Color.Navy
        Me.numSeconds.Location = New System.Drawing.Point(246, 4)
        Me.numSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numSeconds.Name = "numSeconds"
        Me.numSeconds.Size = New System.Drawing.Size(76, 26)
        Me.numSeconds.TabIndex = 2
        Me.numSeconds.Tag = "0"
        Me.ttFieldInfoTooltip.SetToolTip(Me.numSeconds, "Number of Seconds. Min:0, Max: 59")
        '
        'numMinutes
        '
        Me.numMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numMinutes.ForeColor = System.Drawing.Color.Navy
        Me.numMinutes.Location = New System.Drawing.Point(142, 4)
        Me.numMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numMinutes.Name = "numMinutes"
        Me.numMinutes.Size = New System.Drawing.Size(76, 26)
        Me.numMinutes.TabIndex = 1
        Me.numMinutes.Tag = "0"
        Me.ttFieldInfoTooltip.SetToolTip(Me.numMinutes, "Number of Minutes. Min:0, Max: 59")
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 18)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Hours"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(129, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 16)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Minutes"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpRepeat
        '
        Me.grpRepeat.BackColor = System.Drawing.Color.Transparent
        Me.grpRepeat.Controls.Add(Me.panelRepeatContent)
        Me.grpRepeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpRepeat.ForeColor = System.Drawing.Color.Navy
        Me.grpRepeat.Location = New System.Drawing.Point(462, 69)
        Me.grpRepeat.Name = "grpRepeat"
        Me.grpRepeat.Size = New System.Drawing.Size(180, 125)
        Me.grpRepeat.TabIndex = 3
        Me.grpRepeat.TabStop = False
        Me.grpRepeat.Text = "Repeat"
        '
        'panelRepeatContent
        '
        Me.panelRepeatContent.Controls.Add(Me.numRepeat)
        Me.panelRepeatContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelRepeatContent.Location = New System.Drawing.Point(3, 22)
        Me.panelRepeatContent.Name = "panelRepeatContent"
        Me.panelRepeatContent.Size = New System.Drawing.Size(174, 100)
        Me.panelRepeatContent.TabIndex = 0
        Me.ttFieldInfoTooltip.SetToolTip(Me.panelRepeatContent, "How many times repeat the reminder")
        '
        'numRepeat
        '
        Me.numRepeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numRepeat.ForeColor = System.Drawing.Color.Navy
        Me.numRepeat.Location = New System.Drawing.Point(32, 39)
        Me.numRepeat.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numRepeat.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numRepeat.Name = "numRepeat"
        Me.numRepeat.Size = New System.Drawing.Size(110, 26)
        Me.numRepeat.TabIndex = 0
        Me.numRepeat.Tag = "1"
        Me.numRepeat.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'reminderTimePlaceHolder
        '
        Me.reminderTimePlaceHolder.Location = New System.Drawing.Point(51, 69)
        Me.reminderTimePlaceHolder.Name = "reminderTimePlaceHolder"
        Me.reminderTimePlaceHolder.Size = New System.Drawing.Size(30, 51)
        Me.reminderTimePlaceHolder.TabIndex = 40
        Me.reminderTimePlaceHolder.TabStop = False
        Me.reminderTimePlaceHolder.Visible = False
        '
        'grpReminderTypeDaily
        '
        Me.grpReminderTypeDaily.BackColor = System.Drawing.Color.Transparent
        Me.grpReminderTypeDaily.Controls.Add(Me.panelReminderTypeDailyContent)
        Me.grpReminderTypeDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpReminderTypeDaily.ForeColor = System.Drawing.Color.Navy
        Me.grpReminderTypeDaily.Location = New System.Drawing.Point(28, 260)
        Me.grpReminderTypeDaily.Name = "grpReminderTypeDaily"
        Me.grpReminderTypeDaily.Size = New System.Drawing.Size(358, 242)
        Me.grpReminderTypeDaily.TabIndex = 2
        Me.grpReminderTypeDaily.TabStop = False
        Me.grpReminderTypeDaily.Text = "Daily"
        Me.grpReminderTypeDaily.Visible = False
        '
        'panelReminderTypeDailyContent
        '
        Me.panelReminderTypeDailyContent.Controls.Add(Me.lvDaily)
        Me.panelReminderTypeDailyContent.Controls.Add(Me.dtDailyTime)
        Me.panelReminderTypeDailyContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReminderTypeDailyContent.Location = New System.Drawing.Point(3, 22)
        Me.panelReminderTypeDailyContent.Name = "panelReminderTypeDailyContent"
        Me.panelReminderTypeDailyContent.Size = New System.Drawing.Size(352, 217)
        Me.panelReminderTypeDailyContent.TabIndex = 0
        Me.ttFieldInfoTooltip.SetToolTip(Me.panelReminderTypeDailyContent, "Remind on specified days on each week for given num of repeats")
        '
        'lvDaily
        '
        Me.lvDaily.CheckOnClick = True
        Me.lvDaily.ForeColor = System.Drawing.Color.Navy
        Me.lvDaily.FormattingEnabled = True
        Me.lvDaily.Items.AddRange(New Object() {"Daily", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.lvDaily.Location = New System.Drawing.Point(20, 28)
        Me.lvDaily.Name = "lvDaily"
        Me.lvDaily.Size = New System.Drawing.Size(144, 172)
        Me.lvDaily.TabIndex = 0
        Me.lvDaily.ThreeDCheckBoxes = True
        '
        'dtDailyTime
        '
        Me.dtDailyTime.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtDailyTime.CalendarTitleForeColor = System.Drawing.Color.Navy
        Me.dtDailyTime.CustomFormat = "hh:mm:ss tt"
        Me.dtDailyTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDailyTime.Location = New System.Drawing.Point(191, 98)
        Me.dtDailyTime.Name = "dtDailyTime"
        Me.dtDailyTime.ShowUpDown = True
        Me.dtDailyTime.Size = New System.Drawing.Size(137, 26)
        Me.dtDailyTime.TabIndex = 1
        '
        'grpReminderTypeSpecific
        '
        Me.grpReminderTypeSpecific.BackColor = System.Drawing.Color.Transparent
        Me.grpReminderTypeSpecific.Controls.Add(Me.panelReminderTypeSpecificContent)
        Me.grpReminderTypeSpecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpReminderTypeSpecific.ForeColor = System.Drawing.Color.Navy
        Me.grpReminderTypeSpecific.Location = New System.Drawing.Point(28, 142)
        Me.grpReminderTypeSpecific.Name = "grpReminderTypeSpecific"
        Me.grpReminderTypeSpecific.Size = New System.Drawing.Size(358, 125)
        Me.grpReminderTypeSpecific.TabIndex = 1
        Me.grpReminderTypeSpecific.TabStop = False
        Me.grpReminderTypeSpecific.Text = "Specific Date and Time"
        Me.grpReminderTypeSpecific.Visible = False
        '
        'panelReminderTypeSpecificContent
        '
        Me.panelReminderTypeSpecificContent.Controls.Add(Me.dtSpecific)
        Me.panelReminderTypeSpecificContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReminderTypeSpecificContent.ForeColor = System.Drawing.Color.Navy
        Me.panelReminderTypeSpecificContent.Location = New System.Drawing.Point(3, 22)
        Me.panelReminderTypeSpecificContent.Name = "panelReminderTypeSpecificContent"
        Me.panelReminderTypeSpecificContent.Size = New System.Drawing.Size(352, 100)
        Me.panelReminderTypeSpecificContent.TabIndex = 0
        Me.ttFieldInfoTooltip.SetToolTip(Me.panelReminderTypeSpecificContent, "Remind only once on given specific time")
        '
        'dtSpecific
        '
        Me.dtSpecific.CustomFormat = "dd MMM yyyy hh:mm:ss tt"
        Me.dtSpecific.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSpecific.Location = New System.Drawing.Point(43, 39)
        Me.dtSpecific.Name = "dtSpecific"
        Me.dtSpecific.Size = New System.Drawing.Size(267, 26)
        Me.dtSpecific.TabIndex = 0
        '
        'lblReminderContentTipLeft
        '
        Me.lblReminderContentTipLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReminderContentTipLeft.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderContentTipLeft.ForeColor = System.Drawing.Color.Crimson
        Me.lblReminderContentTipLeft.Location = New System.Drawing.Point(0, 0)
        Me.lblReminderContentTipLeft.Name = "lblReminderContentTipLeft"
        Me.lblReminderContentTipLeft.Size = New System.Drawing.Size(751, 549)
        Me.lblReminderContentTipLeft.TabIndex = 4
        Me.lblReminderContentTipLeft.Text = "Reminder TIME configuration appears here..."
        Me.lblReminderContentTipLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelNotificationSettings
        '
        Me.panelNotificationSettings.Controls.Add(Me.grpNotificationSettings)
        Me.panelNotificationSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelNotificationSettings.Location = New System.Drawing.Point(0, 0)
        Me.panelNotificationSettings.Name = "panelNotificationSettings"
        Me.panelNotificationSettings.Size = New System.Drawing.Size(674, 549)
        Me.panelNotificationSettings.TabIndex = 0
        '
        'grpNotificationSettings
        '
        Me.grpNotificationSettings.BackColor = System.Drawing.Color.Transparent
        Me.grpNotificationSettings.Controls.Add(Me.Label6)
        Me.grpNotificationSettings.Controls.Add(Me.Label14)
        Me.grpNotificationSettings.Controls.Add(Me.Label5)
        Me.grpNotificationSettings.Controls.Add(Me.panelNotificationSettingsContent)
        Me.grpNotificationSettings.Controls.Add(Me.Label9)
        Me.grpNotificationSettings.Controls.Add(Me.Label13)
        Me.grpNotificationSettings.Controls.Add(Me.Label7)
        Me.grpNotificationSettings.Controls.Add(Me.Label1)
        Me.grpNotificationSettings.Controls.Add(Me.Label4)
        Me.grpNotificationSettings.Controls.Add(Me.Label3)
        Me.grpNotificationSettings.Controls.Add(Me.Label2)
        Me.grpNotificationSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpNotificationSettings.ForeColor = System.Drawing.Color.Navy
        Me.grpNotificationSettings.Location = New System.Drawing.Point(38, 25)
        Me.grpNotificationSettings.Name = "grpNotificationSettings"
        Me.grpNotificationSettings.Size = New System.Drawing.Size(602, 514)
        Me.grpNotificationSettings.TabIndex = 0
        Me.grpNotificationSettings.TabStop = False
        Me.grpNotificationSettings.Text = "Notification Popup Settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(32, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Info Font"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label6, "The topbar meta data text font in the notification popup")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(30, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 20)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Duration"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label14, "How long the notification popup should be visible")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(30, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Info Color"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label5, "The topbar meta data text color in the notification popup")
        '
        'panelNotificationSettingsContent
        '
        Me.panelNotificationSettingsContent.Controls.Add(Me.btnShowNotificationMetaFontDialog)
        Me.panelNotificationSettingsContent.Controls.Add(Me.txtNotificaitonMetaFont)
        Me.panelNotificationSettingsContent.Controls.Add(Me.colorPickerMetaForeColor)
        Me.panelNotificationSettingsContent.Controls.Add(Me.btnShowNotificationFontDialog)
        Me.panelNotificationSettingsContent.Controls.Add(Me.numNotificationHeight)
        Me.panelNotificationSettingsContent.Controls.Add(Me.numNotificationWidth)
        Me.panelNotificationSettingsContent.Controls.Add(Me.cmbNotificationSound)
        Me.panelNotificationSettingsContent.Controls.Add(Me.btnPlaySound)
        Me.panelNotificationSettingsContent.Controls.Add(Me.colorPickerForeColor)
        Me.panelNotificationSettingsContent.Controls.Add(Me.txtNotificationMessage)
        Me.panelNotificationSettingsContent.Controls.Add(Me.colorPickerBackColor)
        Me.panelNotificationSettingsContent.Controls.Add(Me.cmbNotificationDuration)
        Me.panelNotificationSettingsContent.Controls.Add(Me.txtNotificaitonFont)
        Me.panelNotificationSettingsContent.Location = New System.Drawing.Point(137, 29)
        Me.panelNotificationSettingsContent.Name = "panelNotificationSettingsContent"
        Me.panelNotificationSettingsContent.Size = New System.Drawing.Size(459, 475)
        Me.panelNotificationSettingsContent.TabIndex = 0
        '
        'btnShowNotificationMetaFontDialog
        '
        Me.btnShowNotificationMetaFontDialog.FlatAppearance.BorderSize = 0
        Me.btnShowNotificationMetaFontDialog.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowNotificationMetaFontDialog.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.btnShowNotificationMetaFontDialog.Location = New System.Drawing.Point(398, 309)
        Me.btnShowNotificationMetaFontDialog.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShowNotificationMetaFontDialog.Name = "btnShowNotificationMetaFontDialog"
        Me.btnShowNotificationMetaFontDialog.Size = New System.Drawing.Size(31, 30)
        Me.btnShowNotificationMetaFontDialog.TabIndex = 68
        Me.btnShowNotificationMetaFontDialog.Text = "..."
        Me.btnShowNotificationMetaFontDialog.UseVisualStyleBackColor = True
        '
        'txtNotificaitonMetaFont
        '
        Me.txtNotificaitonMetaFont.BackColor = System.Drawing.Color.White
        Me.txtNotificaitonMetaFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNotificaitonMetaFont.Location = New System.Drawing.Point(23, 309)
        Me.txtNotificaitonMetaFont.Name = "txtNotificaitonMetaFont"
        Me.txtNotificaitonMetaFont.ReadOnly = True
        Me.txtNotificaitonMetaFont.Size = New System.Drawing.Size(406, 30)
        Me.txtNotificaitonMetaFont.TabIndex = 67
        Me.txtNotificaitonMetaFont.Tag = "Comic Sans MS, 12pt, style=Regular"
        Me.txtNotificaitonMetaFont.Text = "Comic Sans MS, 12pt, style=Regular"
        '
        'colorPickerMetaForeColor
        '
        Me.colorPickerMetaForeColor.Appearance = ElaColorChooser.ElaColorPicker.ColorPickerAppearance.EditableComboBox
        Me.colorPickerMetaForeColor.Color = System.Drawing.Color.White
        Me.colorPickerMetaForeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.colorPickerMetaForeColor.Location = New System.Drawing.Point(23, 353)
        Me.colorPickerMetaForeColor.Name = "colorPickerMetaForeColor"
        Me.colorPickerMetaForeColor.Size = New System.Drawing.Size(406, 28)
        Me.colorPickerMetaForeColor.TabIndex = 66
        Me.colorPickerMetaForeColor.Tag = "Brown"
        '
        'btnShowNotificationFontDialog
        '
        Me.btnShowNotificationFontDialog.FlatAppearance.BorderSize = 0
        Me.btnShowNotificationFontDialog.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowNotificationFontDialog.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.btnShowNotificationFontDialog.Location = New System.Drawing.Point(398, 186)
        Me.btnShowNotificationFontDialog.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShowNotificationFontDialog.Name = "btnShowNotificationFontDialog"
        Me.btnShowNotificationFontDialog.Size = New System.Drawing.Size(31, 30)
        Me.btnShowNotificationFontDialog.TabIndex = 5
        Me.btnShowNotificationFontDialog.Text = "..."
        Me.btnShowNotificationFontDialog.UseVisualStyleBackColor = True
        '
        'numNotificationHeight
        '
        Me.numNotificationHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numNotificationHeight.Location = New System.Drawing.Point(23, 433)
        Me.numNotificationHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numNotificationHeight.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numNotificationHeight.Name = "numNotificationHeight"
        Me.numNotificationHeight.Size = New System.Drawing.Size(406, 26)
        Me.numNotificationHeight.TabIndex = 9
        Me.numNotificationHeight.Tag = "100"
        Me.numNotificationHeight.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'numNotificationWidth
        '
        Me.numNotificationWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numNotificationWidth.Location = New System.Drawing.Point(23, 394)
        Me.numNotificationWidth.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.numNotificationWidth.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numNotificationWidth.Name = "numNotificationWidth"
        Me.numNotificationWidth.Size = New System.Drawing.Size(406, 26)
        Me.numNotificationWidth.TabIndex = 8
        Me.numNotificationWidth.Tag = "500"
        Me.numNotificationWidth.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'cmbNotificationSound
        '
        Me.cmbNotificationSound.DisplayMember = "Value"
        Me.cmbNotificationSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbNotificationSound.FormattingEnabled = True
        Me.cmbNotificationSound.Location = New System.Drawing.Point(23, 52)
        Me.cmbNotificationSound.Name = "cmbNotificationSound"
        Me.cmbNotificationSound.Size = New System.Drawing.Size(367, 28)
        Me.cmbNotificationSound.TabIndex = 1
        Me.cmbNotificationSound.ValueMember = "Key"
        '
        'btnPlaySound
        '
        Me.btnPlaySound.BackColor = System.Drawing.Color.Transparent
        Me.btnPlaySound.BackgroundImage = Global.RemindMe.My.Resources.Resources.play
        Me.btnPlaySound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPlaySound.FlatAppearance.BorderSize = 0
        Me.btnPlaySound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaySound.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaySound.ForeColor = System.Drawing.Color.White
        Me.btnPlaySound.Location = New System.Drawing.Point(391, 47)
        Me.btnPlaySound.Name = "btnPlaySound"
        Me.btnPlaySound.Size = New System.Drawing.Size(41, 37)
        Me.btnPlaySound.TabIndex = 2
        Me.btnPlaySound.UseVisualStyleBackColor = False
        '
        'colorPickerForeColor
        '
        Me.colorPickerForeColor.Appearance = ElaColorChooser.ElaColorPicker.ColorPickerAppearance.EditableComboBox
        Me.colorPickerForeColor.Color = System.Drawing.Color.White
        Me.colorPickerForeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.colorPickerForeColor.Location = New System.Drawing.Point(23, 269)
        Me.colorPickerForeColor.Name = "colorPickerForeColor"
        Me.colorPickerForeColor.Size = New System.Drawing.Size(406, 28)
        Me.colorPickerForeColor.TabIndex = 7
        Me.colorPickerForeColor.Tag = "Brown"
        '
        'txtNotificationMessage
        '
        Me.txtNotificationMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNotificationMessage.Location = New System.Drawing.Point(23, 91)
        Me.txtNotificationMessage.Name = "txtNotificationMessage"
        Me.txtNotificationMessage.Size = New System.Drawing.Size(406, 86)
        Me.txtNotificationMessage.TabIndex = 3
        Me.txtNotificationMessage.Tag = "Reminder message goes here"
        Me.txtNotificationMessage.Text = "Reminder message goes here"
        '
        'colorPickerBackColor
        '
        Me.colorPickerBackColor.Appearance = ElaColorChooser.ElaColorPicker.ColorPickerAppearance.EditableComboBox
        Me.colorPickerBackColor.Color = System.Drawing.Color.DeepPink
        Me.colorPickerBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.colorPickerBackColor.Location = New System.Drawing.Point(23, 227)
        Me.colorPickerBackColor.Name = "colorPickerBackColor"
        Me.colorPickerBackColor.Size = New System.Drawing.Size(406, 28)
        Me.colorPickerBackColor.TabIndex = 6
        Me.colorPickerBackColor.Tag = "DeepPink"
        '
        'cmbNotificationDuration
        '
        Me.cmbNotificationDuration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNotificationDuration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNotificationDuration.BackColor = System.Drawing.Color.White
        Me.cmbNotificationDuration.DisplayMember = "Value"
        Me.cmbNotificationDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbNotificationDuration.FormattingEnabled = True
        Me.cmbNotificationDuration.Location = New System.Drawing.Point(23, 12)
        Me.cmbNotificationDuration.MaxDropDownItems = 20
        Me.cmbNotificationDuration.Name = "cmbNotificationDuration"
        Me.cmbNotificationDuration.Size = New System.Drawing.Size(406, 28)
        Me.cmbNotificationDuration.TabIndex = 0
        Me.cmbNotificationDuration.ValueMember = "Key"
        '
        'txtNotificaitonFont
        '
        Me.txtNotificaitonFont.BackColor = System.Drawing.Color.White
        Me.txtNotificaitonFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNotificaitonFont.Location = New System.Drawing.Point(23, 186)
        Me.txtNotificaitonFont.Name = "txtNotificaitonFont"
        Me.txtNotificaitonFont.ReadOnly = True
        Me.txtNotificaitonFont.Size = New System.Drawing.Size(406, 30)
        Me.txtNotificaitonFont.TabIndex = 4
        Me.txtNotificaitonFont.Tag = "Segoe Script, 12pt, style=Bold"
        Me.txtNotificaitonFont.Text = "Segoe Script, 12pt, style=Bold"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(30, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Message Font"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label9, "Font for the notification message text and notification topbar text")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(30, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 20)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Message"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label13, "Text to be displayed in notification popup.")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(30, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Sound"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label7, "Sound to play when the notification pops up.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Text Color"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label1, "The message text color of the notification popup")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(30, 464)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Height"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label4, "The height (in pixel) of the notification popup")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(30, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Width"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label3, "The width (in pixel) of the notification popup")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Back Color"
        Me.ttFieldInfoTooltip.SetToolTip(Me.Label2, "The background color of the notification popup")
        '
        'lblReminderContentTipRight
        '
        Me.lblReminderContentTipRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReminderContentTipRight.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderContentTipRight.ForeColor = System.Drawing.Color.Crimson
        Me.lblReminderContentTipRight.Location = New System.Drawing.Point(0, 0)
        Me.lblReminderContentTipRight.Name = "lblReminderContentTipRight"
        Me.lblReminderContentTipRight.Size = New System.Drawing.Size(674, 549)
        Me.lblReminderContentTipRight.TabIndex = 40
        Me.lblReminderContentTipRight.Text = "Reminder NOTIFICATION configuration appears here..."
        Me.lblReminderContentTipRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainMenu
        '
        Me.MainMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1533, 29)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.AutoToolTip = True
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+E"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(57, 25)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReminderHistoryToolStripMenuItem, Me.ClearHistoryToolStripMenuItem})
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'ReminderHistoryToolStripMenuItem
        '
        Me.ReminderHistoryToolStripMenuItem.Name = "ReminderHistoryToolStripMenuItem"
        Me.ReminderHistoryToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.ReminderHistoryToolStripMenuItem.Text = "Reminders History"
        '
        'ClearHistoryToolStripMenuItem
        '
        Me.ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem"
        Me.ClearHistoryToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.ClearHistoryToolStripMenuItem.Text = "Clear History"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ShortcutsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ShortcutsToolStripMenuItem
        '
        Me.ShortcutsToolStripMenuItem.Name = "ShortcutsToolStripMenuItem"
        Me.ShortcutsToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.ShortcutsToolStripMenuItem.Text = "Shortcuts"
        '
        'ttIconTooltip
        '
        Me.ttIconTooltip.AutomaticDelay = 100
        Me.ttIconTooltip.AutoPopDelay = 10000
        Me.ttIconTooltip.BackColor = System.Drawing.Color.Purple
        Me.ttIconTooltip.ForeColor = System.Drawing.Color.White
        Me.ttIconTooltip.InitialDelay = 0
        Me.ttIconTooltip.ReshowDelay = 20
        Me.ttIconTooltip.ShowAlways = True
        '
        'ttFieldInfoTooltip
        '
        Me.ttFieldInfoTooltip.AutomaticDelay = 100
        Me.ttFieldInfoTooltip.AutoPopDelay = 10000
        Me.ttFieldInfoTooltip.BackColor = System.Drawing.Color.Purple
        Me.ttFieldInfoTooltip.ForeColor = System.Drawing.Color.White
        Me.ttFieldInfoTooltip.InitialDelay = 0
        Me.ttFieldInfoTooltip.ReshowDelay = 20
        Me.ttFieldInfoTooltip.ShowAlways = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1533, 962)
        Me.Controls.Add(Me.scMainContainer)
        Me.Controls.Add(Me.ssReminderStatusBar)
        Me.Controls.Add(Me.MainMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RemindMe - Reminder Buddy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.contextMenuForTrayIcon.ResumeLayout(False)
        Me.ssReminderStatusBar.ResumeLayout(False)
        Me.ssReminderStatusBar.PerformLayout()
        CType(Me.dgReminderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMainContainer.Panel1.ResumeLayout(False)
        Me.scMainContainer.Panel2.ResumeLayout(False)
        CType(Me.scMainContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMainContainer.ResumeLayout(False)
        CType(Me.btnCloneReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClearScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStartStopReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteReminder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMainContentContainer.Panel1.ResumeLayout(False)
        Me.scMainContentContainer.Panel2.ResumeLayout(False)
        CType(Me.scMainContentContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMainContentContainer.ResumeLayout(False)
        Me.panelReminderType.ResumeLayout(False)
        Me.grpReminderType.ResumeLayout(False)
        Me.panelReminderTypeContent.ResumeLayout(False)
        Me.scContentContainer.Panel1.ResumeLayout(False)
        Me.scContentContainer.Panel2.ResumeLayout(False)
        CType(Me.scContentContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scContentContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.scSubContentSpliter.Panel1.ResumeLayout(False)
        Me.scSubContentSpliter.Panel2.ResumeLayout(False)
        CType(Me.scSubContentSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scSubContentSpliter.ResumeLayout(False)
        Me.panelReminderTimeConfig.ResumeLayout(False)
        Me.grpReminderTimeConfig.ResumeLayout(False)
        Me.grpReminderTypeInterval.ResumeLayout(False)
        Me.panelReminderTypeIntervalContent.ResumeLayout(False)
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRepeat.ResumeLayout(False)
        Me.panelRepeatContent.ResumeLayout(False)
        CType(Me.numRepeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReminderTypeDaily.ResumeLayout(False)
        Me.panelReminderTypeDailyContent.ResumeLayout(False)
        Me.grpReminderTypeSpecific.ResumeLayout(False)
        Me.panelReminderTypeSpecificContent.ResumeLayout(False)
        Me.panelNotificationSettings.ResumeLayout(False)
        Me.grpNotificationSettings.ResumeLayout(False)
        Me.grpNotificationSettings.PerformLayout()
        Me.panelNotificationSettingsContent.ResumeLayout(False)
        CType(Me.numNotificationHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNotificationWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusLblTimerStatus As ToolStripStatusLabel
    Friend WithEvents trayIcon As NotifyIcon
    Friend WithEvents contextMenuForTrayIcon As ContextMenuStrip
    Friend WithEvents menuItemExit As ToolStripMenuItem
    Friend WithEvents menuItemShowApp As ToolStripMenuItem
    Friend WithEvents lblReminderStatus As ToolStripStatusLabel
    Friend WithEvents ssReminderStatusBar As StatusStrip
    Friend WithEvents fontdialogNotificationFont As FontDialog
    Friend WithEvents dgReminderDetails As DataGridView
    Friend WithEvents radReminderTypeSpecific As RadioButton
    Friend WithEvents radReminderTypeDaily As RadioButton
    Friend WithEvents radReminderTypeInterval As RadioButton
    Friend WithEvents btnAddReminder As PictureBox
    Friend WithEvents btnClearScreen As PictureBox
    Friend WithEvents btnStartStopReminder As PictureBox
    Friend WithEvents btnDeleteReminder As PictureBox
    Friend WithEvents btnEditReminder As PictureBox
    Friend WithEvents scMainContainer As SplitContainer
    Friend WithEvents scContentContainer As SplitContainer
    Friend WithEvents lblReminderTypeTip As Label
    Friend WithEvents scMainContentContainer As SplitContainer
    Friend WithEvents panelReminderType As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents scSubContentSpliter As SplitContainer
    Friend WithEvents panelReminderTimeConfig As Panel
    Friend WithEvents grpReminderTypeInterval As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents numSeconds As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents numMinutes As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents numHours As NumericUpDown
    Friend WithEvents reminderTimePlaceHolder As GroupBox
    Friend WithEvents grpReminderTypeSpecific As GroupBox
    Friend WithEvents dtSpecific As DateTimePicker
    Friend WithEvents grpReminderTypeDaily As GroupBox
    Friend WithEvents lvDaily As CheckedListBox
    Friend WithEvents dtDailyTime As DateTimePicker
    Friend WithEvents grpRepeat As GroupBox
    Friend WithEvents numRepeat As NumericUpDown
    Friend WithEvents lblReminderContentTipLeft As Label
    Friend WithEvents panelNotificationSettings As Panel
    Friend WithEvents grpNotificationSettings As GroupBox
    Friend WithEvents numNotificationHeight As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numNotificationWidth As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPlaySound As Button
    Friend WithEvents colorPickerForeColor As ElaColorChooser.ElaColorPicker
    Friend WithEvents colorPickerBackColor As ElaColorChooser.ElaColorPicker
    Friend WithEvents btnShowNotificationFontDialog As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNotificaitonFont As RichTextBox
    Friend WithEvents cmbNotificationDuration As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNotificationMessage As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbNotificationSound As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblReminderContentTipRight As Label
    Friend WithEvents grpReminderTimeConfig As GroupBox
    Friend WithEvents panelReminderTypeContent As Panel
    Friend WithEvents panelReminderTypeIntervalContent As Panel
    Friend WithEvents panelRepeatContent As Panel
    Friend WithEvents panelReminderTypeDailyContent As Panel
    Friend WithEvents panelReminderTypeSpecificContent As Panel
    Friend WithEvents panelNotificationSettingsContent As Panel
    Friend WithEvents lblReminderTypeSpecific As Label
    Friend WithEvents lblReminderTypeDaily As Label
    Friend WithEvents lblReminderTypeInterval As Label
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReminderHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpReminderType As GroupBox
    Friend WithEvents lblIconPlace5 As Label
    Friend WithEvents lblIconPlace4 As Label
    Friend WithEvents lblIconPlace3 As Label
    Friend WithEvents lblIconPlace2 As Label
    Friend WithEvents lblIconPlace1 As Label
    Friend WithEvents ttIconTooltip As ToolTip
    Friend WithEvents ShortcutsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblIconPlace6 As Label
    Friend WithEvents btnCloneReminder As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents colorPickerMetaForeColor As ElaColorChooser.ElaColorPicker
    Friend WithEvents ttFieldInfoTooltip As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents btnShowNotificationMetaFontDialog As Button
    Friend WithEvents txtNotificaitonMetaFont As RichTextBox
    Friend WithEvents reminder_id As DataGridViewTextBoxColumn
    Friend WithEvents reminder_type As DataGridViewTextBoxColumn
    Friend WithEvents reminder_repeat_max As DataGridViewTextBoxColumn
    Friend WithEvents reminder_repeat_elapsed As DataGridViewTextBoxColumn
    Friend WithEvents reminder_status As DataGridViewTextBoxColumn
    Friend WithEvents reminder_interval As DataGridViewTextBoxColumn
    Friend WithEvents reminder_daily As DataGridViewTextBoxColumn
    Friend WithEvents reminder_specific_time As DataGridViewTextBoxColumn
    Friend WithEvents reminder_created_time As DataGridViewTextBoxColumn
    Friend WithEvents reminder_updated_time As DataGridViewTextBoxColumn
    Friend WithEvents reminder_deleted_time As DataGridViewTextBoxColumn
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
