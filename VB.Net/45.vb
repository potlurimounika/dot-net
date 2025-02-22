Module Module1
    Interface A
        Sub greetone()
    End Interface
    Interface B
        Sub greettwo()
    End Interface
    Class C
        Implements A, B
        Public Sub greetone() Implements A.greetone
            Console.WriteLine("Hello from greetone")
        End Sub
        Public Sub greettwo() Implements B.greettwo
            Console.WriteLine("Hello from greettwo")
        End Sub
    End Class
    Sub Main()
        Dim objC As C = New C()
        objC.greetone()
        objC.greettwo()
    End Sub

End Module
