using System;
class A
{
    public void fofca()
    {
        System.Console.WriteLine("Function of class A");
    }
}
class B:A
{
    public void fofcb()
    {
        System.Console.WriteLine("Function of class B");
    }
    public static void Main()
    {
        B objB=new B();
        objB.fofca();
        objB.fofcb();
    }
}
