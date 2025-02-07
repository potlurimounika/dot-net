using System;
class IceCream
{
    public int price;
    public int quality;
    public double wt;
    public string color;
    public void melt()
    {
        System.Console.WriteLine("It melts at room temper ature");
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
        System.Console.WriteLine("price of vanilla="+vanilla.price);
        System.Console.WriteLine("quality of vanilla=" + vanilla.quality);
        System.Console.WriteLine("weight of vanilla=" + vanilla.wt);
        System.Console.WriteLine("color of vanilla=" + vanilla.color);
        vanilla.melt();
        System.Console.WriteLine("Bill Amount:"+vanilla.billamt());
    }
}
