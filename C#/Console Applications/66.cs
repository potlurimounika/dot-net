using System;
int[] a = new int[5];
a[0] = 10;
a[1] = 20;
a[2] = 30;
a[3] = 40;
a[4] = 50;
int i, max = a[0], min = a[0];
for (i = 0; i < a.Length; i++)
{
    System.Console.Write("\t" + a[i]);
    if (a[i] > max)
    {
        max = a[i];
    }
    else if (a[i] < min)
    {
        min = a[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine("max="+max);
System.Console.WriteLine("min=" + min);
