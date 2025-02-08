using System;
class Emp
{
    public int eno;
    public string ename;
    public double esal;
    public void empdet()
    {
        System.Console.WriteLine("Eno="+eno+"\t"+"Ename="+ename+"\t"+"Esal="+esal);
    }
    public void empdet(int en,string ena)
    {
        eno= en;
        ename= ena;
        System.Console.WriteLine("Eno="+eno+"\t"+"Ename="+ename);
    }
    public void empdet(int en, string ena,double es)
    {
        eno = en;
        ename = ena;
        esal = es;
        System.Console.WriteLine("Eno=" + eno + "\t" + "Ename=" + ename+"\t"+"Esal="+esal);
    }
    public static void Main()
    {
        Emp e=new Emp();
        e.eno = 101;
        e.ename = "Anil";
        e.esal = 456.85;
        e.empdet();
        e.empdet(102,"Raju");
        e.empdet(103, "Ravi", 10000);
    }
}
