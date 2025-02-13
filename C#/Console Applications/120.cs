using System;
using System.Collections;
class Test
{
    static void Main()
    {
        Stack s = new Stack();
        s.Push("Pen");
        s.Push("Pencil");
        s.Push("Eraser");
        foreach(string x in s)
        {
            System.Console.WriteLine(x);
        }
        System.Console.WriteLine(".......................");
        s.Pop();
        foreach (string x in s)
        {
            System.Console.WriteLine(x);
        }
    }
}
