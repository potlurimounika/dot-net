using System;
using System.Collections;
class Test
{
 static void Main()
    {
        Hashtable hs = new Hashtable();
        hs.Add("1", "Pen");
        hs.Add("2", "Pencil");
        hs.Add("3", "Eraser");
        ICollection key = hs.Keys;
        foreach (string k in key)
        {
            Console.WriteLine(k + ":" + hs[k]);
        }
    }
}
