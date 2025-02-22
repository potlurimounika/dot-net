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
        parrot.Fly()
    End Sub
End Module
