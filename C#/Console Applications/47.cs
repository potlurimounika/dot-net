using System;
int i = 1, s = 0, n, r;
System.Console.Write("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
while (i <= n)
{
    r = n % 10;
    s = s * 10 + r;
    n= n / 10;
}
System.Console.WriteLine("Reverse="+s);
