Imports WsServerStuff

Public Class ChatWindow

    Dim login As New TestWindoh
    Dim client As New Client

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        client.SendKey("chat")
        lst1.Items.Add(Client.Chat(txt1.Text))
        txt1.Clear()
    End Sub

    Private Sub btnGotoLogin_Click(sender As Object, e As RoutedEventArgs) Handles btnGotoLogin.Click

        login.Show()
        Me.Hide()
    End Sub
End Class