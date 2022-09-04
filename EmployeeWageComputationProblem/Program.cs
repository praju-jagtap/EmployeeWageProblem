namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee dmart = new Employee("Dmart", 20, 10, 100);
            dmart.ComputeEmpWage();
            Console.WriteLine(dmart.toString());
            Employee reliance = new Employee("Reliance", 10, 8, 200);
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}