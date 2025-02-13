using System;
delegate void greets();
class Test
{
    public static void greetOne()
    {
        System.Console.WriteLine("I am function");
    }
    public static void Main()
    {
        greets g = new greets(greetOne);
        g();
    }
}
