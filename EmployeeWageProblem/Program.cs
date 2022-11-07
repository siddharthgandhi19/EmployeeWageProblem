using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage problem statement ");
            EmpWages employee = new EmpWages();
            employee.Attendance();
            employee.EmpWage();
        }
    }
}
