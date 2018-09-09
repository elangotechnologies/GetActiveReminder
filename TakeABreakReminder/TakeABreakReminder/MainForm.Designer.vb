<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.timerReminder = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.trackBarSeconds = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.trackBarMinutes = New System.Windows.Forms.TrackBar()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblMidTimeValue = New System.Windows.Forms.Label()
        Me.lblMaxTimeValue = New System.Windows.Forms.Label()
        Me.lblMinTimeValue = New System.Windows.Forms.Label()
        Me.trackBarHours = New System.Windows.Forms.TrackBar()
        Me.Lable1 = New System.Windows.Forms.Label()
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
        Me.cmbNotificationDuration = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.trackBarSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextMenuForTrayIcon.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStartStop
        '
        Me.btnStartStop.BackColor = System.Drawing.Color.DarkCyan
        Me.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartStop.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStop.ForeColor = System.Drawing.Color.White
        Me.btnStartStop.Location = New System.Drawing.Point(500, 209)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(176, 41)
        Me.btnStartStop.TabIndex = 0
        Me.btnStartStop.Text = "Start Reminder"
        Me.btnStartStop.UseVisualStyleBackColor = False
        '
        'timerReminder
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.trackBarSeconds)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.trackBarMinutes)
        Me.GroupBox1.Controls.Add(Me.lblSeconds)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblMinutes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblHours)
        Me.GroupBox1.Controls.Add(Me.lblMidTimeValue)
        Me.GroupBox1.Controls.Add(Me.lblMaxTimeValue)
        Me.GroupBox1.Controls.Add(Me.lblMinTimeValue)
        Me.GroupBox1.Controls.Add(Me.trackBarHours)
        Me.GroupBox1.Controls.Add(Me.Lable1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1098, 154)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reminder Interval"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(887, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "30"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(1022, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "59"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(746, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "0"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trackBarSeconds
        '
        Me.trackBarSeconds.Location = New System.Drawing.Point(765, 46)
        Me.trackBarSeconds.Maximum = 59
        Me.trackBarSeconds.Name = "trackBarSeconds"
        Me.trackBarSeconds.Size = New System.Drawing.Size(302, 45)
        Me.trackBarSeconds.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(510, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "30"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(645, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "59"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(370, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "0"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trackBarMinutes
        '
        Me.trackBarMinutes.Location = New System.Drawing.Point(388, 46)
        Me.trackBarMinutes.Maximum = 59
        Me.trackBarMinutes.Name = "trackBarMinutes"
        Me.trackBarMinutes.Size = New System.Drawing.Size(302, 45)
        Me.trackBarMinutes.TabIndex = 22
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblSeconds.Location = New System.Drawing.Point(842, 109)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(30, 22)
        Me.lblSeconds.TabIndex = 21
        Me.lblSeconds.Text = "00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label11.Location = New System.Drawing.Point(890, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 22)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "SECONDS"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblMinutes.Location = New System.Drawing.Point(460, 109)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(30, 22)
        Me.lblMinutes.TabIndex = 15
        Me.lblMinutes.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label6.Location = New System.Drawing.Point(508, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "MINUTES"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblHours.Location = New System.Drawing.Point(111, 109)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(30, 22)
        Me.lblHours.TabIndex = 9
        Me.lblHours.Text = "00"
        '
        'lblMidTimeValue
        '
        Me.lblMidTimeValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMidTimeValue.Location = New System.Drawing.Point(144, 74)
        Me.lblMidTimeValue.Name = "lblMidTimeValue"
        Me.lblMidTimeValue.Size = New System.Drawing.Size(64, 17)
        Me.lblMidTimeValue.TabIndex = 8
        Me.lblMidTimeValue.Text = "12"
        Me.lblMidTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaxTimeValue
        '
        Me.lblMaxTimeValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMaxTimeValue.Location = New System.Drawing.Point(277, 74)
        Me.lblMaxTimeValue.Name = "lblMaxTimeValue"
        Me.lblMaxTimeValue.Size = New System.Drawing.Size(64, 17)
        Me.lblMaxTimeValue.TabIndex = 7
        Me.lblMaxTimeValue.Text = "23"
        Me.lblMaxTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinTimeValue
        '
        Me.lblMinTimeValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMinTimeValue.Location = New System.Drawing.Point(2, 74)
        Me.lblMinTimeValue.Name = "lblMinTimeValue"
        Me.lblMinTimeValue.Size = New System.Drawing.Size(64, 17)
        Me.lblMinTimeValue.TabIndex = 6
        Me.lblMinTimeValue.Text = "0"
        Me.lblMinTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trackBarHours
        '
        Me.trackBarHours.Location = New System.Drawing.Point(20, 46)
        Me.trackBarHours.Maximum = 23
        Me.trackBarHours.Name = "trackBarHours"
        Me.trackBarHours.Size = New System.Drawing.Size(302, 45)
        Me.trackBarHours.TabIndex = 4
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Lable1.Location = New System.Drawing.Point(159, 109)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(75, 22)
        Me.Lable1.TabIndex = 5
        Me.Lable1.Text = "HOURS"
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
        Me.statusRemainingTime.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.statusRemainingTime.ForeColor = System.Drawing.Color.Red
        Me.statusRemainingTime.Name = "statusRemainingTime"
        Me.statusRemainingTime.Size = New System.Drawing.Size(202, 25)
        Me.statusRemainingTime.Text = "No Reminder Running"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusRemainingTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 271)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1391, 30)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'cmbNotificationDuration
        '
        Me.cmbNotificationDuration.DisplayMember = "Value"
        Me.cmbNotificationDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNotificationDuration.FormattingEnabled = True
        Me.cmbNotificationDuration.Location = New System.Drawing.Point(1170, 90)
        Me.cmbNotificationDuration.Name = "cmbNotificationDuration"
        Me.cmbNotificationDuration.Size = New System.Drawing.Size(197, 28)
        Me.cmbNotificationDuration.TabIndex = 8
        Me.cmbNotificationDuration.ValueMember = "Key"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(1166, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Notification Duration"
        '
        'FrmMain
        '
        Me.AcceptButton = Me.btnStartStop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(1391, 301)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNotificationDuration)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStartStop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "Take A Break Reminder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.trackBarSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextMenuForTrayIcon.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartStop As Button
    Friend WithEvents timerReminder As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents statusLblTimerStatus As ToolStripStatusLabel
    Friend WithEvents timerStatusUpdater As Timer
    Friend WithEvents lblMidTimeValue As Label
    Friend WithEvents lblMaxTimeValue As Label
    Friend WithEvents lblMinTimeValue As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents trackBarSeconds As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents trackBarMinutes As TrackBar
    Friend WithEvents lblSeconds As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents trackBarHours As TrackBar
    Friend WithEvents Lable1 As Label
    Friend WithEvents trayIcon As NotifyIcon
    Friend WithEvents contextMenuForTrayIcon As ContextMenuStrip
    Friend WithEvents menuItemExit As ToolStripMenuItem
    Friend WithEvents menuItemStopReminder As ToolStripMenuItem
    Friend WithEvents menuItemShowApp As ToolStripMenuItem
    Friend WithEvents timerStatusBarUpdater As Timer
    Friend WithEvents statusRemainingTime As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents cmbNotificationDuration As ComboBox
    Friend WithEvents Label1 As Label
End Class
