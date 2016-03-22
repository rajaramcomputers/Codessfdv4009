using System;

namespace ParamExample
{
  class Program
    {
        
        void inc(int x) { x = x + 1; }
        void F()
        {
            int val = 3;
            inc(val);
            Console.WriteLine(val); //there won't be any change in the val
        }
        void inc1(ref int x) { x = x + 1; }
        void F1()
        {
            int val1 = 3;
            inc1(ref val1);
            Console.WriteLine(val1); //the value will change in the val
        }

        void Read(out int a, out int b) { a = 10; b = 20; }

        void F2()
        {

            int first, next;
            Read(out first, out next);

            Console.WriteLine(first);
            Console.WriteLine(next);
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.F();
            p.F1();
            p.F2();
            Console.ReadKey();
            
        }
    }
}
