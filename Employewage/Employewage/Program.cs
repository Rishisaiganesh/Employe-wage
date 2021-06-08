using System;

namespace Employewage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greating Employee !");
            EmployeWage Salary = new EmployeWage();
            Console.WriteLine("EmployeSalary");
            Salary.WorkHR("Xyz", 100, 20, 100);
          
        }
    }
}
