using System;
namespace A
{
    class Test
    {
        public void GreetOne()
        {
            System.Console.WriteLine("Good Morning");
        }
    }
    namespace B
    {
        class Test
        {
            public void GreetOne()
            {
                System.Console.WriteLine("Good Afternoon");
            }
        }
        namespace C
        {
            class Test
            {
                public void GreetOne()
                {
                    System.Console.WriteLine("Good Neight");
                }
                public static void Main()
                {
                    A.Test obj1 = new A.Test();
                    obj1.GreetOne();
                    B.Test obj2 = new B.Test();
                    obj2.GreetOne();
                    C.Test obj3 = new C.Test();
                    obj3.GreetOne();
                }
            }
        }
    }
}
