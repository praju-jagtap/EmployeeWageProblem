﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    internal class Employee
    {
        const int IS_PART_TIME = 1, IS_FULL_TIME = 2, EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAY = 2, MAX_HOUR_IN_MONTH = 10;
        public void TotalWorkingHour()
        {
            int empHrs = 0, totalEmpHrs=0, totalWorkingDays = 0;
            while(totalEmpHrs <= MAX_HOUR_IN_MONTH && totalEmpHrs < NUM_OF_WORKING_DAY)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "\nEmployee Working Hours: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
        }
    }
}
