using System;

namespace MethodOverExample
{
    class Program
    {
        static void Foo(int x)
        {
            Console.WriteLine("Foo(int x)"+x);
        }

        static void Foo(string y)
        {
            Console.WriteLine("Foo(string y)"+y);
        }
        static void Main(string[] args)
        {
            Foo(10);
            Foo("Ramkumar");
            Console.ReadLine();
        }
    }
}
