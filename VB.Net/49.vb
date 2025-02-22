Module Module1
    Class MyCalci
        Public a As Integer
        Public b As Integer
        Public C As Integer
        Function MySum()
            Return a + b + C
        End Function
        Function MySum(x As Integer, y As Integer)
            a = x
            b = y
            Return x + y
        End Function
        Function MySum(x As Integer, y As Integer, z As Integer)
            a = x
            b = y
            C = z
            Return a + b + C
        End Function
    End Class

    Sub Main()
        Dim x As New MyCalci
        x.a = 1
        x.b = 2
        x.C = 3
        System.Console.WriteLine("sum=" & x.MySum())
        System.Console.WriteLine("sum=" & x.MySum(4, 5))
        System.Console.WriteLine("sum=" & x.MySum(6, 7, 8))
    End Sub

End Module
