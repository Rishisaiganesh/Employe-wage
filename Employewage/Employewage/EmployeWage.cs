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
        ///Variables

        public int EMPHR = 0;
        public int Workingdays = 0;
        public int TotalWorkingHR = 0;

        /// <summary>
        /// <para name="Company"></para>
        /// <para name="Monthly_working_Days"></para>
        /// <para name="Employe_Salary_Per_HR"></para>
        /// <para name="Total_Working_HrinMonth"></para>
        /// </summary>

        public void WorkHR(string company, int Employe_Salary_Per_HR, int Monthly_working_Days, int Total_Working_HrinMonth)
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
                        Console.WriteLine("FullTimeSalary");
                        break;
                    case IS_PartTime:
                        EMPHR = 4;
                        Console.WriteLine("PartTimeSalary");
                        break;
                    default:
                        EMPHR = 0;
                        Console.WriteLine("Employe is Absent");
                        break;


                }
                TotalWorkingHR += EMPHR;
            }
            int Salary = Workingdays * EMPHR;
            Console.WriteLine("CompanyName:" + company + "Total Salary paying by company:" + Salary);


        }
    }


}







