using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    internal class Employee
    {
        const int IS_PART_TIME = 1, IS_FULL_TIME = 2, EMP_RATE_PER_HOUR = 20;
        public void CalculateEmpWage()
        {
            int empHrs = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck) 
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Using Switch Case The Part Time Employee And Wage is : " + empWage);
        }
    }
}
