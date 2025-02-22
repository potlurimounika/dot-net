Module Module1
    Class IndexerClass
        Private arr As Integer() = New Integer(5) {}
        Default Public Property Item(index As Integer) As Integer
            Get
                Return arr(index)
            End Get
            Set(value As Integer)
                arr(index) = value
            End Set
        End Property
    End Class
    Sub Main()
        Dim i As New IndexerClass
        i(0) = 10
        i(1) = 20
        i(2) = 30
        i(3) = 40
        i(4) = 50
        For j As Integer = 0 To 4
            Console.WriteLine("Element({0}) = {1}", j, i(j))
        Next
    End Sub

End Module
