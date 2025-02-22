Class Bird
    Sub Fly()
        Console.WriteLine("They fly to fulfill natural activities")
    End Sub
    Sub buildnest()
        System.Console.WriteLine("They build nest to live")
    End Sub
End Class
Module Module1
    Sub Main()
        Dim parrot = New Bird()
        parrot.Fly()
        parrot.buildnest()
        Dim pigeon As New Bird()
        pigeon.Fly()
        pigeon.buildnest()
    End Sub
End Module
