using System;
using System.Collections;
class Test
{
    static void Main()
    {
        SortedList hs = new SortedList
        {
            { "1", "Pen" },
            { "2", "Pencil" },
            { "3", "Eraser" }
        };
        ICollection key = hs.Keys;
        foreach (string k in key)
        {
            Console.WriteLine(k + ":" + hs[k]);
        }
    }
}
