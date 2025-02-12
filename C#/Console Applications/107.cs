using System;
class Test
{
    public static void Main()
    {
        StreamWriter sw = new StreamWriter("fruo.text");
        sw.WriteLine("Apple");
        sw.WriteLine("Banana");
        sw.WriteLine("cherry");
        sw.Close();
    }
}
