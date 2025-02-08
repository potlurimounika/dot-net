using System;
class Test
{
    static void Main()
    {
        int a = 10;
        int b = 2;
        try
        {
            System.Console.WriteLine("Begin");
            System.Console.WriteLine("Ready to do Division");
            int c = a / b;
            Console.WriteLine("Result:" + c);
            System.Console.WriteLine("End");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("you cannot divide a number with zero");
        }
        finally
        {
            System.Console.WriteLine("success fully execute this program");
        }
    }
}
