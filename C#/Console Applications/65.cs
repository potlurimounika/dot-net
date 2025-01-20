using System;
int[] a = new int[5];
a[0] = 10;
a[1] = 20;
a[2] = 30;
a[3] = 40;
a[4] = 50;
int i,s=0,c=0;
double avg;
for (i = 1; i < a.Length; i++)
{
    System.Console.Write("\t" + a[i]);
    c = c + 1;
    s = s + a[i];
}
System.Console.WriteLine("count="+c);
System.Console.WriteLine("sum=" + s);
avg = s / a.Length;
System.Console.WriteLine("Average=" + avg);
