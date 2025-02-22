Module Module1

    Sub Main()
        Dim a(3, 3) As Integer
        a(0, 0) = 10
        a(0, 1) = 20
        a(0, 2) = 30
        a(1, 0) = 40
        a(1, 1) = 50
        a(1, 2) = 60
        a(2, 0) = 70
        a(2, 1) = 80
        a(2, 2) = 90
        Console.WriteLine(a(0, 2))
    End Sub

End Module
