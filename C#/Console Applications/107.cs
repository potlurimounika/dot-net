using System;
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }

    public void PrintMessage()
    {
        Console.WriteLine("Not Eligible To Vote");
    }
    public static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Invalid Age");
        }
        else
        {
            Console.WriteLine("Eligible To Vote");
        }
    }
}
class Test
{
    public int age;
    public static void Main(string[] args)
    {
        Test test = new Test();
        test.age = 45; 
        try
        {
            InvalidAgeException.CheckAge(test.age);  
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e.Message);
            e.PrintMessage();
        }
    }
}
