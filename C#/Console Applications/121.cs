class Test
{
    public static void Main()
    {
        Queue<char> q = new();
        q.Enqueue('A');
        q.Enqueue('M');
        q.Enqueue('G');
        q.Enqueue('W');
        foreach (char c in q)
        {
            Console.Write(c + " ");
        }
        char ch = q.Dequeue();
        Console.WriteLine();
        Console.WriteLine("The removed value: {0}", ch);
    }
}
