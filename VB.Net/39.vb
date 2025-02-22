Class Rectangle
    Public length As Double
    Public breadth As Double
    Sub New(x As Integer, y As Integer)
        length = x
        breadth = y
    End Sub
    Sub shwvals()
        System.Console.WriteLine("Length: " & length)
        System.Console.WriteLine("Breadth: " & breadth)
    End Sub
    Function CArea() As Integer
        Return length * breadth
    End Function
End Class
Module Module1

    Sub Main()
        Dim R As New Rectangle(100, 150)
        R.shwvals()
        System.Console.WriteLine("Area: " & R.CArea())
    End Sub

End Module
