using System;
int a, b;
System.Console.Write("Enter a..:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter b..:");
b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("values before swap a=" + a + "\t" + "b=" + b);
a = a * b;
b = a / b;
a = a / b;
System.Console.WriteLine("values after swap a=" + a + "\t" + "b=" + b);
