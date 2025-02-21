Module Module1

    Sub Main()
        Dim x As Integer
        System.Console.WriteLine(".............")
        System.Console.WriteLine("Menu")
        System.Console.WriteLine(".............")
        System.Console.WriteLine("1.pen")
        System.Console.WriteLine("2.pencil")
        System.Console.WriteLine("3.eraser")
        System.Console.WriteLine(".............")
        System.Console.WriteLine("Enter your choice")
        x = Convert.ToInt32(System.Console.ReadLine())
        Select Case x
            Case 1
                System.Console.WriteLine("You have selected pen")
            Case 2
                System.Console.WriteLine("You have selected pencil")
            Case 3
                System.Console.WriteLine("You have selected eraser")
            Case Else
                System.Console.WriteLine("Invalid choice")
        End Select
    End Sub

End Module
