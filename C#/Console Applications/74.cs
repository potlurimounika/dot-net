using System;
struct Emp
{
    public int eno;
    public string ename;
    public double esal;
    public char egrade;
}
class Test
{
    public static void Main()
    {
        Emp e = new Emp();
        e.eno = 101;
        e.ename = "chinni";
        e.esal = 4325.75;
        e.egrade = 'A';
        System.Console.WriteLine("............");
        System.Console.WriteLine("Eno="+e.eno);
        System.Console.WriteLine("Ename=" + e.ename);
        System.Console.WriteLine("Esal=" + e.esal);
        System.Console.WriteLine("Egrade=" + e.egrade);
        System.Console.WriteLine("............");
    }
}
