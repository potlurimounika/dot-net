using System;
class Test
{
    public static void Main()
    {
        StreamReader sr = new StreamReader("fruo.text");
        System.Console.WriteLine(sr.ReadToEnd());
        sr.Close();
    }
}
