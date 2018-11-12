Imports WsServerStuff

Module Module1

    Sub Main()

        Dim server As New Server

        'While True
        '    Server.ChatServer()
        'End While
        While True

            Select Case server.Income()
                Case "chat"
                    Server.ChatServer()
                    Exit Select

                Case "register"

                    Exit Select
            End Select
            Exit While

        End While

    End Sub

End Module
