Module Module1

    Sub Main()

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
        Console.WriteLine("")

        Dim key As Integer = (Console.ReadKey().Key)

        Do While Asc(Int(key)) < 32
        Loop

        If key = "D1" Then
            colours()
        ElseIf key = 2 Then
            v2()
        ElseIf key = 3 Then
            v3()
        ElseIf key = 4 Then
            v4()
        ElseIf key = 5 Then
            v5()
        Else
            Console.WriteLine("")
            Console.WriteLine("invalid key press. Press enter to continue...")
            Console.ReadLine()
            Console.Clear()
            Main()
        End If

    End Sub


    Sub colours()

        Console.Clear()
        Console.WriteLine("v1")
        Console.ReadLine()
        Console.Clear()
        Main()

    End Sub

    Sub v2()

        Console.Clear()
        Console.WriteLine("v2")
        Console.ReadLine()
        Console.Clear()
        Main()

    End Sub

    Sub v3()

        Console.Clear()
        Console.WriteLine("v3")
        Console.ReadLine()
        Console.Clear()
        Main()

    End Sub

    Sub v4()

        Console.Clear()
        Console.WriteLine("v4")
        Console.ReadLine()
        Console.Clear()
        Main()

    End Sub

    Sub v5()

        Console.Clear()
        Console.WriteLine("v5")
        Console.ReadLine()
        Console.Clear()
        Main()

    End Sub
End Module
