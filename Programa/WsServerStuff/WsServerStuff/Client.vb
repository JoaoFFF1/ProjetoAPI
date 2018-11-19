Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Client
    Public Shared data As String = Nothing

    Public Shared Function Chat(extmsg) As String
        ' Data buffer for incoming data.  
        Dim bytes(1024) As Byte

        ' Connect to a remote device.  

        ' Establish the remote endpoint for the socket.  
        ' This example uses port 11000 on the local computer.  
        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim remoteEP As New IPEndPoint(ipAddress, 11000)

        ' Create a TCP/IP socket.  
        Dim sender As New Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp)

        Console.WriteLine("[Chat]: socket criado.")

        ' Connect the socket to the remote endpoint.  
        sender.Connect(remoteEP)

        Console.WriteLine("[Chat]: socket conectado.")

        ' Encode the data string into a byte array.  
        Dim msg As Byte() =
            Encoding.ASCII.GetBytes(extmsg)

        ' Send the data through the socket.  
        Dim bytesSent As Integer = sender.Send(msg)

        Console.WriteLine("[Chat]: mensagem enviada.")

        ' Receive the response from the remote device.  
        Dim bytesRec As Integer = sender.Receive(bytes)

        Console.WriteLine("[Chat]: mensagem recebida.")

        ' Release the socket.  
        sender.Shutdown(SocketShutdown.Both)
        sender.Close()

        Console.WriteLine("[Chat]: socket morto.")

        Return Encoding.ASCII.GetString(bytes, 0, bytesRec)
    End Function

    Public Shared Sub SendKey(key As String)

        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim remoteEP As New IPEndPoint(ipAddress, 60000)

        Dim sender As New Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp)

        Console.WriteLine("[SendKey]: socket criado.")

        sender.Connect(remoteEP)

        Console.WriteLine("[SendKey]: socket ligado.")

        Dim msg As Byte() =
            Encoding.ASCII.GetBytes(key)

        Dim bytesSent As Integer = sender.Send(msg)

        sender.Shutdown(SocketShutdown.Both)
        sender.Close()

        Console.WriteLine("[SendKey]: key enviada.")

    End Sub

    Public Shared Sub ClientRegister(nome As String, pass As String)

        Dim bytes(1024) As Byte

        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim remoteEP As New IPEndPoint(ipAddress, 11000)
        Dim localEndPoint As New IPEndPoint(ipAddress, 11000)

        Dim register As New Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp)

        Console.WriteLine("[ClientRegister]: socket criado.")

        register.Connect(remoteEP)
        'register.Bind(localEndPoint)

        Console.WriteLine("[ClientRegister]: socket conectado.")

        Dim nameSent As Integer = register.Send(Encoding.ASCII.GetBytes(nome))

        Console.WriteLine("[ClientRegister]: nome enviado.")

        'register.Shutdown(SocketShutdown.Both)
        'register.Close()

        'Console.WriteLine("[ClientRegister]: socket ceifado")

        'Dim listener As New Socket(ipAddress.AddressFamily,
        '    SocketType.Stream, ProtocolType.Tcp)

        'Console.WriteLine("[ClientRegister]: socket listener criado.")

        'listener.Bind(localEndPoint)
        register.Listen(10)

        Dim handler As Socket = register.Accept()
        data = Nothing

        Console.WriteLine("[ClientRegister]: Aguardando aprovação da pass.")

        If Server.Income() = "ready" Then
            Console.WriteLine("[ClientRegister]: Aprovação recebida.")
            Dim passSent As Integer = register.Send(Encoding.ASCII.GetBytes(pass))
        End If

        register.Shutdown(SocketShutdown.Both)
        register.Close()
        handler.Shutdown(SocketShutdown.Both)
        handler.Close()

        Console.WriteLine("[ClientRegister]: Sockets assassinados.")

    End Sub

    Public Shared Sub ClientLogin(credential As String)
        Dim bytes(1024) As Byte

        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim remoteEP As New IPEndPoint(ipAddress, 11000)

        Dim register As New Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp)

        Console.WriteLine("[ClientLogin]: socket criado.")

        register.Connect(remoteEP)

        Console.WriteLine("[ClientLogin]: socket conectado.")

        Dim credSent As Integer = register.Send(Encoding.ASCII.GetBytes(credential))

        Console.WriteLine("[ClientLogin]: dados enviados.")

        register.Shutdown(SocketShutdown.Both)
        register.Close()
    End Sub

End Class