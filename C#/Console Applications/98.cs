using System;
abstract class Bank
{
    public abstract void itrate();
}
class SBI:Bank
{
    public override void itrate()
    {
        Console.WriteLine("SBI Bank Interest rate is 5%");
    }
}
class HDFC : Bank
{
    public override void itrate()
    {
        Console.WriteLine("HDFC Bank Interest rate is 9%");
    }
    public static void Main()
    {
        Bank b;
        b=new SBI();
        b.itrate();
        b=new HDFC();
        b.itrate();
    }
}
