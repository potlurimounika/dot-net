using System;
class MyCalci
{
    int a;
    int b;
    public int mysum(int x,int y)
    {
        a= x; 
        b = y;
        return a+b;
    }
    public static void Main()
    {
        MyCalci MC = new MyCalci();
        System.Console.WriteLine("Sum:" + MC.mysum(100,150));
    }
}
