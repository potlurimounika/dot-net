Module Rectangle
    Dim l As Integer = 20
    Dim b As Integer = 10
    Sub shwvals()
        Console.WriteLine("Length = " & l)
        Console.WriteLine("Breadth = " & b)
    End Sub
    Function CArea() As Integer
        Return l * b
    End Function
    Sub Main()
        shwvals()
        Console.WriteLine("Area = " & CArea())
    End Sub
End Module
