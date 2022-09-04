namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee dmart = new Employee("Dmart", 20, 3, 10);
            dmart.ComputeEmpWage();
            Console.WriteLine(dmart.toString());
            Employee reliance = new Employee("Reliance", 10, 4, 20);
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}