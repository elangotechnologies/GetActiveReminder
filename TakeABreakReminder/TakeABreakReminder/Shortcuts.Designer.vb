<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shortcuts
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgShortcutKeys = New System.Windows.Forms.DataGridView()
        Me.shortcut_key = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shortcut_function = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shortcut_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgShortcutKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgShortcutKeys
        '
        Me.dgShortcutKeys.AllowUserToAddRows = False
        Me.dgShortcutKeys.AllowUserToDeleteRows = False
        Me.dgShortcutKeys.AllowUserToOrderColumns = True
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgShortcutKeys.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgShortcutKeys.BackgroundColor = System.Drawing.Color.White
        Me.dgShortcutKeys.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgShortcutKeys.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgShortcutKeys.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgShortcutKeys.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgShortcutKeys.ColumnHeadersHeight = 30
        Me.dgShortcutKeys.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.shortcut_key, Me.shortcut_function, Me.shortcut_description})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgShortcutKeys.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgShortcutKeys.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgShortcutKeys.EnableHeadersVisualStyles = False
        Me.dgShortcutKeys.GridColor = System.Drawing.Color.DarkGray
        Me.dgShortcutKeys.Location = New System.Drawing.Point(0, 0)
        Me.dgShortcutKeys.MultiSelect = False
        Me.dgShortcutKeys.Name = "dgShortcutKeys"
        Me.dgShortcutKeys.ReadOnly = True
        Me.dgShortcutKeys.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgShortcutKeys.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgShortcutKeys.RowHeadersVisible = False
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Teal
        Me.dgShortcutKeys.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgShortcutKeys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgShortcutKeys.Size = New System.Drawing.Size(750, 302)
        Me.dgShortcutKeys.TabIndex = 1
        '
        'shortcut_key
        '
        Me.shortcut_key.DataPropertyName = "shortcut_key"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.shortcut_key.DefaultCellStyle = DataGridViewCellStyle10
        Me.shortcut_key.Frozen = True
        Me.shortcut_key.HeaderText = "Shortcut Key"
        Me.shortcut_key.Name = "shortcut_key"
        Me.shortcut_key.ReadOnly = True
        Me.shortcut_key.Width = 130
        '
        'shortcut_function
        '
        Me.shortcut_function.DataPropertyName = "shortcut_function"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.shortcut_function.DefaultCellStyle = DataGridViewCellStyle11
        Me.shortcut_function.Frozen = True
        Me.shortcut_function.HeaderText = "Function"
        Me.shortcut_function.Name = "shortcut_function"
        Me.shortcut_function.ReadOnly = True
        Me.shortcut_function.Width = 130
        '
        'shortcut_description
        '
        Me.shortcut_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.shortcut_description.DataPropertyName = "shortcut_description"
        Me.shortcut_description.HeaderText = "Description"
        Me.shortcut_description.Name = "shortcut_description"
        Me.shortcut_description.ReadOnly = True
        Me.shortcut_description.Width = 115
        '
        'Shortcuts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 302)
        Me.Controls.Add(Me.dgShortcutKeys)
        Me.KeyPreview = True
        Me.Name = "Shortcuts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Shortcuts"
        CType(Me.dgShortcutKeys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgShortcutKeys As DataGridView
    Friend WithEvents shortcut_key As DataGridViewTextBoxColumn
    Friend WithEvents shortcut_function As DataGridViewTextBoxColumn
    Friend WithEvents shortcut_description As DataGridViewTextBoxColumn
End Class
