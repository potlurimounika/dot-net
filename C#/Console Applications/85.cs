using System;
class MyCalci
{
    int a;
    int b;
    public int mysum()
    {
        return a + b;
    }
    public static void Main()
    {
        MyCalci MC = new MyCalci();
        MC.a = 11;
        MC.b = 22;
        System.Console.WriteLine("Sum:"+MC.mysum());
    }
}
