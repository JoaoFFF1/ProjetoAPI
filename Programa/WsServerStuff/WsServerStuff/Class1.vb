Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Server
    Public Shared data As String = Nothing

    Public Shared Sub Server()

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

        ' Bind the socket to the local endpoint and   
        ' listen for incoming connections.  

        listener.Bind(localEndPoint)
        listener.Listen(10)

        ' Start listening for connections.  
        While True
            Console.WriteLine("Aguardando conexões...")
            ' Program is suspended while waiting for an incoming connection.  
            Dim handler As Socket = listener.Accept()
            data = Nothing

            ' An incoming connection needs to be processed.  
            While True
                Dim bytesRec As Integer = handler.Receive(bytes)
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec)
                Console.WriteLine("A receber dados...[{0}]", data)
                'If data.IndexOf("<EOF>") > -1 Then
                '    Exit While
                'End If
                Exit While
            End While
            ' Show the data on the console.  
            Console.WriteLine("Texto recebido : {0}", data)
            ' Echo the data back to the client.  
            Dim msg As Byte() = Encoding.ASCII.GetBytes(data)
            handler.Send(msg)
            Console.WriteLine("Texto enviado.")
            handler.Shutdown(SocketShutdown.Both)
            handler.Close()
        End While

    End Sub
End Class
