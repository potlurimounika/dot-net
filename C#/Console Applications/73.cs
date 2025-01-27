using System;
int[,] a = { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
int[,] b = { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
int[,] c = new int[3, 3];
int i = 0, j = 0, k;

System.Console.WriteLine();
System.Console.WriteLine("A Matrix");
System.Console.WriteLine("........");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
        System.Console.Write("\t" + a[i, j]);
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine("B Matrix");
System.Console.WriteLine("........");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
        System.Console.Write("\t" + b[i, j]);
    System.Console.WriteLine();
}

for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        for (k = 0; k < 3; k++)
        {
            c[i, j] = a[i, k] * b[k, j];
        }
        System.Console.WriteLine();
    }
}
    System.Console.WriteLine();
System.Console.WriteLine("A*B Matrix");
System.Console.WriteLine("................");
for(i = 0; i < 3;i++)
{
    for(j = 0;j < 3;j++)
        System.Console.WriteLine("\t" + c[i,j]);
    System.Console.WriteLine();
}
