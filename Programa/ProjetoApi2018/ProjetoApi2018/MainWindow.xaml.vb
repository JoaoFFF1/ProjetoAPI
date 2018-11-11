Imports WsServerStuff

Class MainWindow

    Dim client As New Client

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        client.SendKey("chat")
        lst1.Items.Add(Client.Chat(txt1.Text))
        txt1.Clear()
    End Sub
End Class