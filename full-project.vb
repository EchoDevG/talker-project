Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Imports System.Timers

Module Module1

    Sub Main()

        Console.Clear()
        Console.WriteLine("Main Menu")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("")
        Console.WriteLine("Press the number on your keyboard to pick an option")
        Console.WriteLine("")
        Console.WriteLine("1. Change console colours")
        Console.WriteLine("2. Set server IP")
        Console.WriteLine("3. Connect to the server")
        Console.WriteLine("4. Credits")
        Console.WriteLine("5. Exit program")
        Console.WriteLine("")
        Console.WriteLine("==================")
        Console.WriteLine("")

        Dim key As Integer = (Console.ReadKey().Key)

        Do While key < 32
        Loop

        If key = 49 Then
            colours()           'to do
        ElseIf key = 50 Then
            serverIP()          'to do
        ElseIf key = 51 Then
            Writer()            'to do, final part of to do
        ElseIf key = 52 Then
            Credits()           'working
        ElseIf key = 53 Then
            quit()              'working
        Else
            badSyntax()         'working
        End If

    End Sub


    Sub colours()

        Console.Clear()
        Console.WriteLine("colours")
        Console.ReadLine()
        Console.Clear()
        Main()

    End Sub

    Sub serverIP()

        Console.Clear()
        Console.WriteLine("serverIP")
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



    Sub Credits()
        Console.Clear()
        Console.WriteLine("Credits")
        Console.WriteLine("")
        Console.WriteLine("Idea - Dylan Garratt")
        Console.WriteLine("Motivation - Andrew Craig")
        Console.WriteLine("Telling me to use linux - Callum Smith")
        Console.WriteLine("Cool code comments - Dylan Garratt")
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
        Dim [task] As Task = Task.Factory.StartNew(Async Sub()                                                                      'task is this subroutine
                                                       Using client As TcpClient = New TcpClient()
                                                           Await client.ConnectAsync(IPAddress.Parse("127.0.0.1"), 28000)           'connect to server with given IP
                                                           Console.WriteLine("Connected to the server")                             'let the user know they have connected to the server
                                                           Using stream As NetworkStream = client.GetStream()                       ' stream becomes the network stream
                                                               Using writer As StreamWriter = New StreamWriter(stream)              'writer becomes the writer
                                                                   Using reader As StreamReader = New StreamReader(stream)          'reader becomes the reader
                                                                       writer.AutoFlush = True                                      'remove any old stream



                                                                       For Each i In Enumerable.Range(0, 10)                           'do this 10 times


                                                                           Console.WriteLine("Writing to the server")
                                                                           Await writer.WriteLineAsync(DateTime.Now.ToLongTimeString())     'write the message
                                                                           Console.WriteLine("Reading response from the server")
                                                                           Dim response As String = Await reader.ReadLineAsync()            'response is the servers responce
                                                                           If Not String.IsNullOrWhiteSpace(response) Then                  'if string is vlaid
                                                                               Console.WriteLine($"Response from server: {response}")       'give response as output
                                                                           End If


                                                                           'put while loop instead of for loop
                                                                       Next



                                                                   End Using
                                                               End Using
                                                           End Using            'closes server link
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
