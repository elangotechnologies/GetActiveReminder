Public Class CustomDialog
    Public Const OPTION_ONE As Integer = 1
    Public Const OPTION_TWO As Integer = 2
    Public Const OPTION_THREE As Integer = 3

    Public Function showMyDialog(titleStr As String, option1Str As String, option2Str As String, option3Str As String) As Integer
        Me.Text = titleStr
        btnOption1.Text = option1Str
        btnOption2.Text = option2Str
        btnOption3.Text = option3Str

        Return Me.ShowDialog()

    End Function

    Private Sub btnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        Me.DialogResult = OPTION_ONE
        Me.Close()
    End Sub
    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        Me.DialogResult = OPTION_TWO
        Me.Close()
    End Sub
    Private Sub btnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        Me.DialogResult = OPTION_THREE
        Me.Close()
    End Sub

    Private Sub Me_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class