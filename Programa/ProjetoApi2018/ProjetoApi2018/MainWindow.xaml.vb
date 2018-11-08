Imports WsServerStuff

Class MainWindow

    Dim client As New Client

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        lst1.Items.Add(client.Chat(txt1.Text))
        txt1.Clear()
    End Sub
End Class