using System;
int i = 1,f=1,n;
System.Console.Write("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
while(i<=n)
{
    f = f * i;
    i = i + 1;
}
System.Console.Write("factorial of" + n + "is=" + f);
