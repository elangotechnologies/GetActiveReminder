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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.timerReminder = New System.Windows.Forms.Timer(Me.components)
        Me.statusLblTimerStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timerStatusUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextMenuForTrayIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemStopReminder = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemShowApp = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerStatusBarUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.statusRemainingTime = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.grpIntervalDuration = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.numSeconds = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.numMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgReminderDetails = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAddReminder = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.colReminderType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderCreateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderLastUpdatedTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReminderLastNotified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationMessage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationFont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationBackColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationForeColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotificationHeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.contextMenuForTrayIcon.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.grpPopupSettings.SuspendLayout()
        CType(Me.numNotificationHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNotificationWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIntervalDuration.SuspendLayout()
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReminderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStartStop
        '
        Me.btnStartStop.BackColor = System.Drawing.Color.DarkCyan
        Me.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartStop.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStop.ForeColor = System.Drawing.Color.White
        Me.btnStartStop.Location = New System.Drawing.Point(59, 470)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(176, 41)
        Me.btnStartStop.TabIndex = 0
        Me.btnStartStop.Text = "Start Reminder"
        Me.btnStartStop.UseVisualStyleBackColor = False
        '
        'timerReminder
        '
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
        Me.contextMenuForTrayIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemExit, Me.menuItemStopReminder, Me.menuItemShowApp})
        Me.contextMenuForTrayIcon.Name = "ShowWindowToolStripMenuItem"
        Me.contextMenuForTrayIcon.Size = New System.Drawing.Size(168, 70)
        '
        'menuItemExit
        '
        Me.menuItemExit.Name = "menuItemExit"
        Me.menuItemExit.Size = New System.Drawing.Size(167, 22)
        Me.menuItemExit.Text = "Exit"
        '
        'menuItemStopReminder
        '
        Me.menuItemStopReminder.Name = "menuItemStopReminder"
        Me.menuItemStopReminder.Size = New System.Drawing.Size(167, 22)
        Me.menuItemStopReminder.Text = "Stop Reminder"
        '
        'menuItemShowApp
        '
        Me.menuItemShowApp.Name = "menuItemShowApp"
        Me.menuItemShowApp.Size = New System.Drawing.Size(167, 22)
        Me.menuItemShowApp.Text = "Show Application"
        '
        'timerStatusBarUpdater
        '
        Me.timerStatusBarUpdater.Interval = 1000
        '
        'statusRemainingTime
        '
        Me.statusRemainingTime.BackColor = System.Drawing.Color.Transparent
        Me.statusRemainingTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.statusRemainingTime.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.statusRemainingTime.ForeColor = System.Drawing.Color.Red
        Me.statusRemainingTime.Name = "statusRemainingTime"
        Me.statusRemainingTime.Size = New System.Drawing.Size(226, 25)
        Me.statusRemainingTime.Text = "Reminder not started yet"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusRemainingTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 932)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1227, 30)
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
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Fore Color"
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
        Me.txtNotificationMessage.Text = ""
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
        Me.cmbNotificationDuration.DisplayMember = "Value"
        Me.cmbNotificationDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbNotificationDuration.FormattingEnabled = True
        Me.cmbNotificationDuration.Location = New System.Drawing.Point(151, 54)
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
        Me.txtNotificaitonFont.Text = ""
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
        Me.grpPopupSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpPopupSettings.ForeColor = System.Drawing.Color.White
        Me.grpPopupSettings.Location = New System.Drawing.Point(434, 27)
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
        Me.numNotificationHeight.Name = "numNotificationHeight"
        Me.numNotificationHeight.Size = New System.Drawing.Size(406, 26)
        Me.numNotificationHeight.TabIndex = 64
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
        Me.numNotificationWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numNotificationWidth.Name = "numNotificationWidth"
        Me.numNotificationWidth.Size = New System.Drawing.Size(406, 26)
        Me.numNotificationWidth.TabIndex = 38
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
        Me.colorPickerForeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.colorPickerForeColor.Location = New System.Drawing.Point(151, 338)
        Me.colorPickerForeColor.Name = "colorPickerForeColor"
        Me.colorPickerForeColor.Size = New System.Drawing.Size(406, 28)
        Me.colorPickerForeColor.TabIndex = 62
        '
        'colorPickerBackColor
        '
        Me.colorPickerBackColor.Appearance = ElaColorChooser.ElaColorPicker.ColorPickerAppearance.EditableComboBox
        Me.colorPickerBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.colorPickerBackColor.Location = New System.Drawing.Point(151, 293)
        Me.colorPickerBackColor.Name = "colorPickerBackColor"
        Me.colorPickerBackColor.Size = New System.Drawing.Size(406, 28)
        Me.colorPickerBackColor.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(562, 529)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(415, 20)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "* All data from this screen are auto saved"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(562, 552)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(430, 37)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "* Notification Sound and Duration changes will reflect on upcoming notification. " &
    "All other settings will reflect in active notification itself."
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
        'grpIntervalDuration
        '
        Me.grpIntervalDuration.BackColor = System.Drawing.Color.Transparent
        Me.grpIntervalDuration.Controls.Add(Me.Label19)
        Me.grpIntervalDuration.Controls.Add(Me.numSeconds)
        Me.grpIntervalDuration.Controls.Add(Me.Label18)
        Me.grpIntervalDuration.Controls.Add(Me.numMinutes)
        Me.grpIntervalDuration.Controls.Add(Me.Label17)
        Me.grpIntervalDuration.Controls.Add(Me.numHours)
        Me.grpIntervalDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.grpIntervalDuration.ForeColor = System.Drawing.Color.White
        Me.grpIntervalDuration.Location = New System.Drawing.Point(41, 189)
        Me.grpIntervalDuration.Name = "grpIntervalDuration"
        Me.grpIntervalDuration.Size = New System.Drawing.Size(229, 113)
        Me.grpIntervalDuration.TabIndex = 30
        Me.grpIntervalDuration.TabStop = False
        Me.grpIntervalDuration.Text = "Duration"
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
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgReminderDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgReminderDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgReminderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgReminderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReminderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgReminderDetails.ColumnHeadersHeight = 65
        Me.dgReminderDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReminderType, Me.colReminderCreateTime, Me.colReminderLastUpdatedTime, Me.colReminderStartTime, Me.colReminderLastNotified, Me.colNotificationDuration, Me.colNotificationMessage, Me.colNotificationFont, Me.colNotificationBackColor, Me.colNotificationForeColor, Me.colNotificationWidth, Me.colNotificationHeight})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReminderDetails.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgReminderDetails.EnableHeadersVisualStyles = False
        Me.dgReminderDetails.GridColor = System.Drawing.Color.Blue
        Me.dgReminderDetails.Location = New System.Drawing.Point(13, 632)
        Me.dgReminderDetails.MultiSelect = False
        Me.dgReminderDetails.Name = "dgReminderDetails"
        Me.dgReminderDetails.ReadOnly = True
        Me.dgReminderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReminderDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgReminderDetails.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Teal
        Me.dgReminderDetails.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgReminderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReminderDetails.Size = New System.Drawing.Size(1131, 215)
        Me.dgReminderDetails.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(59, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 41)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Save Reminder"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(59, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 41)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Get Reminder"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAddReminder
        '
        Me.btnAddReminder.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddReminder.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddReminder.ForeColor = System.Drawing.Color.White
        Me.btnAddReminder.Location = New System.Drawing.Point(59, 403)
        Me.btnAddReminder.Name = "btnAddReminder"
        Me.btnAddReminder.Size = New System.Drawing.Size(176, 41)
        Me.btnAddReminder.TabIndex = 36
        Me.btnAddReminder.Tag = "CreationNotInProgress"
        Me.btnAddReminder.Text = "Add Reminder"
        Me.btnAddReminder.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkCyan
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(59, 539)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(176, 41)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Delete Reminder"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'colReminderType
        '
        Me.colReminderType.DataPropertyName = "notification_type"
        Me.colReminderType.HeaderText = "Type"
        Me.colReminderType.Name = "colReminderType"
        Me.colReminderType.ReadOnly = True
        '
        'colReminderCreateTime
        '
        Me.colReminderCreateTime.DataPropertyName = "Reminder_created_time"
        Me.colReminderCreateTime.HeaderText = "Created Time"
        Me.colReminderCreateTime.Name = "colReminderCreateTime"
        Me.colReminderCreateTime.ReadOnly = True
        '
        'colReminderLastUpdatedTime
        '
        Me.colReminderLastUpdatedTime.DataPropertyName = "Reminder_updated_time"
        Me.colReminderLastUpdatedTime.HeaderText = "Last Updated Time"
        Me.colReminderLastUpdatedTime.Name = "colReminderLastUpdatedTime"
        Me.colReminderLastUpdatedTime.ReadOnly = True
        '
        'colReminderStartTime
        '
        Me.colReminderStartTime.DataPropertyName = "Reminder_Started_time"
        Me.colReminderStartTime.HeaderText = "Started Time"
        Me.colReminderStartTime.Name = "colReminderStartTime"
        Me.colReminderStartTime.ReadOnly = True
        '
        'colReminderLastNotified
        '
        Me.colReminderLastNotified.DataPropertyName = "Reminder_notified_time"
        Me.colReminderLastNotified.HeaderText = "Last Notified Time"
        Me.colReminderLastNotified.Name = "colReminderLastNotified"
        Me.colReminderLastNotified.ReadOnly = True
        '
        'colNotificationDuration
        '
        Me.colNotificationDuration.DataPropertyName = "notification_duration"
        Me.colNotificationDuration.HeaderText = "Notification Duration"
        Me.colNotificationDuration.Name = "colNotificationDuration"
        Me.colNotificationDuration.ReadOnly = True
        '
        'colNotificationMessage
        '
        Me.colNotificationMessage.DataPropertyName = "notification_message"
        Me.colNotificationMessage.HeaderText = "Notification Message"
        Me.colNotificationMessage.Name = "colNotificationMessage"
        Me.colNotificationMessage.ReadOnly = True
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
        Me.colNotificationBackColor.HeaderText = "Notification Back Color"
        Me.colNotificationBackColor.Name = "colNotificationBackColor"
        Me.colNotificationBackColor.ReadOnly = True
        '
        'colNotificationForeColor
        '
        Me.colNotificationForeColor.DataPropertyName = "notification_forecolor"
        Me.colNotificationForeColor.HeaderText = "Notification Fore Color"
        Me.colNotificationForeColor.Name = "colNotificationForeColor"
        Me.colNotificationForeColor.ReadOnly = True
        '
        'colNotificationWidth
        '
        Me.colNotificationWidth.DataPropertyName = "notification_width"
        Me.colNotificationWidth.HeaderText = "Notification Width"
        Me.colNotificationWidth.Name = "colNotificationWidth"
        Me.colNotificationWidth.ReadOnly = True
        '
        'colNotificationHeight
        '
        Me.colNotificationHeight.DataPropertyName = "notification_height"
        Me.colNotificationHeight.HeaderText = "Notification Height"
        Me.colNotificationHeight.Name = "colNotificationHeight"
        Me.colNotificationHeight.ReadOnly = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkCyan
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(252, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 41)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Delete All"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FrmMain
        '
        Me.AcceptButton = Me.btnStartStop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1227, 962)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnAddReminder)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgReminderDetails)
        Me.Controls.Add(Me.grpIntervalDuration)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grpPopupSettings)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnStartStop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Opacity = 0.97R
        Me.Text = "Take A Break Reminder"
        Me.contextMenuForTrayIcon.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpPopupSettings.ResumeLayout(False)
        Me.grpPopupSettings.PerformLayout()
        CType(Me.numNotificationHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNotificationWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIntervalDuration.ResumeLayout(False)
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReminderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartStop As Button
    Friend WithEvents timerReminder As Timer
    Friend WithEvents statusLblTimerStatus As ToolStripStatusLabel
    Friend WithEvents timerStatusUpdater As Timer
    Friend WithEvents trayIcon As NotifyIcon
    Friend WithEvents contextMenuForTrayIcon As ContextMenuStrip
    Friend WithEvents menuItemExit As ToolStripMenuItem
    Friend WithEvents menuItemStopReminder As ToolStripMenuItem
    Friend WithEvents menuItemShowApp As ToolStripMenuItem
    Friend WithEvents timerStatusBarUpdater As Timer
    Friend WithEvents statusRemainingTime As ToolStripStatusLabel
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
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents numHours As NumericUpDown
    Friend WithEvents grpIntervalDuration As GroupBox
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAddReminder As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents colReminderType As DataGridViewTextBoxColumn
    Friend WithEvents colReminderCreateTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderLastUpdatedTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderStartTime As DataGridViewTextBoxColumn
    Friend WithEvents colReminderLastNotified As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationDuration As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationMessage As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationFont As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationBackColor As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationForeColor As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationWidth As DataGridViewTextBoxColumn
    Friend WithEvents colNotificationHeight As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
End Class
