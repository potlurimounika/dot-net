using System;
class Person
{
    public void walk()
    {
        System.Console.WriteLine("Person walks slowly");
    }
}
class Employee:Person
{
    public void walk()
    {
        System.Console.WriteLine("Employee walks Fast");
    }
    static void Main()
    {
        Employee employee = new Employee();
        employee.walk();
    }
}
