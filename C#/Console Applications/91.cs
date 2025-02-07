using System;
class MyCalci
{
    public int a;
    public int b;
    public MyCalci(int x,int y)
    {
        a = x;
        b = y;
    }
    public void dispvals()
    {
        Console.WriteLine("a=" + a + "b=" + b);
    }
    public int add()
    {
        return a + b;
    }
    public static void Main()
    {
        MyCalci obj = new MyCalci(20,10);
        obj.dispvals();
        Console.WriteLine("sum=" + obj.add());
    }
}
