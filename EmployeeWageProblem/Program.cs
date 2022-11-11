using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem statement");
            EmpWageBuilderObject byjus = new EmpWageBuilderObject("Byjus", 20, 2, 20);
            EmpWageBuilderObject extra = new EmpWageBuilderObject("ExtraMarks", 20, 2, 20);
            byjus.ComputeEmpWage();
            Console.WriteLine(byjus.ToString());
            extra.ComputeEmpWage();
            Console.WriteLine(extra.ToString());
        }
    }
}