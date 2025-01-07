using System;
using System.ComponentModel.Design;
int a,b,c,d,e;
System.Console.Write("Enter a:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter b:");
b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter c:");
c = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter d:");
d = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter e:");
e = Convert.ToInt32(Console.ReadLine());
int x = a;
if (b > x) 
{
    x = b;
}
 if (c > x)
{
    x = c;
}
 if(d>x)
{
    x = d;
}
 if(e>x)
{
    x = e;
}
System.Console.WriteLine(x + "is big");
