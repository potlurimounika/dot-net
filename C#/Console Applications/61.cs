using System;
int i;
System.Console.WriteLine("Enter a value for i:");
i = Convert.ToInt32(Console.ReadLine());
if(i%2==0)
{
    goto evena;
}
else
{
    goto odda;
}
evena:
    System.Console.WriteLine("Number is even");
return;
odda:
    System.Console.WriteLine("Number is odd");
