using System;
class MyCalci
{
    public int a;
    public int b;
    public  MyCalci()
    {
        a = 6;
        b = 2;
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
        MyCalci obj = new MyCalci();
        obj.dispvals();
        Console.WriteLine("sum="+obj.add());
    }
}
