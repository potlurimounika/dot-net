using System;
class IceCream
{
    public int price;
    public int quality;
    public double wt;
    public string color;
    public void melt()
    {
        System.Console.WriteLine("It melts at room temperature");
    }
    public int billamt()
    {
        return price * quality;
    }
    public static void Main()
    {
        IceCream vanilla = new IceCream();
        vanilla.price = 20;
        vanilla.quality = 500;
        vanilla.wt = 45.5;
        vanilla.color = "white";
        System.Console.WriteLine("price of vanilla=" + vanilla.price);
        System.Console.WriteLine("quality of vanilla=" + vanilla.quality);
        System.Console.WriteLine("weight of vanilla=" + vanilla.wt);
        System.Console.WriteLine("color of vanilla=" + vanilla.color);
        vanilla.melt();
        System.Console.WriteLine("Bill Amount:" + vanilla.billamt());
        System.Console.WriteLine(".......................");
        IceCream chocolate = new IceCream();
        chocolate.price = 20;
        chocolate.quality = 500;
        chocolate.wt = 45.5;
        chocolate.color = "white";
        System.Console.WriteLine("price of chocolate=" + chocolate.price);
        System.Console.WriteLine("quality of chocolate=" + chocolate.quality);
        System.Console.WriteLine("weight of chocolate=" + chocolate.wt);
        System.Console.WriteLine("color of chocolate=" + chocolate.color);
        chocolate.melt();
        System.Console.WriteLine("Bill Amount:" + chocolate.billamt());
    }
}
