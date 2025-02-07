using System;
class MyCalci
{
    public int a;
    public int b;
    public void getvals()
    {
        System.Console.WriteLine("Enter a:");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter b:");
        b = Convert.ToInt32(Console.ReadLine());
    }
    public void putvals()
    {
        System.Console.WriteLine("a:" + a);
        System.Console.WriteLine("b:" + b);
    }
    public int mysum()
    {
        return a+b;
    }
    public int mysub()
    {
        return a - b;
    }
    public int mymul()
    {
        return a * b;
    }
    public int mydiv()
    {
        return a / b;
    }
    public int mymod()
    {
        return a % b;
    }
    public static void Main()
    {
        MyCalci MC=new MyCalci();
        int x;
        MC.getvals();
        MC.putvals();
        System.Console.WriteLine(".............................");
        System.Console.WriteLine("simple calculator");
        System.Console.WriteLine(".............................");
        System.Console.WriteLine("1.add");
        System.Console.WriteLine("2.subtract");
        System.Console.WriteLine("3.multiply");
        System.Console.WriteLine("4.divide");
        System.Console.WriteLine("5.module");
        System.Console.WriteLine(".............................");
        System.Console.WriteLine("enter any one option(1-5):");
        x=Convert.ToInt32(Console.ReadLine());
        switch(x)
        {
            case 1:
                System.Console.WriteLine("sum is:"+MC.mysum());
                break;
            case 2:
                System.Console.WriteLine("sub is:" + MC.mysub());
                break;
            case 3:
                System.Console.WriteLine("mul is:" + MC.mymul());
                break;
            case 4:
                System.Console.WriteLine("div is:" + MC.mydiv());
                break;
            case 5:
                System.Console.WriteLine("mod is:" + MC.mymod());
                break;
            default:
                System.Console.WriteLine("Invalid Option");
                break;
        }
    }
}
