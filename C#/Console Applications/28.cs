using System;
int x;
System.Console.Write("Enter a:");
x = Convert.ToInt32(Console.ReadLine());
if (x >= 0)
    if (x == 0)
        System.Console.WriteLine("zero");
    else
        System.Console.WriteLine("positive");
else
    System.Console.WriteLine("negative");
