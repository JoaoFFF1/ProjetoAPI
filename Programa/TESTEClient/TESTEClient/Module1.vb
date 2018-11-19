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

                    Client.SendKey("chat")
                    Console.WriteLine("key enviada, chat")
                    While True

                        Client.Chat(Console.ReadLine())
                        Console.WriteLine("{Chat}: fim de método")
                    End While
                    Exit While
                Case "2"

                    'Console.Write("User: ")
                    'nome = Console.ReadLine()
                    'Console.Write("Pass: ")
                    'pass = Console.ReadLine()

                Case "3"
                    Client.SendKey("register")
                    Console.WriteLine("key enviada, register")


                    Console.Write("Nome: ")
                    Dim nome As String = Console.ReadLine()
                    Console.Write("Pass: ")
                    Dim pass As String = Console.ReadLine()

                    Client.ClientRegister(nome, pass)
                    Console.WriteLine("{ClientRegister}: fim de método")
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
'System.Net.Sockets.SocketException
'HResult = 0x80004005
'  Message = Um pedido para enviar ou receber dados não foi permitido porque o socket não está ligado e (durante o envio num socket de datagrama utilizando uma chamada sendto) não foi fornecido um endereço
'  Source = System
'StackTrace:
'   at System.Net.Sockets.Socket.Send(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags)
'   at System.Net.Sockets.Socket.Send(Byte[] buffer)
'   at WsServerStuff.Client.ClientRegister(String nome, String pass) In C:\Users\joaof\Desktop\ProjetoApi\Programa\WsServerStuff\WsServerStuff\Client.vb:line 100
'   at TESTEClient.Module1.main() In C:\Users\joaof\Desktop\ProjetoApi\Programa\TESTEClient\TESTEClient\Module1.vb:line 50
