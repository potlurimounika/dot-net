Module Module1
    Class Bank
        Public Overridable Function itrate() As Integer
            Return 0
        End Function
    End Class
    Class SBI
        Inherits Bank
        Public Overrides Function itrate() As Integer
            Return 7
        End Function
    End Class
    Class HDFC
        Inherits Bank
        Public Overrides Function itrate() As Integer
            Return 8
        End Function
    End Class
    Class ICICI
        Inherits Bank
        Public Overrides Function itrate() As Integer
            Return 9
        End Function
    End Class

    Sub Main()
        Dim a As Bank = New SBI()
        Dim h As Bank = New HDFC()
        Dim i As Bank = New ICICI()
        Console.WriteLine("SBI Rate of Interest: " & a.itrate())
        Console.WriteLine("HDFC Rate of Interest: " & h.itrate())
        Console.WriteLine("ICICI Rate of Interest: " & i.itrate())
    End Sub
End Module
