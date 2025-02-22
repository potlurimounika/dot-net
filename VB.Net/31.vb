Module Module1

    Structure emp
        Dim eno As Integer
        Dim ename As String
        Dim esal As Double
    End Structure
    Sub Main()
        Dim e As New emp
        e.eno = 101
        e.ename = "sri"
        e.esal = 4556.75
        Console.WriteLine("Employee Number : " & e.eno)
        Console.WriteLine("Employee Name : " & e.ename)
        Console.WriteLine("Employee Salary : " & e.esal)
    End Sub

End Module
