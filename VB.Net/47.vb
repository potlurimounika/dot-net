Module Module1
    Class person
        Public Sub walk()
            Console.WriteLine("person walks slowly")
        End Sub
    End Class
    Class Employee
        Inherits person
        Public Sub walk()
            Console.WriteLine("Employee walks fast")
        End Sub
    End Class
    Sub Main()
        Dim E As New Employee()
        E.walk()
    End Sub

End Module
