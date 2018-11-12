Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Client

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

        ' Connect the socket to the remote endpoint.  
        sender.Connect(remoteEP)

        'Console.WriteLine("Socket connectado a {0}",
        '    sender.RemoteEndPoint.ToString())

        ' Encode the data string into a byte array.  

        Dim msg As Byte() =
            Encoding.ASCII.GetBytes(extmsg)

        ' Send the data through the socket.  
        Dim bytesSent As Integer = sender.Send(msg)

        ' Receive the response from the remote device.  
        Dim bytesRec As Integer = sender.Receive(bytes)

        ' Release the socket.  
        sender.Shutdown(SocketShutdown.Both)
        sender.Close()

        Return Encoding.ASCII.GetString(bytes, 0, bytesRec)
    End Function

    Public Sub SendKey(key As String)

        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim remoteEP As New IPEndPoint(ipAddress, 11001)

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

        Console.WriteLine("[SendKey]: key enviada")

    End Sub

    Public Sub ClientRegister(credential As String)

        Dim bytes(1024) As Byte

        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim remoteEP As New IPEndPoint(ipAddress, 11000)

        Dim register As New Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp)

        Console.WriteLine("[ClientRegister]: socket criado")

        register.Connect(remoteEP)

        Console.WriteLine("[ClientRegister]: socket conectado")

        Dim credSent As Integer = register.Send(Encoding.ASCII.GetBytes(credential))

        Console.WriteLine("[ClientRegister]: dados enviados")

        register.Shutdown(SocketShutdown.Both)
        register.Close()

    End Sub

    Public Sub ClientLogin(credential As String)
        Dim bytes(1024) As Byte

        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim remoteEP As New IPEndPoint(ipAddress, 11000)

        Dim register As New Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp)

        Console.WriteLine("[ClientRegister]: socket criado")

        register.Connect(remoteEP)

        Console.WriteLine("[ClientRegister]: socket conectado")

        Dim credSent As Integer = register.Send(Encoding.ASCII.GetBytes(credential))

        Console.WriteLine("[ClientRegister]: dados enviados")

        register.Shutdown(SocketShutdown.Both)
        register.Close()
    End Sub

End Class