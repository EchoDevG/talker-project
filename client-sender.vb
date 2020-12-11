Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Sockets.NetworkStream

Imports System.Threading

Module Module1

    Sub Main()

        If IPset = False Then
            serverIP = "127.0.0.1"
            IPset = True
        End If

        Console.Clear()
        Console.WriteLine("Main Menu")
        Console.WriteLine("")
        Console.WriteLine("==================")
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
            backColours()           'working
        ElseIf key = 50 Then
            textColours()       'working
        ElseIf key = 51 Then
            setIP()          'to do, final part of to do
        ElseIf key = 52 Then
            Writer()            'to do, final part of to do
        ElseIf key = 53 Then
            Credits()           'working
        ElseIf key = 54 Then
            quit()              'working
        Else
            badSyntax()         'working
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
        'red, orange, yellow, light green, dark green, dark blue, light blue, cyan, magenta, indigo, violet, white, black
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

    Sub setIP()

        Console.Clear()
        Console.WriteLine("Type the server IP in the form [xx.xx.xxx.x(x)(x)] and press enter...")
        Console.WriteLine("")
        serverIP = Console.ReadLine()
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

    Sub badSyntax()
        Console.WriteLine("")
        Console.WriteLine("invalid key press. Press enter to continue...")
        Console.ReadLine()
        Console.Clear()
        Main()
    End Sub



    Sub Writer()
        Console.Clear()

        Console.WriteLine("Please check that your IP address is correct. If it isnt, you will have to restart the program")
        Console.WriteLine("The current IP address is: " + serverIP)

        Console.WriteLine("Are you sure you want to continue? Y/n")
        Console.WriteLine("")
        Dim answer As Integer = (Console.ReadKey().Key)

        Do While answer < 32
        Loop

        If answer = 89 Or answer = 121 Then
            Console.Clear()
            Console.WriteLine("Connecting...")
            Console.WriteLine("")
        ElseIf answer = 78 Or answer = 110 Then
            Console.WriteLine("")
            Console.WriteLine("Press any key to return to menu...")
            Console.ReadLine()
            Main()
        Else
            badSyntax()
        End If



        Dim [task] As Task = Task.Factory.StartNew(Async Sub()                                                                      'task is this subroutine
                                                       Using client As TcpClient = New TcpClient()

                                                           Try
                                                               Await client.ConnectAsync(IPAddress.Parse(serverIP), 28000)          'connect to server with given IP   
                                                           Catch ex As Exception
                                                               Console.WriteLine("Could Not connect")
                                                               Console.ReadLine()
                                                               Main()

                                                           End Try

                                                           Console.WriteLine("Connected to the server")                             'let the user know they have connected to the server
                                                           Using stream As NetworkStream = client.GetStream()                       ' stream becomes the network stream
                                                               Using writer As StreamWriter = New StreamWriter(stream)              'writer becomes the writer
                                                                   Using reader As StreamReader = New StreamReader(stream)          'reader becomes the reader
                                                                       writer.AutoFlush = True                                      'remove any old stream


                                                                       Dim key As Integer = Console.ReadKey.Key

                                                                       Do While key <> 27


                                                                           Console.WriteLine("Input message to send")
                                                                           Dim message As String = Console.ReadLine()

                                                                           Await writer.WriteLineAsync(message)                             'write the message
                                                                           Console.WriteLine("Reading response from the server")
                                                                           Dim response As String = Await reader.ReadLineAsync()            'response is the servers responce
                                                                           If Not String.IsNullOrWhiteSpace(response) Then                  'if string is valid
                                                                               Console.WriteLine($"Response from server: {response}")       'give response as output
                                                                           End If


                                                                       Loop



                                                                   End Using
                                                               End Using
                                                           End Using   'closes server link
                                                       End Using
                                                       Console.WriteLine("Client has closed connection to the server...")
                                                   End Sub)
        While task.Status.Equals(TaskStatus.Running)                'do nothing while tas kis running
        End While
        Console.WriteLine()
        Console.WriteLine("Client has finished executing...  Press any key to exit...")         'close once task is over
        Console.ReadLine()
    End Sub


    'to do: Put in subroutine, create start up menu with colour and choose IP




End Module
