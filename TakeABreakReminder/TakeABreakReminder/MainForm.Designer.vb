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
        Me.statusRemainingTimeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.fontdialogNotificationFont = New System.Windows.Forms.FontDialog()
        Me.dgReminderDetails = New System.Windows.Forms.DataGridView()
        Me.colReminderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderRepeatMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderRepeatElapsed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIntervalDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIntervalDaily = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderSpecificTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderCreateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderLastUpdatedTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.radReminderTypeSpecific = New System.Windows.Forms.RadioButton()
        Me.radReminderTypeDaily = New System.Windows.Forms.RadioButton()
        Me.radReminderTypeInterval = New System.Windows.Forms.RadioButton()
        Me.btnAddReminder = New System.Windows.Forms.PictureBox()
        Me.btnClearScreen = New System.Windows.Forms.PictureBox()
        Me.btnStartStopReminder = New System.Windows.Forms.PictureBox()
        Me.btnDeleteReminder = New System.Windows.Forms.PictureBox()
        Me.btnEditReminder = New System.Windows.Forms.PictureBox()
        Me.scMainContainer = New System.Windows.Forms.SplitContainer()
        Me.scMainContentContainer = New System.Windows.Forms.SplitContainer()
        Me.panelReminderType = New System.Windows.Forms.Panel()
        Me.lblReminderTypeSpecific = New System.Windows.Forms.Label()
        Me.lblReminderTypeDaily = New System.Windows.Forms.Label()
        Me.lblReminderTypeInterval = New System.Windows.Forms.Label()
        Me.panelReminderTypeContent = New System.Windows.Forms.Panel()
        Me.lblReminderType = New System.Windows.Forms.Label()
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.panelNotificationSettingsContent = New System.Windows.Forms.Panel()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemindedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextMenuForTrayIcon.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgReminderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClearScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStartStopReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scMainContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMainContainer.Panel1.SuspendLayout()
        Me.scMainContainer.Panel2.SuspendLayout()
        Me.scMainContainer.SuspendLayout()
        CType(Me.scMainContentContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMainContentContainer.Panel1.SuspendLayout()
        Me.scMainContentContainer.Panel2.SuspendLayout()
        Me.scMainContentContainer.SuspendLayout()
        Me.panelReminderType.SuspendLayout()
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
        Me.MenuStrip1.SuspendLayout()
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
        Me.trayIcon.BalloonTipText = "TakeABreak Reminder"
        Me.trayIcon.BalloonTipTitle = "TakeABreak Reminder"
        Me.trayIcon.ContextMenuStrip = Me.contextMenuForTrayIcon
        Me.trayIcon.Icon = CType(resources.GetObject("trayIcon.Icon"), System.Drawing.Icon)
        Me.trayIcon.Text = "TakeABreak Reminder"
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
        'statusRemainingTimeLabel
        '
        Me.statusRemainingTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.statusRemainingTimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.statusRemainingTimeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.statusRemainingTimeLabel.ForeColor = System.Drawing.Color.White
        Me.statusRemainingTimeLabel.Name = "statusRemainingTimeLabel"
        Me.statusRemainingTimeLabel.Size = New System.Drawing.Size(226, 25)
        Me.statusRemainingTimeLabel.Text = "Reminder not started yet"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusRemainingTimeLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 932)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1533, 30)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
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
        Me.dgReminderDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReminderId, Me.colReminderType, Me.colReminderRepeatMax, Me.colReminderRepeatElapsed, Me.colReminderStatus, Me.colIntervalDuration, Me.colIntervalDaily, Me.colReminderSpecificTime, Me.colReminderCreateTime, Me.colReminderLastUpdatedTime, Me.colReminderStartTime, Me.colReminderLastNotifiedTime, Me.colReminderNextNotifyTime, Me.colNotificationDuration, Me.colNotificationSound, Me.colNotificationMessage, Me.colNotificationFont, Me.colNotificationBackColor, Me.colNotificationForeColor, Me.colNotificationWidth, Me.colNotificationHeight})
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
        Me.dgReminderDetails.Size = New System.Drawing.Size(1439, 262)
        Me.dgReminderDetails.TabIndex = 33
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
        DataGridViewCellStyle3.NullValue = "none"
        Me.colIntervalDuration.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle4.NullValue = "none"
        Me.colReminderSpecificTime.DefaultCellStyle = DataGridViewCellStyle4
        Me.colReminderSpecificTime.HeaderText = "Specific"
        Me.colReminderSpecificTime.Name = "colReminderSpecificTime"
        Me.colReminderSpecificTime.ReadOnly = True
        Me.colReminderSpecificTime.Width = 165
        '
        'colReminderCreateTime
        '
        Me.colReminderCreateTime.DataPropertyName = "reminder_created_time"
        DataGridViewCellStyle5.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle5.NullValue = "none"
        Me.colReminderCreateTime.DefaultCellStyle = DataGridViewCellStyle5
        Me.colReminderCreateTime.HeaderText = "Created"
        Me.colReminderCreateTime.Name = "colReminderCreateTime"
        Me.colReminderCreateTime.ReadOnly = True
        Me.colReminderCreateTime.Width = 165
        '
        'colReminderLastUpdatedTime
        '
        Me.colReminderLastUpdatedTime.DataPropertyName = "reminder_updated_time"
        DataGridViewCellStyle6.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle6.NullValue = "none"
        Me.colReminderLastUpdatedTime.DefaultCellStyle = DataGridViewCellStyle6
        Me.colReminderLastUpdatedTime.HeaderText = "Updated"
        Me.colReminderLastUpdatedTime.Name = "colReminderLastUpdatedTime"
        Me.colReminderLastUpdatedTime.ReadOnly = True
        Me.colReminderLastUpdatedTime.Width = 165
        '
        'colReminderStartTime
        '
        Me.colReminderStartTime.DataPropertyName = "reminder_started_time"
        DataGridViewCellStyle7.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle7.NullValue = "none"
        Me.colReminderStartTime.DefaultCellStyle = DataGridViewCellStyle7
        Me.colReminderStartTime.HeaderText = "Started"
        Me.colReminderStartTime.Name = "colReminderStartTime"
        Me.colReminderStartTime.ReadOnly = True
        Me.colReminderStartTime.Width = 165
        '
        'colReminderLastNotifiedTime
        '
        Me.colReminderLastNotifiedTime.DataPropertyName = "reminder_notified_time"
        DataGridViewCellStyle8.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle8.NullValue = "none"
        Me.colReminderLastNotifiedTime.DefaultCellStyle = DataGridViewCellStyle8
        Me.colReminderLastNotifiedTime.HeaderText = "Notified"
        Me.colReminderLastNotifiedTime.Name = "colReminderLastNotifiedTime"
        Me.colReminderLastNotifiedTime.ReadOnly = True
        Me.colReminderLastNotifiedTime.Width = 165
        '
        'colReminderNextNotifyTime
        '
        Me.colReminderNextNotifyTime.DataPropertyName = "reminder_next_notify_time"
        DataGridViewCellStyle9.Format = "dd-MMM-yy hh:mm:sstt"
        DataGridViewCellStyle9.NullValue = "none"
        Me.colReminderNextNotifyTime.DefaultCellStyle = DataGridViewCellStyle9
        Me.colReminderNextNotifyTime.HeaderText = "Next Notify"
        Me.colReminderNextNotifyTime.Name = "colReminderNextNotifyTime"
        Me.colReminderNextNotifyTime.ReadOnly = True
        Me.colReminderNextNotifyTime.Width = 165
        '
        'colNotificationDuration
        '
        Me.colNotificationDuration.DataPropertyName = "notification_duration"
        DataGridViewCellStyle10.Format = "0 secs"
        DataGridViewCellStyle10.NullValue = "0 secs"
        Me.colNotificationDuration.DefaultCellStyle = DataGridViewCellStyle10
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
        'radReminderTypeSpecific
        '
        Me.radReminderTypeSpecific.AutoSize = True
        Me.radReminderTypeSpecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.radReminderTypeSpecific.ForeColor = System.Drawing.Color.White
        Me.radReminderTypeSpecific.Location = New System.Drawing.Point(311, 3)
        Me.radReminderTypeSpecific.Name = "radReminderTypeSpecific"
        Me.radReminderTypeSpecific.Size = New System.Drawing.Size(145, 29)
        Me.radReminderTypeSpecific.TabIndex = 2
        Me.radReminderTypeSpecific.Text = "Specific Date"
        Me.radReminderTypeSpecific.UseVisualStyleBackColor = True
        '
        'radReminderTypeDaily
        '
        Me.radReminderTypeDaily.AutoSize = True
        Me.radReminderTypeDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.radReminderTypeDaily.ForeColor = System.Drawing.Color.White
        Me.radReminderTypeDaily.Location = New System.Drawing.Point(185, 3)
        Me.radReminderTypeDaily.Name = "radReminderTypeDaily"
        Me.radReminderTypeDaily.Size = New System.Drawing.Size(73, 29)
        Me.radReminderTypeDaily.TabIndex = 1
        Me.radReminderTypeDaily.Text = "Daily"
        Me.radReminderTypeDaily.UseVisualStyleBackColor = True
        '
        'radReminderTypeInterval
        '
        Me.radReminderTypeInterval.AutoSize = True
        Me.radReminderTypeInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.radReminderTypeInterval.ForeColor = System.Drawing.Color.White
        Me.radReminderTypeInterval.Location = New System.Drawing.Point(39, 3)
        Me.radReminderTypeInterval.Name = "radReminderTypeInterval"
        Me.radReminderTypeInterval.Size = New System.Drawing.Size(93, 29)
        Me.radReminderTypeInterval.TabIndex = 0
        Me.radReminderTypeInterval.Text = "Interval"
        Me.radReminderTypeInterval.UseVisualStyleBackColor = True
        '
        'btnAddReminder
        '
        Me.btnAddReminder.BackColor = System.Drawing.Color.Transparent
        Me.btnAddReminder.BackgroundImage = CType(resources.GetObject("btnAddReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnAddReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddReminder.Location = New System.Drawing.Point(20, 50)
        Me.btnAddReminder.Name = "btnAddReminder"
        Me.btnAddReminder.Size = New System.Drawing.Size(48, 48)
        Me.btnAddReminder.TabIndex = 41
        Me.btnAddReminder.TabStop = False
        '
        'btnClearScreen
        '
        Me.btnClearScreen.BackColor = System.Drawing.Color.Transparent
        Me.btnClearScreen.BackgroundImage = CType(resources.GetObject("btnClearScreen.BackgroundImage"), System.Drawing.Image)
        Me.btnClearScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearScreen.Location = New System.Drawing.Point(20, 474)
        Me.btnClearScreen.Name = "btnClearScreen"
        Me.btnClearScreen.Size = New System.Drawing.Size(48, 48)
        Me.btnClearScreen.TabIndex = 42
        Me.btnClearScreen.TabStop = False
        '
        'btnStartStopReminder
        '
        Me.btnStartStopReminder.BackColor = System.Drawing.Color.Transparent
        Me.btnStartStopReminder.BackgroundImage = CType(resources.GetObject("btnStartStopReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnStartStopReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStartStopReminder.Location = New System.Drawing.Point(20, 262)
        Me.btnStartStopReminder.Name = "btnStartStopReminder"
        Me.btnStartStopReminder.Size = New System.Drawing.Size(48, 48)
        Me.btnStartStopReminder.TabIndex = 43
        Me.btnStartStopReminder.TabStop = False
        '
        'btnDeleteReminder
        '
        Me.btnDeleteReminder.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteReminder.BackgroundImage = CType(resources.GetObject("btnDeleteReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteReminder.Location = New System.Drawing.Point(20, 368)
        Me.btnDeleteReminder.Name = "btnDeleteReminder"
        Me.btnDeleteReminder.Size = New System.Drawing.Size(48, 48)
        Me.btnDeleteReminder.TabIndex = 44
        Me.btnDeleteReminder.TabStop = False
        '
        'btnEditReminder
        '
        Me.btnEditReminder.BackColor = System.Drawing.Color.Transparent
        Me.btnEditReminder.BackgroundImage = CType(resources.GetObject("btnEditReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnEditReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditReminder.Location = New System.Drawing.Point(20, 156)
        Me.btnEditReminder.Name = "btnEditReminder"
        Me.btnEditReminder.Size = New System.Drawing.Size(48, 48)
        Me.btnEditReminder.TabIndex = 45
        Me.btnEditReminder.TabStop = False
        '
        'scMainContainer
        '
        Me.scMainContainer.BackColor = System.Drawing.Color.SteelBlue
        Me.scMainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scMainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scMainContainer.Location = New System.Drawing.Point(0, 29)
        Me.scMainContainer.Name = "scMainContainer"
        '
        'scMainContainer.Panel1
        '
        Me.scMainContainer.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.scMainContainer.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.scMainContainer.SplitterWidth = 2
        Me.scMainContainer.TabIndex = 48
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
        Me.scMainContentContainer.Size = New System.Drawing.Size(1439, 901)
        Me.scMainContentContainer.SplitterDistance = 60
        Me.scMainContentContainer.TabIndex = 41
        '
        'panelReminderType
        '
        Me.panelReminderType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelReminderType.Controls.Add(Me.lblReminderTypeSpecific)
        Me.panelReminderType.Controls.Add(Me.lblReminderTypeDaily)
        Me.panelReminderType.Controls.Add(Me.lblReminderTypeInterval)
        Me.panelReminderType.Controls.Add(Me.panelReminderTypeContent)
        Me.panelReminderType.Controls.Add(Me.lblReminderType)
        Me.panelReminderType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReminderType.Location = New System.Drawing.Point(0, 0)
        Me.panelReminderType.Name = "panelReminderType"
        Me.panelReminderType.Size = New System.Drawing.Size(1439, 60)
        Me.panelReminderType.TabIndex = 0
        '
        'lblReminderTypeSpecific
        '
        Me.lblReminderTypeSpecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblReminderTypeSpecific.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReminderTypeSpecific.Location = New System.Drawing.Point(1110, 12)
        Me.lblReminderTypeSpecific.Name = "lblReminderTypeSpecific"
        Me.lblReminderTypeSpecific.Size = New System.Drawing.Size(142, 32)
        Me.lblReminderTypeSpecific.TabIndex = 7
        Me.lblReminderTypeSpecific.Text = "SpecificDate"
        '
        'lblReminderTypeDaily
        '
        Me.lblReminderTypeDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblReminderTypeDaily.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReminderTypeDaily.Location = New System.Drawing.Point(983, 12)
        Me.lblReminderTypeDaily.Name = "lblReminderTypeDaily"
        Me.lblReminderTypeDaily.Size = New System.Drawing.Size(78, 32)
        Me.lblReminderTypeDaily.TabIndex = 6
        Me.lblReminderTypeDaily.Text = "Daily"
        '
        'lblReminderTypeInterval
        '
        Me.lblReminderTypeInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblReminderTypeInterval.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReminderTypeInterval.Location = New System.Drawing.Point(837, 12)
        Me.lblReminderTypeInterval.Name = "lblReminderTypeInterval"
        Me.lblReminderTypeInterval.Size = New System.Drawing.Size(100, 32)
        Me.lblReminderTypeInterval.TabIndex = 5
        Me.lblReminderTypeInterval.Text = "Interval"
        '
        'panelReminderTypeContent
        '
        Me.panelReminderTypeContent.Controls.Add(Me.radReminderTypeInterval)
        Me.panelReminderTypeContent.Controls.Add(Me.radReminderTypeSpecific)
        Me.panelReminderTypeContent.Controls.Add(Me.radReminderTypeDaily)
        Me.panelReminderTypeContent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.panelReminderTypeContent.Location = New System.Drawing.Point(334, 9)
        Me.panelReminderTypeContent.Name = "panelReminderTypeContent"
        Me.panelReminderTypeContent.Size = New System.Drawing.Size(471, 46)
        Me.panelReminderTypeContent.TabIndex = 4
        '
        'lblReminderType
        '
        Me.lblReminderType.AutoSize = True
        Me.lblReminderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderType.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReminderType.Location = New System.Drawing.Point(135, 16)
        Me.lblReminderType.Name = "lblReminderType"
        Me.lblReminderType.Size = New System.Drawing.Size(166, 24)
        Me.lblReminderType.TabIndex = 3
        Me.lblReminderType.Text = "Reminder Type :"
        '
        'lblReminderTypeTip
        '
        Me.lblReminderTypeTip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReminderTypeTip.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderTypeTip.ForeColor = System.Drawing.Color.White
        Me.lblReminderTypeTip.Location = New System.Drawing.Point(0, 0)
        Me.lblReminderTypeTip.Name = "lblReminderTypeTip"
        Me.lblReminderTypeTip.Size = New System.Drawing.Size(1439, 60)
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
        Me.scContentContainer.Size = New System.Drawing.Size(1439, 837)
        Me.scContentContainer.SplitterDistance = 573
        Me.scContentContainer.SplitterWidth = 2
        Me.scContentContainer.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.scSubContentSpliter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1439, 573)
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
        Me.scSubContentSpliter.Size = New System.Drawing.Size(1435, 569)
        Me.scSubContentSpliter.SplitterDistance = 756
        Me.scSubContentSpliter.SplitterWidth = 1
        Me.scSubContentSpliter.TabIndex = 41
        '
        'panelReminderTimeConfig
        '
        Me.panelReminderTimeConfig.Controls.Add(Me.grpReminderTimeConfig)
        Me.panelReminderTimeConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReminderTimeConfig.Location = New System.Drawing.Point(0, 0)
        Me.panelReminderTimeConfig.Name = "panelReminderTimeConfig"
        Me.panelReminderTimeConfig.Size = New System.Drawing.Size(752, 565)
        Me.panelReminderTimeConfig.TabIndex = 41
        '
        'grpReminderTimeConfig
        '
        Me.grpReminderTimeConfig.Controls.Add(Me.grpReminderTypeInterval)
        Me.grpReminderTimeConfig.Controls.Add(Me.grpRepeat)
        Me.grpReminderTimeConfig.Controls.Add(Me.reminderTimePlaceHolder)
        Me.grpReminderTimeConfig.Controls.Add(Me.grpReminderTypeDaily)
        Me.grpReminderTimeConfig.Controls.Add(Me.grpReminderTypeSpecific)
        Me.grpReminderTimeConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpReminderTimeConfig.ForeColor = System.Drawing.Color.White
        Me.grpReminderTimeConfig.Location = New System.Drawing.Point(23, 39)
        Me.grpReminderTimeConfig.Name = "grpReminderTimeConfig"
        Me.grpReminderTimeConfig.Size = New System.Drawing.Size(691, 500)
        Me.grpReminderTimeConfig.TabIndex = 41
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
        Me.grpReminderTypeInterval.ForeColor = System.Drawing.Color.White
        Me.grpReminderTypeInterval.Location = New System.Drawing.Point(98, 23)
        Me.grpReminderTypeInterval.Name = "grpReminderTypeInterval"
        Me.grpReminderTypeInterval.Size = New System.Drawing.Size(358, 125)
        Me.grpReminderTypeInterval.TabIndex = 30
        Me.grpReminderTypeInterval.TabStop = False
        Me.grpReminderTypeInterval.Text = "Interval Duration"
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
        Me.panelReminderTypeIntervalContent.TabIndex = 38
        '
        'numHours
        '
        Me.numHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numHours.Location = New System.Drawing.Point(43, 4)
        Me.numHours.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(76, 26)
        Me.numHours.TabIndex = 33
        Me.numHours.Tag = "0"
        '
        'numSeconds
        '
        Me.numSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numSeconds.Location = New System.Drawing.Point(246, 4)
        Me.numSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numSeconds.Name = "numSeconds"
        Me.numSeconds.Size = New System.Drawing.Size(76, 26)
        Me.numSeconds.TabIndex = 37
        Me.numSeconds.Tag = "0"
        '
        'numMinutes
        '
        Me.numMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numMinutes.Location = New System.Drawing.Point(142, 4)
        Me.numMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numMinutes.Name = "numMinutes"
        Me.numMinutes.Size = New System.Drawing.Size(76, 26)
        Me.numMinutes.TabIndex = 35
        Me.numMinutes.Tag = "0"
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
        Me.grpRepeat.ForeColor = System.Drawing.Color.White
        Me.grpRepeat.Location = New System.Drawing.Point(462, 69)
        Me.grpRepeat.Name = "grpRepeat"
        Me.grpRepeat.Size = New System.Drawing.Size(205, 79)
        Me.grpRepeat.TabIndex = 38
        Me.grpRepeat.TabStop = False
        Me.grpRepeat.Text = "Repeat"
        '
        'panelRepeatContent
        '
        Me.panelRepeatContent.Controls.Add(Me.numRepeat)
        Me.panelRepeatContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelRepeatContent.Location = New System.Drawing.Point(3, 22)
        Me.panelRepeatContent.Name = "panelRepeatContent"
        Me.panelRepeatContent.Size = New System.Drawing.Size(199, 54)
        Me.panelRepeatContent.TabIndex = 41
        '
        'numRepeat
        '
        Me.numRepeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numRepeat.Location = New System.Drawing.Point(29, 14)
        Me.numRepeat.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numRepeat.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numRepeat.Name = "numRepeat"
        Me.numRepeat.Size = New System.Drawing.Size(110, 26)
        Me.numRepeat.TabIndex = 38
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
        Me.grpReminderTypeDaily.ForeColor = System.Drawing.Color.White
        Me.grpReminderTypeDaily.Location = New System.Drawing.Point(28, 260)
        Me.grpReminderTypeDaily.Name = "grpReminderTypeDaily"
        Me.grpReminderTypeDaily.Size = New System.Drawing.Size(358, 242)
        Me.grpReminderTypeDaily.TabIndex = 39
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
        Me.panelReminderTypeDailyContent.TabIndex = 41
        '
        'lvDaily
        '
        Me.lvDaily.CheckOnClick = True
        Me.lvDaily.FormattingEnabled = True
        Me.lvDaily.Items.AddRange(New Object() {"Daily", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.lvDaily.Location = New System.Drawing.Point(20, 28)
        Me.lvDaily.Name = "lvDaily"
        Me.lvDaily.Size = New System.Drawing.Size(144, 172)
        Me.lvDaily.TabIndex = 6
        Me.lvDaily.ThreeDCheckBoxes = True
        '
        'dtDailyTime
        '
        Me.dtDailyTime.CustomFormat = "hh:mm:ss tt"
        Me.dtDailyTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDailyTime.Location = New System.Drawing.Point(191, 98)
        Me.dtDailyTime.Name = "dtDailyTime"
        Me.dtDailyTime.ShowUpDown = True
        Me.dtDailyTime.Size = New System.Drawing.Size(137, 26)
        Me.dtDailyTime.TabIndex = 0
        '
        'grpReminderTypeSpecific
        '
        Me.grpReminderTypeSpecific.BackColor = System.Drawing.Color.Transparent
        Me.grpReminderTypeSpecific.Controls.Add(Me.panelReminderTypeSpecificContent)
        Me.grpReminderTypeSpecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpReminderTypeSpecific.ForeColor = System.Drawing.Color.White
        Me.grpReminderTypeSpecific.Location = New System.Drawing.Point(28, 142)
        Me.grpReminderTypeSpecific.Name = "grpReminderTypeSpecific"
        Me.grpReminderTypeSpecific.Size = New System.Drawing.Size(358, 113)
        Me.grpReminderTypeSpecific.TabIndex = 38
        Me.grpReminderTypeSpecific.TabStop = False
        Me.grpReminderTypeSpecific.Text = "Specific Date and Time"
        Me.grpReminderTypeSpecific.Visible = False
        '
        'panelReminderTypeSpecificContent
        '
        Me.panelReminderTypeSpecificContent.Controls.Add(Me.dtSpecific)
        Me.panelReminderTypeSpecificContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReminderTypeSpecificContent.Location = New System.Drawing.Point(3, 22)
        Me.panelReminderTypeSpecificContent.Name = "panelReminderTypeSpecificContent"
        Me.panelReminderTypeSpecificContent.Size = New System.Drawing.Size(352, 88)
        Me.panelReminderTypeSpecificContent.TabIndex = 1
        '
        'dtSpecific
        '
        Me.dtSpecific.CustomFormat = "dd MMM yyyy hh:mm:ss tt"
        Me.dtSpecific.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSpecific.Location = New System.Drawing.Point(45, 25)
        Me.dtSpecific.Name = "dtSpecific"
        Me.dtSpecific.Size = New System.Drawing.Size(267, 26)
        Me.dtSpecific.TabIndex = 0
        '
        'lblReminderContentTipLeft
        '
        Me.lblReminderContentTipLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReminderContentTipLeft.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderContentTipLeft.ForeColor = System.Drawing.Color.White
        Me.lblReminderContentTipLeft.Location = New System.Drawing.Point(0, 0)
        Me.lblReminderContentTipLeft.Name = "lblReminderContentTipLeft"
        Me.lblReminderContentTipLeft.Size = New System.Drawing.Size(752, 565)
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
        Me.panelNotificationSettings.Size = New System.Drawing.Size(674, 565)
        Me.panelNotificationSettings.TabIndex = 41
        '
        'grpNotificationSettings
        '
        Me.grpNotificationSettings.BackColor = System.Drawing.Color.Transparent
        Me.grpNotificationSettings.Controls.Add(Me.Label14)
        Me.grpNotificationSettings.Controls.Add(Me.panelNotificationSettingsContent)
        Me.grpNotificationSettings.Controls.Add(Me.Label9)
        Me.grpNotificationSettings.Controls.Add(Me.Label13)
        Me.grpNotificationSettings.Controls.Add(Me.Label7)
        Me.grpNotificationSettings.Controls.Add(Me.Label1)
        Me.grpNotificationSettings.Controls.Add(Me.Label4)
        Me.grpNotificationSettings.Controls.Add(Me.Label3)
        Me.grpNotificationSettings.Controls.Add(Me.Label2)
        Me.grpNotificationSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpNotificationSettings.ForeColor = System.Drawing.Color.White
        Me.grpNotificationSettings.Location = New System.Drawing.Point(38, 37)
        Me.grpNotificationSettings.Name = "grpNotificationSettings"
        Me.grpNotificationSettings.Size = New System.Drawing.Size(602, 502)
        Me.grpNotificationSettings.TabIndex = 30
        Me.grpNotificationSettings.TabStop = False
        Me.grpNotificationSettings.Text = "Notification Popup Settings"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(42, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 20)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Duration"
        '
        'panelNotificationSettingsContent
        '
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
        Me.panelNotificationSettingsContent.Size = New System.Drawing.Size(459, 473)
        Me.panelNotificationSettingsContent.TabIndex = 31
        '
        'btnShowNotificationFontDialog
        '
        Me.btnShowNotificationFontDialog.FlatAppearance.BorderSize = 0
        Me.btnShowNotificationFontDialog.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowNotificationFontDialog.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.btnShowNotificationFontDialog.Location = New System.Drawing.Point(398, 207)
        Me.btnShowNotificationFontDialog.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShowNotificationFontDialog.Name = "btnShowNotificationFontDialog"
        Me.btnShowNotificationFontDialog.Size = New System.Drawing.Size(31, 30)
        Me.btnShowNotificationFontDialog.TabIndex = 59
        Me.btnShowNotificationFontDialog.Text = "..."
        Me.btnShowNotificationFontDialog.UseVisualStyleBackColor = True
        '
        'numNotificationHeight
        '
        Me.numNotificationHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numNotificationHeight.Location = New System.Drawing.Point(23, 390)
        Me.numNotificationHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numNotificationHeight.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numNotificationHeight.Name = "numNotificationHeight"
        Me.numNotificationHeight.Size = New System.Drawing.Size(406, 26)
        Me.numNotificationHeight.TabIndex = 64
        Me.numNotificationHeight.Tag = "100"
        Me.numNotificationHeight.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'numNotificationWidth
        '
        Me.numNotificationWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numNotificationWidth.Location = New System.Drawing.Point(23, 346)
        Me.numNotificationWidth.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.numNotificationWidth.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numNotificationWidth.Name = "numNotificationWidth"
        Me.numNotificationWidth.Size = New System.Drawing.Size(406, 26)
        Me.numNotificationWidth.TabIndex = 38
        Me.numNotificationWidth.Tag = "500"
        Me.numNotificationWidth.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'cmbNotificationSound
        '
        Me.cmbNotificationSound.DisplayMember = "Value"
        Me.cmbNotificationSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbNotificationSound.FormattingEnabled = True
        Me.cmbNotificationSound.Location = New System.Drawing.Point(23, 60)
        Me.cmbNotificationSound.Name = "cmbNotificationSound"
        Me.cmbNotificationSound.Size = New System.Drawing.Size(367, 28)
        Me.cmbNotificationSound.TabIndex = 55
        Me.cmbNotificationSound.ValueMember = "Key"
        '
        'btnPlaySound
        '
        Me.btnPlaySound.BackColor = System.Drawing.Color.Transparent
        Me.btnPlaySound.BackgroundImage = Global.TakeABreakReminder.My.Resources.Resources.play
        Me.btnPlaySound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPlaySound.FlatAppearance.BorderSize = 0
        Me.btnPlaySound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaySound.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaySound.ForeColor = System.Drawing.Color.White
        Me.btnPlaySound.Location = New System.Drawing.Point(391, 55)
        Me.btnPlaySound.Name = "btnPlaySound"
        Me.btnPlaySound.Size = New System.Drawing.Size(41, 38)
        Me.btnPlaySound.TabIndex = 31
        Me.btnPlaySound.UseVisualStyleBackColor = False
        '
        'colorPickerForeColor
        '
        Me.colorPickerForeColor.Appearance = ElaColorChooser.ElaColorPicker.ColorPickerAppearance.EditableComboBox
        Me.colorPickerForeColor.Color = System.Drawing.Color.White
        Me.colorPickerForeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.colorPickerForeColor.Location = New System.Drawing.Point(23, 300)
        Me.colorPickerForeColor.Name = "colorPickerForeColor"
        Me.colorPickerForeColor.Size = New System.Drawing.Size(406, 28)
        Me.colorPickerForeColor.TabIndex = 62
        Me.colorPickerForeColor.Tag = "Brown"
        '
        'txtNotificationMessage
        '
        Me.txtNotificationMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNotificationMessage.Location = New System.Drawing.Point(23, 104)
        Me.txtNotificationMessage.Name = "txtNotificationMessage"
        Me.txtNotificationMessage.Size = New System.Drawing.Size(406, 86)
        Me.txtNotificationMessage.TabIndex = 53
        Me.txtNotificationMessage.Tag = "Reminder message goes here"
        Me.txtNotificationMessage.Text = "Reminder message goes here"
        '
        'colorPickerBackColor
        '
        Me.colorPickerBackColor.Appearance = ElaColorChooser.ElaColorPicker.ColorPickerAppearance.EditableComboBox
        Me.colorPickerBackColor.Color = System.Drawing.Color.DeepPink
        Me.colorPickerBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.colorPickerBackColor.Location = New System.Drawing.Point(23, 255)
        Me.colorPickerBackColor.Name = "colorPickerBackColor"
        Me.colorPickerBackColor.Size = New System.Drawing.Size(406, 28)
        Me.colorPickerBackColor.TabIndex = 61
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
        Me.cmbNotificationDuration.Location = New System.Drawing.Point(23, 16)
        Me.cmbNotificationDuration.MaxDropDownItems = 20
        Me.cmbNotificationDuration.Name = "cmbNotificationDuration"
        Me.cmbNotificationDuration.Size = New System.Drawing.Size(406, 28)
        Me.cmbNotificationDuration.TabIndex = 50
        Me.cmbNotificationDuration.ValueMember = "Key"
        '
        'txtNotificaitonFont
        '
        Me.txtNotificaitonFont.BackColor = System.Drawing.Color.White
        Me.txtNotificaitonFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNotificaitonFont.Location = New System.Drawing.Point(23, 207)
        Me.txtNotificaitonFont.Name = "txtNotificaitonFont"
        Me.txtNotificaitonFont.ReadOnly = True
        Me.txtNotificaitonFont.Size = New System.Drawing.Size(406, 30)
        Me.txtNotificaitonFont.TabIndex = 60
        Me.txtNotificaitonFont.Tag = "Segoe Script, 12pt, style=Bold"
        Me.txtNotificaitonFont.Text = "Segoe Script, 12pt, style=Bold"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(42, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Font"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(42, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 20)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Message"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(42, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Sound"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Text Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(42, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Height"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Back Color"
        '
        'lblReminderContentTipRight
        '
        Me.lblReminderContentTipRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReminderContentTipRight.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderContentTipRight.ForeColor = System.Drawing.Color.White
        Me.lblReminderContentTipRight.Location = New System.Drawing.Point(0, 0)
        Me.lblReminderContentTipRight.Name = "lblReminderContentTipRight"
        Me.lblReminderContentTipRight.Size = New System.Drawing.Size(674, 565)
        Me.lblReminderContentTipRight.TabIndex = 40
        Me.lblReminderContentTipRight.Text = "Reminder NOTIFICATION configuration appears here..."
        Me.lblReminderContentTipRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1533, 29)
        Me.MenuStrip1.TabIndex = 49
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ExitToolStripMenuItem.Text = "Minimize"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(57, 25)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserActionsToolStripMenuItem, Me.RemindedToolStripMenuItem})
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'UserActionsToolStripMenuItem
        '
        Me.UserActionsToolStripMenuItem.Name = "UserActionsToolStripMenuItem"
        Me.UserActionsToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.UserActionsToolStripMenuItem.Text = "User Actions"
        '
        'RemindedToolStripMenuItem
        '
        Me.RemindedToolStripMenuItem.Name = "RemindedToolStripMenuItem"
        Me.RemindedToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.RemindedToolStripMenuItem.Text = "Reminded"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1533, 962)
        Me.Controls.Add(Me.scMainContainer)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RemindMe - Reminder Buddy"
        Me.contextMenuForTrayIcon.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgReminderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClearScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStartStopReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditReminder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMainContainer.Panel1.ResumeLayout(False)
        Me.scMainContainer.Panel2.ResumeLayout(False)
        CType(Me.scMainContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMainContainer.ResumeLayout(False)
        Me.scMainContentContainer.Panel1.ResumeLayout(False)
        Me.scMainContentContainer.Panel2.ResumeLayout(False)
        CType(Me.scMainContentContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMainContentContainer.ResumeLayout(False)
        Me.panelReminderType.ResumeLayout(False)
        Me.panelReminderType.PerformLayout()
        Me.panelReminderTypeContent.ResumeLayout(False)
        Me.panelReminderTypeContent.PerformLayout()
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusLblTimerStatus As ToolStripStatusLabel
    Friend WithEvents trayIcon As NotifyIcon
    Friend WithEvents contextMenuForTrayIcon As ContextMenuStrip
    Friend WithEvents menuItemExit As ToolStripMenuItem
    Friend WithEvents menuItemShowApp As ToolStripMenuItem
    Friend WithEvents statusRemainingTimeLabel As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents fontdialogNotificationFont As FontDialog
    Friend WithEvents dgReminderDetails As DataGridView
    Friend WithEvents radReminderTypeSpecific As RadioButton
    Friend WithEvents radReminderTypeDaily As RadioButton
    Friend WithEvents radReminderTypeInterval As RadioButton
    Friend WithEvents colReminderId As DataGridViewTextBoxColumn
    Friend WithEvents colReminderType As DataGridViewTextBoxColumn
    Friend WithEvents colReminderRepeatMax As DataGridViewTextBoxColumn
    Friend WithEvents colReminderRepeatElapsed As DataGridViewTextBoxColumn
    Friend WithEvents colReminderStatus As DataGridViewTextBoxColumn
    Friend WithEvents colIntervalDuration As DataGridViewTextBoxColumn
    Friend WithEvents colIntervalDaily As DataGridViewTextBoxColumn
    Friend WithEvents colReminderSpecificTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderCreateTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderLastUpdatedTime As DataGridViewTextBoxColumn
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
    Friend WithEvents btnAddReminder As PictureBox
    Friend WithEvents btnClearScreen As PictureBox
    Friend WithEvents btnStartStopReminder As PictureBox
    Friend WithEvents btnDeleteReminder As PictureBox
    Friend WithEvents btnEditReminder As PictureBox
    Friend WithEvents scMainContainer As SplitContainer
    Friend WithEvents scContentContainer As SplitContainer
    Friend WithEvents lblReminderType As Label
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserActionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemindedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
