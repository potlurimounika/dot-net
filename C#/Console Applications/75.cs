using System;
struct Emp
{
    public int eno;
    public string ename;
    public double esal;
    public char egrade;
    public void putempdet()
    {
        System.Console.WriteLine("Eno=" + eno);
        System.Console.WriteLine("Ename=" + ename);
        System.Console.WriteLine("Esal=" + esal);
        System.Console.WriteLine("Egrade=" + egrade);
    }
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
        e.putempdet();
    }
}
