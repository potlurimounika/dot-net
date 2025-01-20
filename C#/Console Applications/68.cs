using System;
int[] a = new int[100];
int n, i,c=0,s=0;
double av;
System.Console.WriteLine("Enter size of Array:");
n = Convert.ToInt32(Console.ReadLine());
for (i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
    c = c + 1;
    s = s + a[i];
}
System.Console.Clear();
System.Console.WriteLine("Elements Are");
System.Console.WriteLine("....................");
for (i = 0; i < n; i++)
{
    System.Console.WriteLine();
    System.Console.WriteLine("count="+c);
    System.Console.WriteLine("sum=" + s);
    av = s / c;
    System.Console.WriteLine("Average=" + av);
}
