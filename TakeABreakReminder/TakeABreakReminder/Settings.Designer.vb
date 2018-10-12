<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.chkStartOnBoot = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radExitOnClose = New System.Windows.Forms.RadioButton()
        Me.radMinimizeOnClose = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkNotifyOnMinimize = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkConfirmDeletion = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkStartOnBoot
        '
        Me.chkStartOnBoot.AutoSize = True
        Me.chkStartOnBoot.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStartOnBoot.Location = New System.Drawing.Point(52, 35)
        Me.chkStartOnBoot.Name = "chkStartOnBoot"
        Me.chkStartOnBoot.Size = New System.Drawing.Size(285, 23)
        Me.chkStartOnBoot.TabIndex = 0
        Me.chkStartOnBoot.Text = "Start RemindMe on Windows Startup"
        Me.chkStartOnBoot.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkStartOnBoot)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1068, 116)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Windows Startup"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(69, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(976, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.radExitOnClose)
        Me.GroupBox3.Controls.Add(Me.radMinimizeOnClose)
        Me.GroupBox3.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 162)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1068, 198)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Close Button Behavior"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(69, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(976, 38)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Exits the application. Application will not be running in the background. This is" &
    " not recommended since none of the reminders will be shown as the application is" &
    " not running."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(69, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(976, 38)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Minimizes the application to system tray. It doesn't close the application. The a" &
    "pplicatio still continuos to run in the backgroud. This is recommended to not to" &
    " miss any reminders."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'radExitOnClose
        '
        Me.radExitOnClose.AutoSize = True
        Me.radExitOnClose.Location = New System.Drawing.Point(52, 116)
        Me.radExitOnClose.Name = "radExitOnClose"
        Me.radExitOnClose.Size = New System.Drawing.Size(161, 23)
        Me.radExitOnClose.TabIndex = 7
        Me.radExitOnClose.TabStop = True
        Me.radExitOnClose.Text = "Exit the Application"
        Me.radExitOnClose.UseVisualStyleBackColor = True
        '
        'radMinimizeOnClose
        '
        Me.radMinimizeOnClose.AutoSize = True
        Me.radMinimizeOnClose.Location = New System.Drawing.Point(52, 37)
        Me.radMinimizeOnClose.Name = "radMinimizeOnClose"
        Me.radMinimizeOnClose.Size = New System.Drawing.Size(195, 23)
        Me.radMinimizeOnClose.TabIndex = 5
        Me.radMinimizeOnClose.TabStop = True
        Me.radMinimizeOnClose.Text = "Minimize to System Tray"
        Me.radMinimizeOnClose.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkNotifyOnMinimize)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 386)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1068, 101)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "On Application Minimized to System Tray"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(69, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(976, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Notifies you with a small popup whenever you  minimize the application.  If you d" &
    "isable this then the application will be silently minimized to system tray."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkNotifyOnMinimize
        '
        Me.chkNotifyOnMinimize.AutoSize = True
        Me.chkNotifyOnMinimize.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotifyOnMinimize.Location = New System.Drawing.Point(52, 38)
        Me.chkNotifyOnMinimize.Name = "chkNotifyOnMinimize"
        Me.chkNotifyOnMinimize.Size = New System.Drawing.Size(396, 23)
        Me.chkNotifyOnMinimize.TabIndex = 0
        Me.chkNotifyOnMinimize.Text = "Notify About the Application Running on System Tray"
        Me.chkNotifyOnMinimize.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.chkConfirmDeletion)
        Me.GroupBox4.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 523)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1068, 98)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Deleting Reminder"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(69, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(976, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Asks you to confirm the deletion to avoid deletion by mistake. Recommended to kee" &
    "p it enabled." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkConfirmDeletion
        '
        Me.chkConfirmDeletion.AutoSize = True
        Me.chkConfirmDeletion.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConfirmDeletion.Location = New System.Drawing.Point(52, 38)
        Me.chkConfirmDeletion.Name = "chkConfirmDeletion"
        Me.chkConfirmDeletion.Size = New System.Drawing.Size(180, 23)
        Me.chkConfirmDeletion.TabIndex = 0
        Me.chkConfirmDeletion.Text = "Confirm before delete"
        Me.chkConfirmDeletion.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 893)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkStartOnBoot As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents radExitOnClose As RadioButton
    Friend WithEvents radMinimizeOnClose As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkNotifyOnMinimize As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkConfirmDeletion As CheckBox
End Class
