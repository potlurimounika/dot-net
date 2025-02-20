Module Module1

    Sub Main()
        Dim a As Integer = 5
        Dim b As Integer = 3
        Dim c As Integer
        System.Console.WriteLine("value of a = " & a & vbTab & "b=" & b)
        a = a * b
        b = a \ b
        a = a \ b
        System.Console.WriteLine("value of a = " & a & vbTab & "b=" & b)
    End Sub

End Module
