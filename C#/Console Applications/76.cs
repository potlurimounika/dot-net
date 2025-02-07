using System;
struct Emp
{
    public int eno;
    public string ename;
    public double esal;
    public char egrade;
    public void getempdet()
    {
        System.Console.WriteLine("Enter eno:");
        eno=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter ename:");
        ename = Console.ReadLine();
        System.Console.WriteLine("Enter esal:");
        esal = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Enter egrade:");
        egrade = Convert.ToChar(Console.ReadLine());
    }
    public void putempdet()
    {
        System.Console.WriteLine("Eno="+eno);
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
        e.getempdet();
        e.putempdet();
    }
}
