Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Sockets.NetworkStream
Imports System.Text
Imports System.Threading




Module Module1


    Sub Main()

        Dim strHostName As String = System.Net.Dns.GetHostName()
#Disable Warning BC40000 ' Type or member is obsolete
        Dim strIPAddress As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
#Enable Warning BC40000 ' Type or member is obsolete            removing errors


        Console.Clear()
        Console.WriteLine("Server Set Up")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("IP Address: " & strIPAddress)
        Console.WriteLine("==================")
        Console.WriteLine("")
        Console.WriteLine("Press the number on your keyboard to pick an option")
        Console.WriteLine("")
        Console.WriteLine("1. Change console background colour")
        Console.WriteLine("2. Change colsole text colour")
        Console.WriteLine("3. Initiate connection")
        Console.WriteLine("4. Credits")
        Console.WriteLine("5. Exit program")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("")

        Dim key As Integer = (Console.ReadKey().Key)

        Do While key < 32
        Loop

        If key = 49 Then
            backColours()
        ElseIf key = 50 Then
            textColours()
        ElseIf key = 51 Then
            Connect()
        ElseIf key = 52 Then
            Credits()
        ElseIf key = 53 Then
            quit()
        Else
            badSyntax()
        End If
    End Sub



    Sub backColours()

        Console.Clear()
        Console.WriteLine("Colour menu")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("")
        Console.WriteLine("Press the letter on your keyboard to pick a background colour")
        Console.WriteLine("")
        Console.WriteLine("a. Red")
        Console.WriteLine("b. Yellow")
        Console.WriteLine("c. Green")
        Console.WriteLine("d. Dark green")
        Console.WriteLine("e. Blue")
        Console.WriteLine("f. Dark blue")
        Console.WriteLine("g. Cyan")
        Console.WriteLine("h. Magenta")
        Console.WriteLine("i. Dark magenta")
        Console.WriteLine("j. White")
        Console.WriteLine("k. Black")
        Console.WriteLine("l. Current colour")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("")


        Dim letter As Integer = Console.ReadKey().Key

        Do While letter < 32
        Loop


        If letter = 65 Then
            Console.BackgroundColor = ConsoleColor.Red
        ElseIf letter = 66 Then
            Console.BackgroundColor = ConsoleColor.Yellow
        ElseIf letter = 67 Then
            Console.BackgroundColor = ConsoleColor.Green
        ElseIf letter = 68 Then
            Console.BackgroundColor = ConsoleColor.DarkGreen
        ElseIf letter = 69 Then
            Console.BackgroundColor = ConsoleColor.Blue
        ElseIf letter = 70 Then
            Console.BackgroundColor = ConsoleColor.DarkBlue
        ElseIf letter = 71 Then
            Console.BackgroundColor = ConsoleColor.Cyan
        ElseIf letter = 72 Then
            Console.BackgroundColor = ConsoleColor.Magenta
        ElseIf letter = 73 Then
            Console.BackgroundColor = ConsoleColor.DarkMagenta
        ElseIf letter = 74 Then
            Console.BackgroundColor = ConsoleColor.White
        ElseIf letter = 75 Then
            Console.BackgroundColor = ConsoleColor.Black
        ElseIf letter = 76 Then
            Console.WriteLine("")
            Console.WriteLine("Background colour will remain as is")
            Console.WriteLine("Press any key to continue...")
            Console.ReadLine()
            Console.Clear()
            Main()
        Else
            Console.Clear()
            badSyntax()
        End If

        Console.Clear()
        Console.WriteLine("Enjoy!")
        Console.WriteLine("")
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()
        Console.Clear()
        Main()

    End Sub


    Sub textColours()

        Console.Clear()
        Console.WriteLine("Colour menu")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("")
        Console.WriteLine("Press the letter on your keyboard to pick a text colour")
        Console.WriteLine("")
        Console.WriteLine("a. Red")
        Console.WriteLine("b. Yellow")
        Console.WriteLine("c. Green")
        Console.WriteLine("d. Dark green")
        Console.WriteLine("e. Blue")
        Console.WriteLine("f. Dark blue")
        Console.WriteLine("g. Cyan")
        Console.WriteLine("h. Magenta")
        Console.WriteLine("i. Dark magenta")
        Console.WriteLine("j. White")
        Console.WriteLine("k. Black")
        Console.WriteLine("l. Current colour")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("")


        Dim letter As Integer = Console.ReadKey().Key

        Do While letter < 32
        Loop

        If letter = 65 Then
            Console.ForegroundColor = ConsoleColor.Red
        ElseIf letter = 66 Then
            Console.ForegroundColor = ConsoleColor.Yellow
        ElseIf letter = 67 Then
            Console.ForegroundColor = ConsoleColor.Green
        ElseIf letter = 68 Then
            Console.ForegroundColor = ConsoleColor.DarkGreen
        ElseIf letter = 69 Then
            Console.ForegroundColor = ConsoleColor.Blue
        ElseIf letter = 70 Then
            Console.ForegroundColor = ConsoleColor.DarkBlue
        ElseIf letter = 71 Then
            Console.ForegroundColor = ConsoleColor.Cyan
        ElseIf letter = 72 Then
            Console.ForegroundColor = ConsoleColor.Magenta
        ElseIf letter = 73 Then
            Console.ForegroundColor = ConsoleColor.DarkMagenta
        ElseIf letter = 74 Then
            Console.ForegroundColor = ConsoleColor.White
        ElseIf letter = 75 Then
            Console.ForegroundColor = ConsoleColor.Black
        ElseIf letter = 76 Then
            Console.WriteLine("")
            Console.WriteLine("Background colour will remain as is")
            Console.WriteLine("Press any key to continue...")
            Console.ReadLine()
            Console.Clear()
            Main()
        Else
            Console.Clear()
            badSyntax()
        End If

        Console.Clear()
        Console.WriteLine("Enjoy!")
        Console.WriteLine("")
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()
        Console.Clear()
        Main()

    End Sub


    Sub Credits()
        Console.Clear()
        Console.WriteLine("Credits")
        Console.WriteLine("")
        Console.WriteLine("Idea - Dylan Garratt")
        Console.WriteLine("Motivation - Andrew Craig")
        Console.WriteLine("Telling me to use linux - Callum Smith")
        Console.WriteLine("Cool code comments - Dylan Garratt")
        Console.WriteLine("Testing - Monib Ahmed")
        Console.WriteLine("Executive tester - Robert Bari")
        Console.WriteLine("Actual clever parts of the program - it_sage, developer. Found on Experts Exchange")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Press any key to return to main menu")
        Console.ReadLine()
        Console.Clear()
        Main()
    End Sub


    Sub quit()

        Console.Clear()
        Console.WriteLine("Are you sure you want to exit? Y/n")

        Dim answer As Integer = (Console.ReadKey().Key)

        Do While answer < 32
        Loop

        If answer = 89 Or answer = 121 Then
            Console.WriteLine("")
            Console.WriteLine("Press any key to quit...")
            Console.ReadLine()
            End
        ElseIf answer = 78 Or answer = 110 Then
            Console.WriteLine("")
            Console.WriteLine("Press any key to return to menu...")
            Console.ReadLine()
            Main()
        Else
            badSyntax()
        End If

    End Sub



    Sub Connect()

        Dim strHostName As String = System.Net.Dns.GetHostName()
#Disable Warning BC40000 ' Type or member is obsolete
        Dim strIPAddress As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
#Enable Warning BC40000 ' Type or member is obsolete        removing errors

        Console.Clear()

        Dim cts As CancellationTokenSource = New CancellationTokenSource()
        Dim listener As TcpListener = New TcpListener(IPAddress.Any, 28000)     'sets listener as a listener listening for any IP
        listener.Start()                'starts listener
        Console.WriteLine("Listener is waiting for client connections...")
        Console.WriteLine("IP Address: " & strIPAddress)
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



    Sub badSyntax()
        Console.WriteLine("")
        Console.WriteLine("invalid key press. Press enter to continue...")
        Console.ReadLine()
        Console.Clear()
        Main()
    End Sub

End Module
