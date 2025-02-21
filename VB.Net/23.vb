Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        System.Console.WriteLine("Enter a:")
        a = Convert.ToInt32(Console.ReadLine)
        System.Console.WriteLine("Enter b:")
        b = Convert.ToInt32(Console.ReadLine)
        If (a > b) Then
            System.Console.WriteLine("a is big")
        ElseIf (a < b) Then
            System.Console.WriteLine("b is big")
        Else
            System.Console.WriteLine("both are equal")
        End If
    End Sub

End Module
