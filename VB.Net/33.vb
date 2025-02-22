Class Bird
    Sub Fly()
        Console.WriteLine("They fly to fulfill natural activities")
    End Sub
End Class
Module Module1
    Sub Main()
        Dim parrot = New Bird()
        parrot.Fly()
        Dim pigeon As New Bird()
        pigeon.Fly()
    End Sub
End Module
