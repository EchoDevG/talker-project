Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading




Module Module1


    Sub Main()

        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim strIPAddress As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        Console.Clear()
        Console.WriteLine("Main Menu")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("IP Address: " & strIPAddress)
        Console.WriteLine("")
        Console.WriteLine("Press the number on your keyboard to pick an option")
        Console.WriteLine("")
        Console.WriteLine("1. Change console background colour")
        Console.WriteLine("2. Change colsole text colour")
        Console.WriteLine("3. Set server IP")
        Console.WriteLine("4. Connect to the server")
        Console.WriteLine("5. Credits")
        Console.WriteLine("6. Exit program")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("")

        Dim key As Integer = (Console.ReadKey().Key)

        Do While key < 32
        Loop

        If key = 49 Then

        ElseIf key = 50 Then

        ElseIf key = 51 Then

        ElseIf key = 52 Then

        ElseIf key = 53 Then

        ElseIf key = 54 Then

        Else

        End If
    End Sub







    Sub Connect()
        Dim cts As CancellationTokenSource = New CancellationTokenSource()
        Dim listener As TcpListener = New TcpListener(IPAddress.Any, 28000)     'sets listener as a listener listening for any IP
        listener.Start()                'starts listener
        Console.WriteLine("Listener is waiting for client connections...")
        Dim task As Task = AwaitClientConnectionAsync(listener, cts.Token)      ' "task" is the function that waits for a connection, when task is called do the task function, with the listener as listener and with cts.Token as the way to cancel

        While Not Console.ReadKey().Key.Equals(ConsoleKey.Q)    'if the key pressed isnt q do nothing
        End While

        cts.Cancel()    'if they press q, cancel everything

        While task.Status.Equals(TaskStatus.Running)    'call task and wait while it does its thing
        End While
        Console.WriteLine()                                                             'if it stops, wait for a key then quit
        Console.WriteLine("Finished cancelling all tasks.  Press any key to exit.")
        Console.ReadLine()
    End Sub











    Async Function AwaitClientConnectionAsync(ByVal listener As TcpListener, ByVal token As CancellationToken) As Task
        While Not token.IsCancellationRequested                                                     'when it isnt cancelling
            Console.WriteLine("Task is waiting for client connection...")       'print about waiting for a connection
            Console.WriteLine("Press 'Q' to quite...")
            Dim client As TcpClient = Await listener.AcceptTcpClientAsync()         ' "client" is the client that connects
            Console.WriteLine("Client requesting connection...")        'say that the client is requesting permission
            Dim task As Task = TrySendResponse(client, token)           'task becomes attempting to send a response to the client
            While task.Status.Equals(TaskStatus.Running)                'call task and wait while it does its thing
            End While
        End While
    End Function











    Async Function TrySendResponse(ByVal client As TcpClient, ByVal token As CancellationToken) As Task
        Dim buffer As Byte() = New Byte(4096) {}                        'set the buffer to a byte that has a value of 4096
        Dim stream As NetworkStream = client.GetStream()                   'stream becomes the network stream from the client
        token.Register(Sub() stream.Close())                            'close stream when token.Register happens
        While Not token.IsCancellationRequested                 'when there inst a cancel token, do this:
            Try
                Dim read As Integer = Await stream.ReadAsync(buffer, 0, buffer.Length, token)       'read the stream
                If (read <> 0) Then         'if read is a thing
                    Dim RecMessage As String = Str({Encoding.UTF8.GetString(buffer, 0, read)})
                    Console.WriteLine($"Received: {RecMessage}")  'print the revieved message
                Else
                    Exit While                      'restart the thing
                End If

                Await stream.WriteAsync(buffer, 0, read, token)     'respond a message to the client
                Console.WriteLine("Response sent to client...")
                Console.WriteLine("Press 'Q' to quit...")
            Catch ex As Exception                   'catch any errors and print them
                Console.WriteLine(ex.Message)
            End Try
        End While
    End Function



End Module
