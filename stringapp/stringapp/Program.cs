using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //from string literal and string concatenation
            string fname, lname;
            fname = "Ramkumar";
            lname = "Lakshminarayanan";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //by using string constructor
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //methods returning string
            string[] sarray = { "Hello", "From", "SFDV", "4009" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            Console.WriteLine("The length of the String : {0}", message.Length);
            Console.ReadKey();
        }
    }
}
