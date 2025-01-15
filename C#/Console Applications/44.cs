using System;
int i = 1, f = 1, n;
System.Console.Write("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("number \t factorial");
System.Console.WriteLine("............................");
while (i <= n)
{
    f = f * i;
    System.Console.WriteLine(i + "\t" + f);
    i = i + 1;
}
