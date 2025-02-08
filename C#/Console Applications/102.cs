using System;
class MyCalci
{
    int a;
    int b;
    int c;
    public MyCalci()
    {
        a = 1;
        b = 2;
        c = 3;
    }
    public int mysumone()
    {
        return a + b + c;
    }
    public MyCalci(int x, int y)
    {
        a = x;
        b = y;
    }
    public int mysumtwo()
    {
        return a + b;
    }
    public MyCalci(int x, int y, int z)
    {
        a = x;
        b = y;
        c = z;
    }
    public int mysumthree()
    {
        return a + b + c;
    }
    public static void Main()
    {
        MyCalci MC1 = new MyCalci();
        MyCalci MC2 = new MyCalci(10, 20);
        MyCalci MC3 = new MyCalci(7, 9, 11);
        System.Console.WriteLine("sum=" + MC1.mysumone());
        System.Console.WriteLine("sum=" + MC2.mysumtwo());
        System.Console.WriteLine("sum=" + MC3.mysumthree());
    }
}
