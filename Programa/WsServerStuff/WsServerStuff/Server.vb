Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Server
    Public Shared data As String = Nothing

    Public Shared Sub ChatServer()

        ' Data buffer for incoming data.  
        Dim bytes() As Byte = New [Byte](1024) {}

        ' Establish the local endpoint for the socket.  
        ' Dns.GetHostName returns the name of the   
        ' host running the application.  
        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim localEndPoint As New IPEndPoint(ipAddress, 11000)

        ' Create a TCP/IP socket.  
        Dim listener As New Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp)

        Console.WriteLine("[ChatServer]: socket criado")

        ' Bind the socket to the local endpoint and   
        ' listen for incoming connections.  

        listener.Bind(localEndPoint)
        listener.Listen(10)

        Console.WriteLine("[ChatServer]: socket aguardando")
        ' Start listening for connections.  
        While True
            'Console.WriteLine("Aguardando conexões...")
            ' Program is suspended while waiting for an incoming connection.  
            Dim handler As Socket = listener.Accept()
            data = Nothing
            Console.WriteLine("[ChatServer] Conexão aceite.")

            ' An incoming connection needs to be processed.  
            While True
                Dim bytesRec As Integer = handler.Receive(bytes)
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec)
                Console.WriteLine("[ChatServer]: a receber dados...[{0}]", data)
                'If data.IndexOf("<EOF>") > -1 Then
                '    Exit While
                'End If
                Exit While
            End While
            ' Show the data on the console.  
            Console.WriteLine("[ChatServer] Texto recebido : {0}", data)
            ' Echo the data back to the client.  
            Dim msg As Byte() = Encoding.ASCII.GetBytes(data)
            handler.Send(msg)

            Console.WriteLine("[ChatServer] Texto enviado.")

            handler.Shutdown(SocketShutdown.Both)
            handler.Close()

            Console.WriteLine("[ChatServer] Socket aniquilado.")

        End While

    End Sub

    Public Shared Function Income() As String

        Dim bytes() As Byte = New [Byte](1024) {}

        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0) 'IPAddress.Any
        Dim localEndPoint As New IPEndPoint(ipAddress, 60000)

        Dim listener As New Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp)

        Console.WriteLine("[Income]: socket criado.")

        listener.Bind(localEndPoint)
        listener.Listen(10)

        Console.WriteLine("[Income]: Aguardando conexões.")

        Dim handler As Socket = listener.Accept()
        data = Nothing

        Console.WriteLine("[Income]: ligação estabelecida.")

        While True
            Dim bytesRec As Integer = handler.Receive(bytes)
            data += Encoding.ASCII.GetString(bytes, 0, bytesRec)
            Exit While
        End While

        handler.Shutdown(SocketShutdown.Both)
        handler.Close()

        Console.WriteLine("[Income]: key recebida.")

        Return data
    End Function

    Public Shared Function InRegister(name As String, pass As String) As String

        Dim bytes() As Byte = New [Byte](1024) {}

        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim localEndPoint As New IPEndPoint(ipAddress, 11000)

        Dim listener As New Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp)

        Console.WriteLine("[InRegister]: socket1 criado.")

        listener.Bind(localEndPoint)
        listener.Listen(10)

        Console.WriteLine("[InRegister]: Aguardando conexões.")

        '===========================================================

        Dim handler As Socket = listener.Accept()
        data = Nothing

        Console.WriteLine("[InRegister]: ligação estabelecida.")

        While True
            Dim bytesRec As Integer = handler.Receive(bytes)
            data += Encoding.ASCII.GetString(bytes, 0, bytesRec)
            Console.WriteLine("[InRegister]: a receber nome...[{0}]", data)

            Exit While
        End While
        name = data

        Console.WriteLine("[InRegister] nome recebido : {0}", data)

        'handler.Send(Encoding.ASCII.GetBytes("ready"))
        handler.Shutdown(SocketShutdown.Both)
        handler.Close()

        Console.WriteLine("[InRegister] socket1 exterminado")

        Client.SendKey("ready")

        Console.WriteLine("[InRegister] preparado para receber a pass")
        '===========================================================

        Dim handler2 As Socket = listener.Accept()
        data = Nothing

        Console.WriteLine("[InRegister]: ligação estabelecida.")

        While True
            Dim bytesRec As Integer = handler2.Receive(bytes)
            data += Encoding.ASCII.GetString(bytes, 0, bytesRec)
            Console.WriteLine("[InRegister]: a receber pass...[{0}]", data)

            Exit While
        End While
        pass = data

        Console.WriteLine("[InRegister] pass recebida : {0}", data)

        '===========================================================

        handler2.Shutdown(SocketShutdown.Both)
        handler2.Close()

        Console.WriteLine("[InRegister] socket2 fuzilado")

        Return data
    End Function
    '===============================================================================
    '===============================================================================
    'Public Shared Function Chat(extmsg) As String
    '    Dim bytes(1024) As Byte

    '    Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
    '    Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
    '    Dim remoteEP As New IPEndPoint(ipAddress, 11000)

    '    Dim sender As New Socket(ipAddress.AddressFamily,
    '        SocketType.Stream, ProtocolType.Tcp)

    '    Console.WriteLine("[Chat]: socket criado.")

    '    sender.Connect(remoteEP)

    '    Console.WriteLine("[Chat]: socket conectado")

    '    Dim msg As Byte() =
    '        Encoding.ASCII.GetBytes(extmsg)

    '    Dim bytesSent As Integer = sender.Send(msg)

    '    Console.WriteLine("[Chat]: mensagem enviada")

    '    Dim bytesRec As Integer = sender.Receive(bytes)

    '    Console.WriteLine("[Chat]: mensagem recebida")

    '    sender.Shutdown(SocketShutdown.Both)
    '    sender.Close()

    '    Console.WriteLine("[Chat]: socket morto")

    '    Return Encoding.ASCII.GetString(bytes, 0, bytesRec)
    'End Function

End Class
