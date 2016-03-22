using System;

namespace PrivateEmp
{
    class Employee2
    {
        private string name = "FirstName, LastName";
        private double salary = 100.0;

        public string GetName()
        {
            return name;
        }

        public double Salary
        {
            get { return salary; }
        }
    }

    class PrivateTest
    {
        static void Main()
        {
            Employee2 e = new Employee2();

            // The data members are inaccessible (private), so
            // they can't be accessed like this:
            //    string n = e.name;
            //    double s = e.salary;

            // 'name' is indirectly accessed via method:
            string n = e.GetName();
            Console.WriteLine("The Name of the employee is " + n);


            // 'salary' is indirectly accessed via property
            double s = e.Salary;

            Console.WriteLine("The Salary is " + s);

            Console.ReadLine();
        }
    }
}
