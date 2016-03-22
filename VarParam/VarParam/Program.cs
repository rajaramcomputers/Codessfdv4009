using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarParam
{
    class Program
    {
        void Add(out int sum, params int[] val)
        {
            sum = 0;
            foreach (int i in val) { sum = sum + i; }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int newsum;
            p.Add(out newsum, 3, 5, 6, 6);

            Console.WriteLine("The variable Parameter output is " + newsum);
            Console.ReadKey();
        }
    }
}
