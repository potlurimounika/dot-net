using System;
int i;
System.Console.WriteLine(".......................");
System.Console.WriteLine("\t \t Menu");
System.Console.WriteLine(".......................");
System.Console.WriteLine("1 pen");
System.Console.WriteLine("2 book");
System.Console.WriteLine("3 eraser");
System.Console.WriteLine("4 scale");
System.Console.WriteLine(".......................");
System.Console.WriteLine("select any one item(1,2,3,4)");
i = Convert.ToInt32(Console.ReadLine());
if(i==1)
{
    System.Console.WriteLine("pen selected");
}
else if(i==2)
{
    System.Console.WriteLine("book selected");
}
else if (i == 3)
{
    System.Console.WriteLine("eraser selected");
}
else if (i == 4)
{
    System.Console.WriteLine("scale selected");
}
else
{
    System.Console.WriteLine("invalid selected");
}
