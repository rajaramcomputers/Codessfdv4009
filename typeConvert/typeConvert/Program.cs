using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;
            double j;
            // cast double to int.
            i = (int)d;
            j = i;
            Console.WriteLine("{0:4x}",i);
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
