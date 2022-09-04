using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    internal class Employee
    {
        const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
        private string company;
        private int empRatePerHour, numOfWorkingDays, maxHourPerMonth, totalEmpWage;
        public Employee(string company, int empRatePerHour, int noOfWorkingDays, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = noOfWorkingDays;
            this.maxHourPerMonth = maxHourPerMonth;
        }
        public void ComputeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHourPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 4;
                        break;
                    case IS_PART_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + ", Employee Hours : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
        }
        public string toString()
        {
            return "Total Employee Wages for Company " + this.company + " is: " + this.totalEmpWage;
        }
    }
}

