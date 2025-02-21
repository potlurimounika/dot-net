Module Module1

    Sub Main()
        Dim sno As Integer
        Dim sname As String
        Dim sclass As Integer
        Dim ssec As String
        Dim M1, M2, M3, M4, M5, M6, tot As Integer
        Dim avg As Double
        System.Console.Write("number:")
        sno = Convert.ToInt32(Console.ReadLine())

        System.Console.Write("name:")
        sname = Console.ReadLine()

        System.Console.Write("class:")
        sclass = Convert.ToInt32(Console.ReadLine())

        System.Console.Write("section:")
        ssec = Console.ReadLine()

        System.Console.Write("M1:")
        M1 = Convert.ToInt32(Console.ReadLine())

        System.Console.Write("M2:")
        M2 = Convert.ToInt32(Console.ReadLine())

        System.Console.Write("M3:")
        M3 = Convert.ToInt32(Console.ReadLine())

        System.Console.Write("M4:")
        M4 = Convert.ToInt32(Console.ReadLine())

        System.Console.Write("M5:")
        M5 = Convert.ToInt32(Console.ReadLine())

        System.Console.Write("M6:")
        M6 = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("....................")
        System.Console.WriteLine("Student data")
        System.Console.WriteLine("....................")
        System.Console.WriteLine("number:" & sno)
        System.Console.WriteLine("name:" & sname)
        System.Console.WriteLine("class:" & sclass)
        System.Console.WriteLine("section:" & ssec)
        System.Console.WriteLine("M1:" & M1)
        System.Console.WriteLine("M2:" & M2)
        System.Console.WriteLine("M3:" & M3)
        System.Console.WriteLine("M4:" & M4)
        System.Console.WriteLine("M5:" & M5)
        System.Console.WriteLine("M6:" & M6)
        tot = M1 + M2 + M3 + M4 + M5 + M6
        System.Console.WriteLine("totaal=" & tot)
        avg = tot / 6
        System.Console.WriteLine("average=" & avg)
        System.Console.WriteLine("....................")
    End Sub

End Module
