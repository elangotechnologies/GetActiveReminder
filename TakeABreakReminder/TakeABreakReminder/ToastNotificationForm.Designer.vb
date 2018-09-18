<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToastNotificationForm
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
        Me.SuspendLayout()
        '
        'timerClose
        '
        '
        'LblClose
        '
        Me.LblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClose.ForeColor = System.Drawing.Color.Snow
        Me.LblClose.Location = New System.Drawing.Point(557, 3)
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
        Me.lblMessage.Location = New System.Drawing.Point(10, 10)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(3)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(540, 44)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerFade
        '
        '
        'ToastNotificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepPink
        Me.ClientSize = New System.Drawing.Size(580, 64)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.LblClose)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ToastNotificationForm"
        Me.Padding = New System.Windows.Forms.Padding(10, 10, 30, 10)
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ToastNotificationForm"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerClose As Timer
    Friend WithEvents LblClose As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents timerFade As Timer
End Class
