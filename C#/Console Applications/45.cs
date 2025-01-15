using System;
int i = 1, c = 0, n;
System.Console.Write("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
while (i <= n)
{
    n = n / 10;
    c = c + 1;
}
System.Console.WriteLine("count=" + c);
