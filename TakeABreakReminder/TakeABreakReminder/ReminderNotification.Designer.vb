﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReminderNotification
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
        Me.timerClose = New System.Windows.Forms.Timer(Me.components)
        Me.LblClose = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.timerFade = New System.Windows.Forms.Timer(Me.components)
        Me.timerSlideIn = New System.Windows.Forms.Timer(Me.components)
        Me.timerSlideInBack = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelNotificationHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblReminderId = New System.Windows.Forms.Label()
        Me.lblcloseTimeCounter = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblReminderType = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelNotificationHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerClose
        '
        Me.timerClose.Interval = 1000
        '
        'LblClose
        '
        Me.LblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClose.ForeColor = System.Drawing.Color.Snow
        Me.LblClose.Location = New System.Drawing.Point(702, 10)
        Me.LblClose.Name = "LblClose"
        Me.LblClose.Size = New System.Drawing.Size(22, 23)
        Me.LblClose.TabIndex = 0
        Me.LblClose.Text = "X"
        Me.LblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(0, 0)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(3)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(686, 186)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerFade
        '
        '
        'timerSlideIn
        '
        Me.timerSlideIn.Interval = 50
        '
        'timerSlideInBack
        '
        Me.timerSlideInBack.Interval = 50
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 10)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.panelNotificationHeader)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(686, 212)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblMessage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 186)
        Me.Panel1.TabIndex = 0
        '
        'panelNotificationHeader
        '
        Me.panelNotificationHeader.Controls.Add(Me.lblReminderType)
        Me.panelNotificationHeader.Controls.Add(Me.Label5)
        Me.panelNotificationHeader.Controls.Add(Me.lblcloseTimeCounter)
        Me.panelNotificationHeader.Controls.Add(Me.Label3)
        Me.panelNotificationHeader.Controls.Add(Me.lblReminderId)
        Me.panelNotificationHeader.Controls.Add(Me.Label1)
        Me.panelNotificationHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelNotificationHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelNotificationHeader.Name = "panelNotificationHeader"
        Me.panelNotificationHeader.Size = New System.Drawing.Size(686, 25)
        Me.panelNotificationHeader.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id :"
        '
        'lblReminderId
        '
        Me.lblReminderId.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderId.Location = New System.Drawing.Point(39, 0)
        Me.lblReminderId.Name = "lblReminderId"
        Me.lblReminderId.Size = New System.Drawing.Size(55, 23)
        Me.lblReminderId.TabIndex = 1
        Me.lblReminderId.Text = "00"
        '
        'lblcloseTimeCounter
        '
        Me.lblcloseTimeCounter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcloseTimeCounter.Location = New System.Drawing.Point(362, 0)
        Me.lblcloseTimeCounter.Name = "lblcloseTimeCounter"
        Me.lblcloseTimeCounter.Size = New System.Drawing.Size(96, 23)
        Me.lblcloseTimeCounter.TabIndex = 3
        Me.lblcloseTimeCounter.Text = "0"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Closes In :"
        '
        'lblReminderType
        '
        Me.lblReminderType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminderType.Location = New System.Drawing.Point(162, 0)
        Me.lblReminderType.Name = "lblReminderType"
        Me.lblReminderType.Size = New System.Drawing.Size(83, 23)
        Me.lblReminderType.TabIndex = 5
        Me.lblReminderType.Text = " Interval"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Type :"
        '
        'ReminderNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepPink
        Me.ClientSize = New System.Drawing.Size(726, 232)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.LblClose)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReminderNotification"
        Me.Padding = New System.Windows.Forms.Padding(10, 10, 30, 10)
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ToastNotificationForm"
        Me.TopMost = True
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.panelNotificationHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerClose As Timer
    Friend WithEvents LblClose As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents timerFade As Timer
    Friend WithEvents timerSlideIn As Timer
    Friend WithEvents timerSlideInBack As Timer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelNotificationHeader As Panel
    Friend WithEvents lblReminderId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblReminderType As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblcloseTimeCounter As Label
    Friend WithEvents Label3 As Label
End Class
