Imports WsServerStuff

Module Module1

    Dim client As New Client
    Dim server As New Server
    Dim users As New Dictionary(Of String, User)
    Dim names() As String

    Sub main()

        Console.Clear()
        Console.WriteLine("«===MENU===»")
        Console.WriteLine("(1) » Chat")
        Console.WriteLine("(2) » Login")
        Console.WriteLine("(3) » Registar")
        Console.WriteLine("«===MENU===»")

        While True
            Dim resultado As String = Console.ReadLine()

            Select Case resultado
                Case "1"

                    client.SendKey("chat")
                    While True

                        Client.Chat(Console.ReadLine())
                    End While
                    Exit While
                Case "2"

                    'Console.Write("User: ")
                    'nome = Console.ReadLine()
                    'Console.Write("Pass: ")
                    'pass = Console.ReadLine()

                Case "3"
                    Client.SendKey("register")

                    Console.Write("Nome: ")
                    Dim nome As String = Console.ReadLine()
                    Console.Write("Pass: ")
                    Dim pass As String = Console.ReadLine()

                    Client.ClientRegister(nome, pass)
            End Select
        End While

    End Sub

    'Sub Main()

    '    Dim displayMenu As Boolean = True

    '    While displayMenu
    '        displayMenu = Menu()


    '    End While

    'End Sub


    'Function Menu() As Boolean

    '    Console.Clear()
    '    Console.WriteLine("«===MENU===»")
    '    Console.WriteLine("(1) » Chat")
    '    Console.WriteLine("(2) » Login")
    '    Console.WriteLine("«===MENU===»")

    '    Dim resultado As String = Console.ReadLine()


    '    Select Case resultado
    '        Case "1"

    '            While True

    '                client.SendKey("chat")
    '                Client.Chat(Console.ReadLine())
    '            End While
    '            Exit Select
    '        Case "2"

    '            client.SendKey("register")
    '            Console.Write("User: ")
    '            client.ClientRegister(Console.ReadLine())
    '            If server.Income() = "ready" Then
    '                Console.Write("Pass: ")
    '                client.ClientRegister(Console.ReadLine())
    '            End If
    '            Exit Select
    '    End Select

    'End Function

End Module
