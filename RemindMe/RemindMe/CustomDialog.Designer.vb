<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomDialog
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
        Me.btnOption1 = New System.Windows.Forms.Button()
        Me.btnOption2 = New System.Windows.Forms.Button()
        Me.btnOption3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOption1
        '
        Me.btnOption1.BackColor = System.Drawing.Color.Green
        Me.btnOption1.FlatAppearance.BorderSize = 0
        Me.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOption1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption1.ForeColor = System.Drawing.Color.White
        Me.btnOption1.Location = New System.Drawing.Point(25, 22)
        Me.btnOption1.Name = "btnOption1"
        Me.btnOption1.Size = New System.Drawing.Size(274, 51)
        Me.btnOption1.TabIndex = 0
        Me.btnOption1.Text = "Option1"
        Me.btnOption1.UseVisualStyleBackColor = False
        '
        'btnOption2
        '
        Me.btnOption2.BackColor = System.Drawing.Color.Red
        Me.btnOption2.FlatAppearance.BorderSize = 0
        Me.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOption2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption2.ForeColor = System.Drawing.Color.Maroon
        Me.btnOption2.Location = New System.Drawing.Point(338, 22)
        Me.btnOption2.Name = "btnOption2"
        Me.btnOption2.Size = New System.Drawing.Size(274, 51)
        Me.btnOption2.TabIndex = 1
        Me.btnOption2.Text = "Option2"
        Me.btnOption2.UseVisualStyleBackColor = False
        '
        'btnOption3
        '
        Me.btnOption3.BackColor = System.Drawing.Color.Gold
        Me.btnOption3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOption3.FlatAppearance.BorderSize = 0
        Me.btnOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOption3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption3.ForeColor = System.Drawing.Color.Olive
        Me.btnOption3.Location = New System.Drawing.Point(651, 22)
        Me.btnOption3.Name = "btnOption3"
        Me.btnOption3.Size = New System.Drawing.Size(274, 51)
        Me.btnOption3.TabIndex = 2
        Me.btnOption3.Text = "Option3"
        Me.btnOption3.UseVisualStyleBackColor = False
        '
        'CustomDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOption3
        Me.ClientSize = New System.Drawing.Size(940, 96)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOption3)
        Me.Controls.Add(Me.btnOption2)
        Me.Controls.Add(Me.btnOption1)
        Me.Name = "CustomDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CustomDialog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOption1 As Button
    Friend WithEvents btnOption2 As Button
    Friend WithEvents btnOption3 As Button
End Class
