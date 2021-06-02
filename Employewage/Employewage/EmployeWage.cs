using System;
using System.Collections.Generic;
using System.Text;

namespace Employewage
{
    class EmployeWage
    {

        public void EmpPresent()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_WAGE_PER_HR = 20;

            int employeeHr = 0;
            int totalEmployeeWage = 0;
            Random objRandom = new Random();
            int Check = objRandom.Next(0, 3);
            if (Check == IS_FULL_TIME)
            {
                employeeHr = 8;
                Console.WriteLine(" Employee Is Full time Employee");
            }
            else if (Check == IS_PART_TIME)
            {
                employeeHr = 4;
                Console.WriteLine(" Employee is Part time Employee");
            }
            else
            {
                employeeHr = 0;
                Console.WriteLine("Employee Is Absent");
            }

            totalEmployeeWage = employeeHr * EMP_WAGE_PER_HR;
            Console.WriteLine("Employee Wage is :" + totalEmployeeWage);
        }
    }
}
