using System;
delegate void greets();
class Test
{
    public static void greetOne()
    {
        System.Console.WriteLine("I am a function");
    }
    public static void greetTwo()
    {
        System.Console.WriteLine("I am also a function");
    }
    public static void Main()
    {
        greets g1=new greets(greetOne);
        greets g2 = new greets(greetTwo);
        greets g3 = g1 + g2;
        g3();
    }
}
