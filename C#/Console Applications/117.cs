using System;
using System.Collections;
class Test
{
   public static void Main()
    {
       ArrayList AT = new ArrayList();
        System.Console.WriteLine(AT);
        Console.WriteLine("capacity:{0}",AT.Capacity);
        Console.WriteLine("count:{0}", AT.Count);
        AT.Add("pen");
        AT.Add("pencil");
        AT.Add("book");
        Console.WriteLine("capacity:{0}", AT.Capacity);
        Console.WriteLine("count:{0}", AT.Count);
        foreach(string x in AT)
            {
            System.Console.WriteLine(x + "\t");
        }
    }
}
