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
class C : A
{
    public void fofcc()
    {
        System.Console.WriteLine("Function of class C");
    }
}
class D : A
{
    public void fofcd()
    {
        System.Console.WriteLine("Function of class D");
    }
    public static void Main()
    {
        B objB = new B();
        objB.fofca();
        objB.fofcb();
        System.Console.WriteLine(".....................");
        C objC = new C();
        objC.fofca();
        objC.fofcc();
        System.Console.WriteLine(".....................");
        D objD = new D();
        objD.fofca();
        objD.fofcd();
    }
}
