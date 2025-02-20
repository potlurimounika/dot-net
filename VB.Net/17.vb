Module Module1

    Sub Main()
        Dim eno As Integer
        Dim ename As String
        Dim esal As Double
        Dim egrade As String
        Dim ews As Boolean
        System.Console.Write("Enter Eno:")
        eno = Convert.ToInt32(Console.ReadLine())
        System.Console.Write("Enter Ename:")
        ename = Console.ReadLine()
        System.Console.Write("Enter Esal:")
        esal = Convert.ToDouble(Console.ReadLine())
        System.Console.Write("Enter Egrade:")
        egrade = Console.ReadLine()
        System.Console.Write("Enter Ews:")
        ews = Convert.ToBoolean(Console.ReadLine())
        System.Console.WriteLine("....................")
        System.Console.WriteLine("Employee data")
        System.Console.WriteLine("....................")
        System.Console.WriteLine("Eno:" & eno)
        System.Console.WriteLine("Ename:" & ename)
        System.Console.WriteLine("Esal:" & esal)
        System.Console.WriteLine("Egrade:" & egrade)
        System.Console.WriteLine("Ews:" & ews)
        System.Console.WriteLine("....................")
    End Sub

End Module
