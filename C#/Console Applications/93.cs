using System;
class React
{
    public int l;
    public int b;
    public int Carea()
    {
        return l*b;
    }
    public static void Main()
    {
        React R=new React();
        R.l = 20;
        R.b = 10;
        System.Console.WriteLine("Area="+R.Carea());
    }
}
