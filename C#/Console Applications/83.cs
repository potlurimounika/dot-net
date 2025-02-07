using System;
class MyCalci
{
    int a;
    int b;
    public void mysum()
    {
        System.Console.WriteLine("sum="+(a+b));
    }
    public static void Main()
    {
        MyCalci MC=new MyCalci();
        MC.a = 5;
        MC.b = 3;
        MC.mysum();
    }
}
