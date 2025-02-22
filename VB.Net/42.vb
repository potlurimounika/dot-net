Module Module1
    Class A
        Sub fofca()
            Console.WriteLine("procedure of class A")
        End Sub
    End Class
    Class B
        Inherits A
        Sub fofcb()
            Console.WriteLine("procedure of class B")
        End Sub
    End Class
    Sub Main()
        Dim objB As New B()
        objB.fofca()
        objB.fofcb()
    End Sub

End Module
