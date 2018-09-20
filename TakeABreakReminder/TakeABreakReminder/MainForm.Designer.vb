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
        Me.btnStartStopReminder = New System.Windows.Forms.Button()
        Me.statusLblTimerStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextMenuForTrayIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemShowApp = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusRemainingTimeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnShowNotificationFontDialog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fontdialogNotificationFont = New System.Windows.Forms.FontDialog()
        Me.cmbNotificationSound = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNotificationMessage = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbNotificationDuration = New System.Windows.Forms.ComboBox()
        Me.txtNotificaitonFont = New System.Windows.Forms.RichTextBox()
        Me.grpPopupSettings = New System.Windows.Forms.GroupBox()
        Me.numNotificationHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numNotificationWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPlaySound = New System.Windows.Forms.Button()
        Me.colorPickerForeColor = New ElaColorChooser.ElaColorPicker()
        Me.colorPickerBackColor = New ElaColorChooser.ElaColorPicker()
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.grpReminderTypeInterval = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.numSeconds = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.numMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgReminderDetails = New System.Windows.Forms.DataGridView()
        Me.btnAddReminder = New System.Windows.Forms.Button()
        Me.btnUpdateReminder = New System.Windows.Forms.Button()
        Me.grpReminderType = New System.Windows.Forms.GroupBox()
        Me.radReminderTypeWeekly = New System.Windows.Forms.RadioButton()
        Me.radReminderTypeSpecific = New System.Windows.Forms.RadioButton()
        Me.radReminderTypeDaily = New System.Windows.Forms.RadioButton()
        Me.radReminderTypeInterval = New System.Windows.Forms.RadioButton()
        Me.btnDeleteReminder = New System.Windows.Forms.Button()
        Me.btnClearScreen = New System.Windows.Forms.Button()
        Me.grpReminderTypeSpecific = New System.Windows.Forms.GroupBox()
        Me.dtSpecific = New System.Windows.Forms.DateTimePicker()
        Me.numRepeat = New System.Windows.Forms.NumericUpDown()
        Me.grpRepeat = New System.Windows.Forms.GroupBox()
        Me.colReminderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderRepeatMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderRepeatElapsed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIntervalDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.contextMenuForTrayIcon.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.grpPopupSettings.SuspendLayout()
        CType(Me.numNotificationHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNotificationWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReminderTypeInterval.SuspendLayout()
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReminderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReminderType.SuspendLayout()
        Me.grpReminderTypeSpecific.SuspendLayout()
        CType(Me.numRepeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRepeat.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStartStopReminder
        '
        Me.btnStartStopReminder.BackColor = System.Drawing.Color.DarkCyan
        Me.btnStartStopReminder.BackgroundImage = CType(resources.GetObject("btnStartStopReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnStartStopReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStartStopReminder.Enabled = False
        Me.btnStartStopReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStartStopReminder.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnStartStopReminder.ForeColor = System.Drawing.Color.White
        Me.btnStartStopReminder.Location = New System.Drawing.Point(250, 500)
        Me.btnStartStopReminder.Name = "btnStartStopReminder"
        Me.btnStartStopReminder.Size = New System.Drawing.Size(91, 32)
        Me.btnStartStopReminder.TabIndex = 0
        Me.btnStartStopReminder.Text = "Start"
        Me.btnStartStopReminder.UseVisualStyleBackColor = False
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
        Me.statusRemainingTimeLabel.ForeColor = System.Drawing.Color.Red
        Me.statusRemainingTimeLabel.Name = "statusRemainingTimeLabel"
        Me.statusRemainingTimeLabel.Size = New System.Drawing.Size(226, 25)
        Me.statusRemainingTimeLabel.Text = "Reminder not started yet"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusRemainingTimeLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 932)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1360, 30)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnShowNotificationFontDialog
        '
        Me.btnShowNotificationFontDialog.FlatAppearance.BorderSize = 0
        Me.btnShowNotificationFontDialog.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowNotificationFontDialog.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.btnShowNotificationFontDialog.Location = New System.Drawing.Point(526, 245)
        Me.btnShowNotificationFontDialog.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShowNotificationFontDialog.Name = "btnShowNotificationFontDialog"
        Me.btnShowNotificationFontDialog.Size = New System.Drawing.Size(31, 30)
        Me.btnShowNotificationFontDialog.TabIndex = 59
        Me.btnShowNotificationFontDialog.Text = "..."
        Me.btnShowNotificationFontDialog.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Text Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Back Color"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(40, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Sound"
        '
        'cmbNotificationSound
        '
        Me.cmbNotificationSound.DisplayMember = "Value"
        Me.cmbNotificationSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbNotificationSound.FormattingEnabled = True
        Me.cmbNotificationSound.Location = New System.Drawing.Point(151, 98)
        Me.cmbNotificationSound.Name = "cmbNotificationSound"
        Me.cmbNotificationSound.Size = New System.Drawing.Size(367, 28)
        Me.cmbNotificationSound.TabIndex = 55
        Me.cmbNotificationSound.ValueMember = "Key"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(40, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Font"
        '
        'txtNotificationMessage
        '
        Me.txtNotificationMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNotificationMessage.Location = New System.Drawing.Point(151, 142)
        Me.txtNotificationMessage.Name = "txtNotificationMessage"
        Me.txtNotificationMessage.Size = New System.Drawing.Size(406, 86)
        Me.txtNotificationMessage.TabIndex = 53
        Me.txtNotificationMessage.Tag = "Reminder message goes here"
        Me.txtNotificationMessage.Text = "Reminder message goes here"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(40, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 20)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Message"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(40, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 20)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Duration"
        '
        'cmbNotificationDuration
        '
        Me.cmbNotificationDuration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNotificationDuration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNotificationDuration.BackColor = System.Drawing.Color.White
        Me.cmbNotificationDuration.DisplayMember = "Value"
        Me.cmbNotificationDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbNotificationDuration.FormattingEnabled = True
        Me.cmbNotificationDuration.Location = New System.Drawing.Point(151, 54)
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
        Me.txtNotificaitonFont.Location = New System.Drawing.Point(151, 245)
        Me.txtNotificaitonFont.Name = "txtNotificaitonFont"
        Me.txtNotificaitonFont.ReadOnly = True
        Me.txtNotificaitonFont.Size = New System.Drawing.Size(406, 30)
        Me.txtNotificaitonFont.TabIndex = 60
        Me.txtNotificaitonFont.Tag = "Segoe Script, 12pt, style=Bold"
        Me.txtNotificaitonFont.Text = "Segoe Script, 12pt, style=Bold"
        '
        'grpPopupSettings
        '
        Me.grpPopupSettings.BackColor = System.Drawing.Color.Transparent
        Me.grpPopupSettings.Controls.Add(Me.numNotificationHeight)
        Me.grpPopupSettings.Controls.Add(Me.Label4)
        Me.grpPopupSettings.Controls.Add(Me.numNotificationWidth)
        Me.grpPopupSettings.Controls.Add(Me.Label3)
        Me.grpPopupSettings.Controls.Add(Me.btnPlaySound)
        Me.grpPopupSettings.Controls.Add(Me.colorPickerForeColor)
        Me.grpPopupSettings.Controls.Add(Me.colorPickerBackColor)
        Me.grpPopupSettings.Controls.Add(Me.btnShowNotificationFontDialog)
        Me.grpPopupSettings.Controls.Add(Me.Label13)
        Me.grpPopupSettings.Controls.Add(Me.txtNotificaitonFont)
        Me.grpPopupSettings.Controls.Add(Me.cmbNotificationDuration)
        Me.grpPopupSettings.Controls.Add(Me.Label14)
        Me.grpPopupSettings.Controls.Add(Me.txtNotificationMessage)
        Me.grpPopupSettings.Controls.Add(Me.Label9)
        Me.grpPopupSettings.Controls.Add(Me.Label1)
        Me.grpPopupSettings.Controls.Add(Me.cmbNotificationSound)
        Me.grpPopupSettings.Controls.Add(Me.Label2)
        Me.grpPopupSettings.Controls.Add(Me.Label7)
        Me.grpPopupSettings.Enabled = False
        Me.grpPopupSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpPopupSettings.ForeColor = System.Drawing.Color.White
        Me.grpPopupSettings.Location = New System.Drawing.Point(575, 48)
        Me.grpPopupSettings.Name = "grpPopupSettings"
        Me.grpPopupSettings.Size = New System.Drawing.Size(596, 484)
        Me.grpPopupSettings.TabIndex = 30
        Me.grpPopupSettings.TabStop = False
        Me.grpPopupSettings.Text = "Message Popup Settings"
        '
        'numNotificationHeight
        '
        Me.numNotificationHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numNotificationHeight.Location = New System.Drawing.Point(151, 428)
        Me.numNotificationHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numNotificationHeight.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numNotificationHeight.Name = "numNotificationHeight"
        Me.numNotificationHeight.Size = New System.Drawing.Size(406, 26)
        Me.numNotificationHeight.TabIndex = 64
        Me.numNotificationHeight.Tag = "50"
        Me.numNotificationHeight.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Height"
        '
        'numNotificationWidth
        '
        Me.numNotificationWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numNotificationWidth.Location = New System.Drawing.Point(151, 384)
        Me.numNotificationWidth.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.numNotificationWidth.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numNotificationWidth.Name = "numNotificationWidth"
        Me.numNotificationWidth.Size = New System.Drawing.Size(406, 26)
        Me.numNotificationWidth.TabIndex = 38
        Me.numNotificationWidth.Tag = "100"
        Me.numNotificationWidth.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Width"
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
        Me.btnPlaySound.Location = New System.Drawing.Point(519, 93)
        Me.btnPlaySound.Name = "btnPlaySound"
        Me.btnPlaySound.Size = New System.Drawing.Size(41, 38)
        Me.btnPlaySound.TabIndex = 31
        Me.btnPlaySound.UseVisualStyleBackColor = False
        '
        'colorPickerForeColor
        '
        Me.colorPickerForeColor.Appearance = ElaColorChooser.ElaColorPicker.ColorPickerAppearance.EditableComboBox
        Me.colorPickerForeColor.Color = System.Drawing.Color.Brown
        Me.colorPickerForeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.colorPickerForeColor.Location = New System.Drawing.Point(151, 338)
        Me.colorPickerForeColor.Name = "colorPickerForeColor"
        Me.colorPickerForeColor.Size = New System.Drawing.Size(406, 28)
        Me.colorPickerForeColor.TabIndex = 62
        Me.colorPickerForeColor.Tag = "Brown"
        '
        'colorPickerBackColor
        '
        Me.colorPickerBackColor.Appearance = ElaColorChooser.ElaColorPicker.ColorPickerAppearance.EditableComboBox
        Me.colorPickerBackColor.Color = System.Drawing.Color.DeepPink
        Me.colorPickerBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.colorPickerBackColor.Location = New System.Drawing.Point(151, 293)
        Me.colorPickerBackColor.Name = "colorPickerBackColor"
        Me.colorPickerBackColor.Size = New System.Drawing.Size(406, 28)
        Me.colorPickerBackColor.TabIndex = 61
        Me.colorPickerBackColor.Tag = "DeepPink"
        '
        'numHours
        '
        Me.numHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numHours.Location = New System.Drawing.Point(17, 59)
        Me.numHours.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(61, 26)
        Me.numHours.TabIndex = 33
        '
        'grpReminderTypeInterval
        '
        Me.grpReminderTypeInterval.BackColor = System.Drawing.Color.Transparent
        Me.grpReminderTypeInterval.Controls.Add(Me.Label19)
        Me.grpReminderTypeInterval.Controls.Add(Me.numSeconds)
        Me.grpReminderTypeInterval.Controls.Add(Me.Label18)
        Me.grpReminderTypeInterval.Controls.Add(Me.numMinutes)
        Me.grpReminderTypeInterval.Controls.Add(Me.Label17)
        Me.grpReminderTypeInterval.Controls.Add(Me.numHours)
        Me.grpReminderTypeInterval.Enabled = False
        Me.grpReminderTypeInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpReminderTypeInterval.ForeColor = System.Drawing.Color.White
        Me.grpReminderTypeInterval.Location = New System.Drawing.Point(41, 142)
        Me.grpReminderTypeInterval.Name = "grpReminderTypeInterval"
        Me.grpReminderTypeInterval.Size = New System.Drawing.Size(229, 113)
        Me.grpReminderTypeInterval.TabIndex = 30
        Me.grpReminderTypeInterval.TabStop = False
        Me.grpReminderTypeInterval.Text = "Interval Duration"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label19.Location = New System.Drawing.Point(148, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 17)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Seconds"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numSeconds
        '
        Me.numSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numSeconds.Location = New System.Drawing.Point(151, 59)
        Me.numSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numSeconds.Name = "numSeconds"
        Me.numSeconds.Size = New System.Drawing.Size(61, 26)
        Me.numSeconds.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(81, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 17)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Minutes"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numMinutes
        '
        Me.numMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numMinutes.Location = New System.Drawing.Point(84, 59)
        Me.numMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numMinutes.Name = "numMinutes"
        Me.numMinutes.Size = New System.Drawing.Size(61, 26)
        Me.numMinutes.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(14, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 17)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Hours"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReminderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgReminderDetails.ColumnHeadersHeight = 65
        Me.dgReminderDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReminderId, Me.colReminderType, Me.colReminderRepeatMax, Me.colReminderRepeatElapsed, Me.colReminderStatus, Me.colIntervalDuration, Me.colReminderSpecificTime, Me.colReminderCreateTime, Me.colReminderLastUpdatedTime, Me.colReminderStartTime, Me.colReminderLastNotifiedTime, Me.colReminderNextNotifyTime, Me.colNotificationDuration, Me.colNotificationSound, Me.colNotificationMessage, Me.colNotificationFont, Me.colNotificationBackColor, Me.colNotificationForeColor, Me.colNotificationWidth, Me.colNotificationHeight})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReminderDetails.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgReminderDetails.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgReminderDetails.EnableHeadersVisualStyles = False
        Me.dgReminderDetails.GridColor = System.Drawing.Color.DarkGray
        Me.dgReminderDetails.Location = New System.Drawing.Point(0, 619)
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
        Me.dgReminderDetails.Size = New System.Drawing.Size(1360, 313)
        Me.dgReminderDetails.TabIndex = 33
        '
        'btnAddReminder
        '
        Me.btnAddReminder.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAddReminder.BackgroundImage = Global.TakeABreakReminder.My.Resources.Resources.blue_bg
        Me.btnAddReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddReminder.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnAddReminder.FlatAppearance.BorderSize = 2
        Me.btnAddReminder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddReminder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddReminder.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddReminder.ForeColor = System.Drawing.Color.White
        Me.btnAddReminder.Location = New System.Drawing.Point(28, 500)
        Me.btnAddReminder.Name = "btnAddReminder"
        Me.btnAddReminder.Size = New System.Drawing.Size(91, 32)
        Me.btnAddReminder.TabIndex = 36
        Me.btnAddReminder.Tag = "0"
        Me.btnAddReminder.Text = "New"
        Me.btnAddReminder.UseVisualStyleBackColor = False
        '
        'btnUpdateReminder
        '
        Me.btnUpdateReminder.BackColor = System.Drawing.Color.DarkCyan
        Me.btnUpdateReminder.BackgroundImage = CType(resources.GetObject("btnUpdateReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdateReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateReminder.Enabled = False
        Me.btnUpdateReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateReminder.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateReminder.ForeColor = System.Drawing.Color.White
        Me.btnUpdateReminder.Location = New System.Drawing.Point(359, 500)
        Me.btnUpdateReminder.Name = "btnUpdateReminder"
        Me.btnUpdateReminder.Size = New System.Drawing.Size(91, 32)
        Me.btnUpdateReminder.TabIndex = 37
        Me.btnUpdateReminder.Text = "Update"
        Me.btnUpdateReminder.UseVisualStyleBackColor = False
        '
        'grpReminderType
        '
        Me.grpReminderType.BackColor = System.Drawing.Color.Transparent
        Me.grpReminderType.Controls.Add(Me.radReminderTypeWeekly)
        Me.grpReminderType.Controls.Add(Me.radReminderTypeSpecific)
        Me.grpReminderType.Controls.Add(Me.radReminderTypeDaily)
        Me.grpReminderType.Controls.Add(Me.radReminderTypeInterval)
        Me.grpReminderType.Enabled = False
        Me.grpReminderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpReminderType.ForeColor = System.Drawing.Color.White
        Me.grpReminderType.Location = New System.Drawing.Point(41, 48)
        Me.grpReminderType.Name = "grpReminderType"
        Me.grpReminderType.Size = New System.Drawing.Size(476, 67)
        Me.grpReminderType.TabIndex = 38
        Me.grpReminderType.TabStop = False
        Me.grpReminderType.Text = "Reminder Type"
        '
        'radReminderTypeWeekly
        '
        Me.radReminderTypeWeekly.AutoSize = True
        Me.radReminderTypeWeekly.Location = New System.Drawing.Point(222, 25)
        Me.radReminderTypeWeekly.Name = "radReminderTypeWeekly"
        Me.radReminderTypeWeekly.Size = New System.Drawing.Size(78, 24)
        Me.radReminderTypeWeekly.TabIndex = 3
        Me.radReminderTypeWeekly.Text = "Weekly"
        Me.radReminderTypeWeekly.UseVisualStyleBackColor = True
        '
        'radReminderTypeSpecific
        '
        Me.radReminderTypeSpecific.AutoSize = True
        Me.radReminderTypeSpecific.Location = New System.Drawing.Point(331, 25)
        Me.radReminderTypeSpecific.Name = "radReminderTypeSpecific"
        Me.radReminderTypeSpecific.Size = New System.Drawing.Size(121, 24)
        Me.radReminderTypeSpecific.TabIndex = 2
        Me.radReminderTypeSpecific.Text = "Specific Time"
        Me.radReminderTypeSpecific.UseVisualStyleBackColor = True
        '
        'radReminderTypeDaily
        '
        Me.radReminderTypeDaily.AutoSize = True
        Me.radReminderTypeDaily.Location = New System.Drawing.Point(130, 25)
        Me.radReminderTypeDaily.Name = "radReminderTypeDaily"
        Me.radReminderTypeDaily.Size = New System.Drawing.Size(61, 24)
        Me.radReminderTypeDaily.TabIndex = 1
        Me.radReminderTypeDaily.Text = "Daily"
        Me.radReminderTypeDaily.UseVisualStyleBackColor = True
        '
        'radReminderTypeInterval
        '
        Me.radReminderTypeInterval.AutoSize = True
        Me.radReminderTypeInterval.Checked = True
        Me.radReminderTypeInterval.Location = New System.Drawing.Point(20, 25)
        Me.radReminderTypeInterval.Name = "radReminderTypeInterval"
        Me.radReminderTypeInterval.Size = New System.Drawing.Size(79, 24)
        Me.radReminderTypeInterval.TabIndex = 0
        Me.radReminderTypeInterval.TabStop = True
        Me.radReminderTypeInterval.Text = "Interval"
        Me.radReminderTypeInterval.UseVisualStyleBackColor = True
        '
        'btnDeleteReminder
        '
        Me.btnDeleteReminder.BackColor = System.Drawing.Color.DarkCyan
        Me.btnDeleteReminder.BackgroundImage = CType(resources.GetObject("btnDeleteReminder.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteReminder.Enabled = False
        Me.btnDeleteReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteReminder.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteReminder.ForeColor = System.Drawing.Color.White
        Me.btnDeleteReminder.Location = New System.Drawing.Point(469, 500)
        Me.btnDeleteReminder.Name = "btnDeleteReminder"
        Me.btnDeleteReminder.Size = New System.Drawing.Size(91, 32)
        Me.btnDeleteReminder.TabIndex = 39
        Me.btnDeleteReminder.Text = "Delete"
        Me.btnDeleteReminder.UseVisualStyleBackColor = False
        '
        'btnClearScreen
        '
        Me.btnClearScreen.BackColor = System.Drawing.Color.DarkCyan
        Me.btnClearScreen.BackgroundImage = CType(resources.GetObject("btnClearScreen.BackgroundImage"), System.Drawing.Image)
        Me.btnClearScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearScreen.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearScreen.ForeColor = System.Drawing.Color.White
        Me.btnClearScreen.Location = New System.Drawing.Point(141, 500)
        Me.btnClearScreen.Name = "btnClearScreen"
        Me.btnClearScreen.Size = New System.Drawing.Size(91, 32)
        Me.btnClearScreen.TabIndex = 40
        Me.btnClearScreen.Text = "Clear"
        Me.btnClearScreen.UseVisualStyleBackColor = False
        '
        'grpReminderTypeSpecific
        '
        Me.grpReminderTypeSpecific.BackColor = System.Drawing.Color.Transparent
        Me.grpReminderTypeSpecific.Controls.Add(Me.dtSpecific)
        Me.grpReminderTypeSpecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpReminderTypeSpecific.ForeColor = System.Drawing.Color.White
        Me.grpReminderTypeSpecific.Location = New System.Drawing.Point(41, 270)
        Me.grpReminderTypeSpecific.Name = "grpReminderTypeSpecific"
        Me.grpReminderTypeSpecific.Size = New System.Drawing.Size(386, 113)
        Me.grpReminderTypeSpecific.TabIndex = 38
        Me.grpReminderTypeSpecific.TabStop = False
        Me.grpReminderTypeSpecific.Text = "Specific Time"
        Me.grpReminderTypeSpecific.Visible = False
        '
        'dtSpecific
        '
        Me.dtSpecific.CustomFormat = "dd/MMM/yyyy hh:mm:sstt"
        Me.dtSpecific.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSpecific.Location = New System.Drawing.Point(22, 53)
        Me.dtSpecific.Name = "dtSpecific"
        Me.dtSpecific.Size = New System.Drawing.Size(330, 30)
        Me.dtSpecific.TabIndex = 0
        '
        'numRepeat
        '
        Me.numRepeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numRepeat.Location = New System.Drawing.Point(43, 33)
        Me.numRepeat.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numRepeat.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numRepeat.Name = "numRepeat"
        Me.numRepeat.Size = New System.Drawing.Size(143, 26)
        Me.numRepeat.TabIndex = 38
        Me.numRepeat.Tag = "1"
        Me.numRepeat.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grpRepeat
        '
        Me.grpRepeat.BackColor = System.Drawing.Color.Transparent
        Me.grpRepeat.Controls.Add(Me.numRepeat)
        Me.grpRepeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpRepeat.ForeColor = System.Drawing.Color.White
        Me.grpRepeat.Location = New System.Drawing.Point(288, 148)
        Me.grpRepeat.Name = "grpRepeat"
        Me.grpRepeat.Size = New System.Drawing.Size(229, 79)
        Me.grpRepeat.TabIndex = 38
        Me.grpRepeat.TabStop = False
        Me.grpRepeat.Text = "Repeat"
        '
        'colReminderId
        '
        Me.colReminderId.DataPropertyName = "reminder_id"
        Me.colReminderId.HeaderText = "Id"
        Me.colReminderId.Name = "colReminderId"
        Me.colReminderId.ReadOnly = True
        Me.colReminderId.Width = 50
        '
        'colReminderType
        '
        Me.colReminderType.DataPropertyName = "reminder_type"
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
        'FrmMain
        '
        Me.AcceptButton = Me.btnStartStopReminder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1360, 962)
        Me.Controls.Add(Me.grpRepeat)
        Me.Controls.Add(Me.grpReminderTypeSpecific)
        Me.Controls.Add(Me.btnClearScreen)
        Me.Controls.Add(Me.btnDeleteReminder)
        Me.Controls.Add(Me.grpReminderType)
        Me.Controls.Add(Me.btnUpdateReminder)
        Me.Controls.Add(Me.btnAddReminder)
        Me.Controls.Add(Me.dgReminderDetails)
        Me.Controls.Add(Me.grpReminderTypeInterval)
        Me.Controls.Add(Me.grpPopupSettings)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnStartStopReminder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.contextMenuForTrayIcon.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpPopupSettings.ResumeLayout(False)
        Me.grpPopupSettings.PerformLayout()
        CType(Me.numNotificationHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNotificationWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReminderTypeInterval.ResumeLayout(False)
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReminderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReminderType.ResumeLayout(False)
        Me.grpReminderType.PerformLayout()
        Me.grpReminderTypeSpecific.ResumeLayout(False)
        CType(Me.numRepeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRepeat.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartStopReminder As Button
    Friend WithEvents statusLblTimerStatus As ToolStripStatusLabel
    Friend WithEvents trayIcon As NotifyIcon
    Friend WithEvents contextMenuForTrayIcon As ContextMenuStrip
    Friend WithEvents menuItemExit As ToolStripMenuItem
    Friend WithEvents menuItemShowApp As ToolStripMenuItem
    Friend WithEvents statusRemainingTimeLabel As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnShowNotificationFontDialog As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents fontdialogNotificationFont As FontDialog
    Friend WithEvents cmbNotificationSound As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNotificationMessage As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbNotificationDuration As ComboBox
    Friend WithEvents txtNotificaitonFont As RichTextBox
    Friend WithEvents grpPopupSettings As GroupBox
    Friend WithEvents colorPickerForeColor As ElaColorChooser.ElaColorPicker
    Friend WithEvents colorPickerBackColor As ElaColorChooser.ElaColorPicker
    Friend WithEvents btnPlaySound As Button
    Friend WithEvents numHours As NumericUpDown
    Friend WithEvents grpReminderTypeInterval As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents numSeconds As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents numMinutes As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents numNotificationHeight As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numNotificationWidth As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents dgReminderDetails As DataGridView
    Friend WithEvents btnAddReminder As Button
    Friend WithEvents btnUpdateReminder As Button
    Friend WithEvents grpReminderType As GroupBox
    Friend WithEvents radReminderTypeSpecific As RadioButton
    Friend WithEvents radReminderTypeDaily As RadioButton
    Friend WithEvents radReminderTypeInterval As RadioButton
    Friend WithEvents radReminderTypeWeekly As RadioButton
    Friend WithEvents btnDeleteReminder As Button
    Friend WithEvents btnClearScreen As Button
    Friend WithEvents grpReminderTypeSpecific As GroupBox
    Friend WithEvents dtSpecific As DateTimePicker
    Friend WithEvents numRepeat As NumericUpDown
    Friend WithEvents grpRepeat As GroupBox
    Friend WithEvents colReminderId As DataGridViewTextBoxColumn
    Friend WithEvents colReminderType As DataGridViewTextBoxColumn
    Friend WithEvents colReminderRepeatMax As DataGridViewTextBoxColumn
    Friend WithEvents colReminderRepeatElapsed As DataGridViewTextBoxColumn
    Friend WithEvents colReminderStatus As DataGridViewTextBoxColumn
    Friend WithEvents colIntervalDuration As DataGridViewTextBoxColumn
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
End Class
