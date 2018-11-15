Imports WsServerStuff

Module Module1

    Sub Main()

        Dim server As New Server
        Dim client As New Client
        Dim name As String
        Dim pass As String
        Dim users As New Dictionary(Of String, User)

        While True

            Select Case server.Income()
                Case "chat"
                    Server.ChatServer()

                    Exit While
                    'Exit Select
                Case "register"
                    name = server.Income()
                    client.SendKey("ready")
                    pass = server.Income()
                    Console.WriteLine(name & " " & pass)

                    Exit While
                    'Exit Select
            End Select
            Exit While

        End While

    End Sub

End Module
