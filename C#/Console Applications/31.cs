using System;
int a, b, c;
System.Console.Write("Enter a:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter b:");
b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter c:");
c = Convert.ToInt32(Console.ReadLine());

if(a>b&&a>c)
{
    System.Console.WriteLine("a is big");
}
else if(b>c)
{
    System.Console.WriteLine("b is big");
}
else
{
    System.Console.WriteLine("c is big");
}
