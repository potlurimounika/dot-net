using System;
int i = 1,n;
System.Console.WriteLine("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
while(i<=n)
{
    System.Console.WriteLine("\t" + i);
    i = i + 1;
}
