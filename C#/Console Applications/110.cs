using System;
namespace HeightWeightInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Record myRecord = new Record(10, 15);
            myRecord.printRecord();
            Console.ReadLine();
        }
    }
}   
