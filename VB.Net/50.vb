Module Module1
    Class Test
        Private x As Integer
        Public Sub setx(i As Integer)
            x = i
        End Sub
        Public Function getx() As Integer
            Return x
        End Function
    End Class
    Sub Main()
        Dim T As New Test()
        T.setx(10)
        System.Console.WriteLine("x=" & T.getx())
    End Sub
End Module
