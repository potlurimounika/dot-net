using System;
class Myclass
{
    private int x;
    public int X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
}
class Myclient
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        mc.X = 10;
        int xval = mc.X;
        Console.WriteLine(xval);
    }
}
