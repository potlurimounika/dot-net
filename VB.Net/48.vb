Module Module1
    Class MyCalci
        Public a As Integer
        Public b As Integer
        Public C As Integer
        Sub dispvals()
            System.Console.WriteLine("a=" & a & " " & "b=" & b & " " & "c=" & C)
        End Sub
        Sub dispvals(x As Integer, y As Integer)
            a = x
            b = y
            System.Console.WriteLine("a=" & a & " " & "b=" & b)
        End Sub
        Sub dispvals(x As Integer, y As Integer, z As Integer)
            a = x
            b = y
            C = z
            System.Console.WriteLine("a=" & a & " " & "b=" & b & " " & "c=" & C)
        End Sub
    End Class

    Sub Main()
        Dim x As New MyCalci
        x.a = 1
        x.b = 2
        x.C = 3
        x.dispvals()
        x.dispvals(4, 5)
        x.dispvals(6, 7, 8)
    End Sub

End Module
