Imports WsServerStuff

Class MainWindow

    Dim client As New Client

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        lst1.Items.Add(Client.Send(txt1.Text))
        txt1.Clear()
    End Sub
End Class