using System;
int n,l=0,f=0,i=1;
System.Console.Write("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
l = n%10;
while (i <= n)
{
    f = n % 10;
    n = n / 10;
}
if (f == l)
{
    System.Console.WriteLine("Cyclo");
}
else
{
    System.Console.WriteLine("Not");
}
