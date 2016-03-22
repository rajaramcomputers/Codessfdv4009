using System;


namespace ConstructorExample
{

    public class Employee
    {
        public int salary;

        public Employee(int annualSalary)
        {
            salary = annualSalary;
        }

        public Employee(int weeklySalary, int numberOfWeeks)
        {
            salary = weeklySalary * numberOfWeeks;
        }
    

    static void Main(string[] args)
        {
            Employee e1 = new Employee(30000);
            Employee e2 = new Employee(500, 52);

            Console.WriteLine("The Salary of e1 {0}, Salary of e2 {1}", e1.salary, e2.salary);
            Console.ReadKey();


        }
    }
}

