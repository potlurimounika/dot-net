using System;
class MyCalci
{
    int a;
    int b;
    public void mysum(int x,int y)
    {
        a = x;
        b=y;
        System.Console.WriteLine("sum=" + (a + b));
    }
    public static void Main()
    {
        MyCalci MC = new MyCalci();
        MC.mysum(20, 10);
    }
}
