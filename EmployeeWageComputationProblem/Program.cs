namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ComputeEmpWage("Dmart",20,100,20);
            emp.ComputeEmpWage("Reliance",21,100,20);
            emp.ComputeEmpWage("TCS",19,120,21);
        }
    }
}