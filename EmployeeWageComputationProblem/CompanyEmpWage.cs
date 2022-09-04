using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    internal class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour, numOfWorkingDays, maxHourPerMonth, totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int noOfWorkingDays, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = noOfWorkingDays;
            this.maxHourPerMonth = maxHourPerMonth;

        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Employee Wages for Company " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
