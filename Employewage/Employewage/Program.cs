using System;

namespace Employewage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greating Employee !");
            EmployeWage employee = new EmployeWage();
            employee.showSalary();
            Console.ReadKey();

        }
    }
}
