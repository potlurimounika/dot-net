using System;
class A
{
    public void fofca()
    {
        System.Console.WriteLine("Function of class A");
    }
}
class B : A
{
    public void fofcb()
    {
        System.Console.WriteLine("Function of class B");
    }
}
class C:B
{
    public void fofcc()
    {
        System.Console.WriteLine("Function of class C");
    }
    public static void Main()
    {
        B objB = new B();
        objB.fofca();
        objB.fofcb();
        System.Console.WriteLine(".....................");
        C objC = new C();
        objC.fofca();
        objC.fofcb();
        objC.fofcc();
    }
}
