Imports WsServerStuff

Module Module1

    Sub Main()

        Dim users As New Dictionary(Of String, User)
        Dim name As String = ""
        Dim pass As String = ""

        While True
            Console.WriteLine(">> Entrou no while")

            Select Case Server.Income()

                Case "chat"
                    Console.WriteLine(">> key recebida: chat")

                    Server.ChatServer()
                    Console.WriteLine("{ChatServer}: concluido, saindo do select case")

                    Exit While
                Case "register"
                    Console.WriteLine(">> key recebida: register")

                    Server.InRegister(name, pass)
                    Console.WriteLine("{InRegister}: concluido")

                    Console.WriteLine(name & " " & pass)
                    Console.WriteLine(">> saindo do select case")

                    Exit Select
            End Select
            Console.WriteLine(">> saindo do while")

            Exit While

        End While

    End Sub

End Module
