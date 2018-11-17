Imports WsServerStuff

Module Module1

    Sub Main()

        Dim users As New Dictionary(Of String, User)
        Dim name As String = ""
        Dim pass As String = ""

        While True

            Select Case server.Income()
                Case "chat"
                    Server.ChatServer()

                    Exit While
                    'Exit Select
                Case "register"

                    Server.InRegister(name, pass)

                    Console.WriteLine(name & " " & pass)

                    Exit While
                    'Exit Select
            End Select
            Exit While

        End While

    End Sub

End Module
