using System;
int a,b,c;
char ch;
do
{
    System.Console.Write("enter a:");
    a = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("enter b:");
    b = Convert.ToInt32(Console.ReadLine());
    c = a + b;
    System.Console.Write("sum=" + c);
    System.Console.Write("Do You Want To Do Again");
    ch = Convert.ToChar(Console.ReadLine());
} while (ch == 'Y' || ch == 'y');
