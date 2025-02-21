Module Module1

    Sub Main()
        Dim x As Integer
        System.Console.WriteLine("Enter a value:")
        x = Convert.ToInt32(System.Console.ReadLine())
        If (x Mod 2 = 0) Then
            System.Console.WriteLine(x & "Even")
        Else
            System.Console.WriteLine(x & "Odd")
        End If
    End Sub

End Module
