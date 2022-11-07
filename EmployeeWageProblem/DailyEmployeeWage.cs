﻿using System;
namespace EmployeeWageProblem
{
    public class DailyEmployeeWage
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, IS_PRESENT = 0, IS_FULL_TIME = 1;
        Random random = new Random();

            public void EmpWage()
        {
            int dailyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHrs = FULL_DAY_HR;
            else
                empHrs = 0;
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily emp wage" + dailyEmpWage);
        }
    }
}

