using System;
class Myclass
{
    private int x;
    public void SetX(int i)
    {
        x = i;
    }
    public int GetX()
    {
        return x;
    }
}
class Myclient
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        mc.SetX(10);
        int Xval = mc.GetX();
        Console.WriteLine(Xval);
    }
}
