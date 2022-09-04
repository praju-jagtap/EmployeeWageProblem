namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.addCompanyEmpWage("Cognizant", 10, 7, 160);
            employee.addCompanyEmpWage("TCS", 20, 5, 160);
            employee.ComputeEmpWage();
        }
    }
}