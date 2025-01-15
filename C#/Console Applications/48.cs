using System;
int i = 1, s = 0, n, t, r;
System.Console.Write("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
t = n;
while (i <= n)
{
    r = n % 10;
    s = s * 10 + r;
    n = n / 10;
}
if (t == s)
{
    System.Console.WriteLine("Palindrome");
}
else
{
    System.Console.WriteLine("Not");
}
