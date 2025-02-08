using System;
class MyCalci
{
    int a, b, c;
        public int mysum()
    {
        return a+b+c;
    }
    public int mysum(int x, int y)
    {
        a = x;
        b = y;
        return x + y;
    }
    public int mysum(int x, int y,int z)
    {
        a = x;
        b = y;
        c = z;
        return x + y+z;
    }
    public static void Main()
    {
        MyCalci obj = new MyCalci();
        obj.a = 10;
        obj.b = 20;
        obj.c = 30;
        System.Console.WriteLine("sum="+obj.mysum());
        System.Console.WriteLine("sum=" + obj.mysum(110,210));
        System.Console.WriteLine("sum=" + obj.mysum(130,230,330));
    }
}
