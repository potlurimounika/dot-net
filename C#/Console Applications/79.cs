using System;
class Bird
{
    public void fly()
    {
        System.Console.WriteLine("They fly to fulfill natural activities");
    }
    public void builsNest()
    {
        System.Console.WriteLine("they buile nest to live"); 
    }
    public static void Main(String[] args)
    {
        Bird parrot = new Bird();
        parrot.fly();
        parrot.builsNest();
    }
}
