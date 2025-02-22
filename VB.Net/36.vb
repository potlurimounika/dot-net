Class Bird
    Public age As Integer
    Public wings As Integer
    Public wt As Double
    Public color As String
    Public Sub Fly()
        Console.WriteLine("they fly to fulfill natural activities")
    End Sub
End Class
Module Module1
    Sub Main()
        Dim parrot = New Bird()
        parrot.age = 5
        parrot.wings = 2
        parrot.wt = 1.5
        parrot.color = "green"
        System.Console.WriteLine("parrot age is " & parrot.age)
        System.Console.WriteLine("parrot wings are " & parrot.wings)
        System.Console.WriteLine("parrot weight is " & parrot.wt)
        System.Console.WriteLine("parrot color is " & parrot.color)
        parrot.Fly()
        Dim parrot1 = New Bird()
        parrot1.age = 6
        parrot1.wings = 2
        parrot1.wt = 2.5
        parrot1.color = "gray"
        System.Console.WriteLine("parrot1 age is " & parrot1.age)
        System.Console.WriteLine("parrot1 wings are " & parrot1.wings)
        System.Console.WriteLine("parrot1 weight is " & parrot1.wt)
        System.Console.WriteLine("parrot1 color is " & parrot1.color)
        parrot1.Fly()
    End Sub
End Module
