Module Module1
    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        System.Console.WriteLine("Enter a: ")
        a = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine("Enter b: ")
        b = Convert.ToInt32(Console.ReadLine())
        c = a + b
        System.Console.WriteLine("Addition=" & c)
        c = a - b
        System.Console.WriteLine("Subtraction=" & c)
        c = a * b
        System.Console.WriteLine("Multiplication=" & c)
        c = a / b
        System.Console.WriteLine("Division=" & c)
        c = a \ b
        System.Console.WriteLine("Floar Division=" & c)
        c = a Mod b
        System.Console.WriteLine("Module=" & c)
        c = a ^ b
        System.Console.WriteLine("Exponentiation=" & c)
    End Sub

End Module
