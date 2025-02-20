Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        System.Console.WriteLine("Enter a: ")
        a = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter b: ")
        b = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("values before swap a=" & a & vbTab & "b=" & b)
        a = a + b
        b = a - b
        a = a - b
        System.Console.WriteLine("values after swap a=" & a & vbTab & "b=" & b)
    End Sub

End Module
