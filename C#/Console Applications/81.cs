using System;
class Bird
{
    public int age;
    public int wings;
    public double wt;
    public string color;
    public void fly()
    {
        System.Console.WriteLine("they fly to fulfill natural activities");
    }
    public void BuildNest()
    {
        System.Console.WriteLine("they build nest to live");
    }
    public static void Main(String[] args)
    {
        Bird parrot = new Bird();
        parrot.age = 5;
        parrot.wings = 2;
        parrot.wt = 5.3;
        parrot.color = "green";
        System.Console.WriteLine("Age of parrot="+parrot.age);
        System.Console.WriteLine("Wings of parrot=" + parrot.wings);
        System.Console.WriteLine("Weight of parrot=" + parrot.wt);
        System.Console.WriteLine("Color of parrot=" + parrot.color);
        parrot.fly();
        parrot.BuildNest();
    }
}
