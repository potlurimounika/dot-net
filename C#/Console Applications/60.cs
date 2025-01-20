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
System.Console.WriteLine("select any one item(1|2|3|4)");
i = Convert.ToInt32(Console.ReadLine());
switch(1)
{
    case 1:
    System.Console.WriteLine("pen selected");
        break;
    case 2:
    System.Console.WriteLine("book selected");
        break;
    case 3:
    System.Console.WriteLine("eraser selected");
        break;
    case 4:
    System.Console.WriteLine("scale selected");
        break;
    default:
        System.Console.WriteLine("invalid selected");
} 
