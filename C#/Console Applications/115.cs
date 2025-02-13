using System;
class Greeks
{
    public string[] values = new string[3];
    public string this[int index]
    {
        get
        {
            return values[index];
        }
        set
        {
            values[index] = value;
        }
    }
    static void Main()
    {
        Greeks g = new Greeks();
        g[0] = "C";
        g[1] = "C++";
        g[2] = "C#";
        Console.WriteLine("First value: " + g[0]);
        Console.WriteLine("Second value: " + g[1]);
        Console.WriteLine("Third value: " + g[2]);
    }
}
