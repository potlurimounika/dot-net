using System;
int age;
System.Console.WriteLine("Enter your age:");
age = Convert.ToInt32(Console.ReadLine());
if(age>=65)
{
    System.Console.WriteLine("senior citizen");
    System.Console.WriteLine("you are eligible to vate");
}
else if(age<=65&&age>=18)
{
    System.Console.WriteLine("major citizen");
    System.Console.WriteLine("you are eligible to vate");

}
else if (age<18)
{
    System.Console.WriteLine("minor citizen");
    System.Console.WriteLine("you are not eligible to vate");

}
