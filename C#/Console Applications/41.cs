using System;
int i = 99;
while (i >= 2)
{
    System.Console.WriteLine(i +"bottles of beer on the wall," + i + "bottles of beer.");
    System.Console.WriteLine("Take one down and pass it around," + (i - 1) + "bootles of beer on the wall.\n");
    i = i - 1;
}
System.Console.WriteLine(1 + "bottles of beer on the wall," + 1 + "bottles of beer.");
System.Console.WriteLine("Take one down and pass it around, no more bootles of beer on the wall.\n");
System.Console.WriteLine("no more bottles of beer on the wall,no more bottles of beer.");
System.Console.WriteLine("go to the store and buy some more,99 bottles of beer on the wall.");
