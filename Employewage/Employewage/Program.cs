using System;

namespace Employewage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greating Employee !");
            EmployeWage Salary = new EmployeWage("XYZ",100,20,100);

            Salary.salary();
            Console.WriteLine(Salary.totalsal());

                
        }
    }
}
