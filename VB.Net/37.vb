Class Rectangle
    Public length As Double
    Public breadth As Double
    Sub shwvals()
        Console.WriteLine("Length: " & length)
        Console.WriteLine("Width: " & breadth)
    End Sub
    Function CArea() As Integer
        Return length * breadth
    End Function
End Class
Module Module1

    Sub Main()
        Dim R As New Rectangle()
        R.length = 20
        R.breadth = 10
        R.shwvals()
        System.Console.WriteLine("Area: " & R.CArea())
    End Sub

End Module
