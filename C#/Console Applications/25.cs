using System;
using System.ComponentModel.Design;
int a, b;
System.Console.Write("Enter a:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter b:");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("a is big");
}
else if(a<b)
{
    Console.WriteLine("b is big");
}
