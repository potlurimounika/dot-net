using System;
int a, b;
System.Console.Write("Enter a:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter b:");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    System.Console.WriteLine("a is big");
}
else if (a < b)
{
    System.Console.WriteLine("b is big");
}
else  
{
    System.Console.WriteLine("Both are equal");
}
