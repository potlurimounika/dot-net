using System;
int a, b;
System.Console.Write("Enter a:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter b:");
b = Convert.ToInt32(Console.ReadLine());
int t = (a > b) ? a : b;
System.Console.WriteLine(t + "is big");
