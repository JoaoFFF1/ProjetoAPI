Public Class TestWindoh

    Dim chat As New ChatWindow

    Private Sub btnGotoLogin_Click(sender As Object, e As RoutedEventArgs) Handles btnGotoLogin.Click

        chat.Show()
        Me.Hide()
    End Sub
End Class
