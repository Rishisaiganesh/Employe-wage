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

        private string Company;
        private int EMP_Salary_pr_HR;
        private int NO_Of_Working_Days;
        private int Max_HR_PR_Month;
        private int Total_Wage;
        /// <summary>
        /// Creating EmployeWage Class
        /// </summary>
        /// <param name="company"></param>
        /// <param name="EmpSalaryprHR"></param>
        /// <param name="noworkingDays"></param>
        /// <param name="MaxHRinMonth"></param>
        public EmployeWage(string company, int EmpSalaryprHR, int noworkingDays, int MaxHRinMonth)
        {
            Company = company;
            EMP_Salary_pr_HR = EmpSalaryprHR;
            NO_Of_Working_Days = noworkingDays;
            Max_HR_PR_Month = MaxHRinMonth;

        }

        public void salary()
        {
            /// variables
            int empHR = 0;
            int TotalEMPHR = 0;
            int TotalWorkingDays = 0;
            while (empHR <= Max_HR_PR_Month && TotalWorkingDays < NO_Of_Working_Days)
            {
                TotalEMPHR++;
                Random EMP = new Random();
                int Check = EMP.Next(0, 3);
                switch (Check)
                {
                    case IS_FullTime:
                        empHR = 8;
                        break;
                    case IS_PartTime:
                        empHR = 4;
                        break;
                    default:
                        empHR = 0;
                        break;

                }
                TotalEMPHR += empHR;
                Console.WriteLine("Day:" + TotalWorkingDays + "NUMBER OF HOURS EMP DONE:" + empHR);

            }
            Total_Wage = TotalEMPHR * EMP_Salary_pr_HR;
            Console.WriteLine("TotalEmploye Wage:" + Company + Total_Wage);


        }
        public string totalsal()
        {
            return Company + Total_Wage;

        }
    }


}







