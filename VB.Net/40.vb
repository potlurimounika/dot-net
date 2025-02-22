Class MyCaci
    Public a As Integer
    Public b As Integer
    Public c As Integer
    Public Sub New()
        a = 20
        b = 10
        c = 5
    End Sub
    Public Sub putvalsone()
        System.Console.WriteLine("a = " & a & "b=" & b & "c=" & c)
    End Sub
    Public Sub New(x As Integer, y As Integer)
        a = x
        b = y
    End Sub
    Public Sub putvalstwo()
        System.Console.WriteLine("a = " & a & "b=" & b & "c=" & c)
    End Sub
    Public Sub New(x As Integer, y As Integer, z As Integer)
        a = x
        b = y
        c = z
    End Sub
    Public Sub putvalsthree()
        System.Console.WriteLine("a = " & a & "b=" & b & "c=" & c)
    End Sub
End Class
Module Module1

    Sub Main()
        Dim MC1 As New MyCaci()
        Dim MC2 As New MyCaci(10, 20)
        Dim MC3 As New MyCaci(10, 20, 30)
        MC1.putvalsone()
        MC2.putvalstwo()
        MC3.putvalsthree()
    End Sub

End Module
