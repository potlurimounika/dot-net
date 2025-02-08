using System;
class Car
{
    string brand;
    Car(string theBrand)
    {
        brand=theBrand;
    }
    Car(Car c1)
    {
        brand = c1.brand;
    }
    static void Main(string[] args)
    {
        Car car1 = new Car("Bugatti");
        Console.WriteLine("Brand of car1:"+car1.brand);
        Car car2 = new Car(car1);
        Console.WriteLine("Brand of car2:" + car2.brand);
        Console.ReadLine();
    }
}
