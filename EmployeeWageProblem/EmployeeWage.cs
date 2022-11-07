using System;
using System.Drawing;

namespace EmployeeWageProblem
{

    public class EmployeeWage
    {
        const int FULL_DAY_HR = 8, HALF_DAY_HR = 4, IS_PRESENT = 0, IS_FULL_TIME = 1, IS_PART_TIME = 2, Company_Name=0;
        public static int EmpWage(string Company_Name, int WAGE_PER_HR, int TOTAL_WORKING_DAYS, int TOTAL_WORKING_HRS)
       
        {
                int totalEmpWage = 0, empHrs = 0;
                for (int i = 0; i < TOTAL_WORKING_DAYS && empHrs < TOTAL_WORKING_HRS; i++)
                {
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            empHrs += FULL_DAY_HR;
                            break;
                        case IS_PART_TIME:
                            empHrs += HALF_DAY_HR;
                            break;
                        default:
                            empHrs += 0;
                            break;
                    }
                }
            totalEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Total Employee Wage For Company " + Company_Name + " is : " + totalEmpWage);
            return totalEmpWage;
            }
        }
    }