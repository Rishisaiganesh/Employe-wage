using System;
using System.Collections.Generic;
using System.Text;

namespace Employewage
{
   public class EmployeWage
    {

        ///Constants
        public const int IS_FullTime = 1;
        public const int IS_PartTime = 2;
        public const int Employe_Salary_Per_HR = 20;
        public const int Monthly_working_Days = 20;
        public const int Total_Working_HrinMonth = 100;

        ///Variables

        public int EMPHR = 0;
        public int Workingdays = 0;
        public int TotalWorkingHR = 0;

        ///IMPLEMENTING CLASS WorkHR

        public void WorkHR()
        {
            while (EMPHR <= Total_Working_HrinMonth && Workingdays < Monthly_working_Days)
            {
                Workingdays++;

                Random EMP = new Random();
                int empwage = EMP.Next(0, 3);
                switch (empwage)
                {
                    case IS_FullTime:
                        EMPHR = 8;
                        break;
                    case IS_PartTime:
                        EMPHR = 4;
                        break;
                    default:
                        EMPHR = 0;
                        break;


                }
                TotalWorkingHR += EMPHR;
            }

        }
    }
    /// <summary>
    /// inheratance
    /// </summary>
    public class Salary : EmployeWage
    {
       public void MonthlySalary()
        {
            WorkHR();
            int monthlysalary = TotalWorkingHR * Employe_Salary_Per_HR;
            Console.WriteLine("Monthly Salary:" + monthlysalary);
        }

    }
}






