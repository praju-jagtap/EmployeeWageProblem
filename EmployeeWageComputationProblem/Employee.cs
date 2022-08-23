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
        public void PartTime()
        {
            int empHrs = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else
                empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Part Time Employee And Wage : " + empWage);
        }
    }
}
