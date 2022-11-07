using System;

namespace EmployeeWageProblem
{
    class Program
    {
       
         public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage problem statement ");
            Console.WriteLine("1. Employee Attendace" + "\n" + "2. Daily Employee Wage" + "\n" + "3. Part Time Employee Wage" + "\n" + "4. Monthly Wage" + "\n" + "5. Condition Working Hours");
            Console.WriteLine("Enter The Above Mention Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
           
            {
                case 1:
                    EmployeeAttendance attendance = new EmployeeAttendance();
                    attendance.Attendance();
                    break;
                case 2:
                    DailyEmployeeWage employee = new DailyEmployeeWage();
                    employee.EmpWage();
                    break;
                case 3:
                    PartTimeEmployeeWage partTime = new PartTimeEmployeeWage();
                    partTime.PartTime();
                    break;
                case 4:
                    MonthlyWage working = new MonthlyWage();
                    working.WorkingDay();
                    break;
                case 5:
                    ConditionWorkingHours condition = new ConditionWorkingHours();
                    condition.Condition();
                    break;
            }

        }
    }
}
