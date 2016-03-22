using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace variblelistlength
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add("Charly");
            a.Add("Delta");
            a.Add("Alpha");
            a.Sort();
            for (int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i]);
            Console.ReadKey();
        }
    }
}
