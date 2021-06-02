using System;
using System.Collections.Generic;
using System.Text;

namespace Employewage
{
    class EmployeWage
    {

        public void EmpPresent()
        {
            const int IS_PRESENT = 1;
            Random objRandom = new Random();
            int Check = objRandom.Next(0, 2);
            if (Check == IS_PRESENT)
            {
                Console.WriteLine(" Employee Is Present");
            }
            else
            {
                Console.WriteLine(" Employee is absent");
            }
        }
    }
}
