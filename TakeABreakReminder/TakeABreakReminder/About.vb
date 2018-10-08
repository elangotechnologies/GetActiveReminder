Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub About_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class