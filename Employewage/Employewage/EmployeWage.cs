﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employewage
{
    class EmployeWage
    {

        const int isFullTime = 1;
        const int isPartTime = 2;
        public int empRatePerHour = 20;
        public int workingDaysPerMonth = 20;
        public int totalSalaryForMonth = 0;
        public int totalWorkingHour = 100;
        public int empHour = 0;

        public int totalWorkingHours = 0;
        public int workingDays = 0;
        public void WageCalculation()
        {
            while (empHour <= totalWorkingHour && workingDays < workingDaysPerMonth)
            {
                workingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isFullTime:
                        empHour = 8;
                        break;
                    case isPartTime:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalWorkingHour += empHour;
            }

        }
        public void showSalary()
        {
            int salary = totalWorkingHour * empRatePerHour;
            Console.WriteLine(salary);
        }
    }

    internal class Emp : EmployeWage
    {
        public void showSalaryMsg()
        {
            Console.WriteLine("EmployeeWage  inheriting an class employee");
        }
    }

}


