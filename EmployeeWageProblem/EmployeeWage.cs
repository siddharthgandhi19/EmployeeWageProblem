using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace EmployeeWageProblem
{

    public class EmpWageBuilderObject
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2;

        private string company;
        private int empRatePerHrs;
        private int numOfWokringDays;
        private int maxHrsPerMonth;
        private int totalEmpWage;
        public EmpWageBuilderObject(string company, int empRatePerHrs, int numOfWokringDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numOfWokringDays = numOfWokringDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void ComputeEmpWage()

        {
            int totalEmpHrs = 0, empHrs = 0, TOTAL_WORKING_DAYS = 0, totalEmpWage = 0;
            while (totalEmpHrs <= this.maxHrsPerMonth && TOTAL_WORKING_DAYS < this.numOfWokringDays)
            {
                TOTAL_WORKING_DAYS++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + TOTAL_WORKING_DAYS + "Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHrs;
            Console.WriteLine("Total Employee Wage of the Company " + company + " is : " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is " + this.totalEmpWage;
        }
    }
}