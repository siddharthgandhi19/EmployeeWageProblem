using System;
namespace EmployeeWageProblem
{
    public class EmployeeAttendance
    {
        const int IS_PRESENT = 0;
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    }
}
