using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageusingOOPs
{
    public class EmployeeWage
    {
        public const byte FULL_TIME = 1;
        public const byte PART_TIME = 2;
        public const byte FULL_WORKING_HOURS = 8;
        public const byte PART_WORKING_HOURS = 4;
        public const int WAGE_PER_HOUR = 20;
        public const byte WORKING_DAYS_PER_MONTH = 20;
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Employee Wage Problem");
        }
        public static int CheckAttendance()
        {
            Random objectOfRandom = new Random();
            int attendance = objectOfRandom.Next(0, 3);

            if (attendance == FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                return FULL_TIME;
            }
            else if (attendance == PART_TIME)
            {
                Console.WriteLine("Employee is PartTime Present");
                return PART_TIME;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                return 0;
            }
        }
        public int DailyWage()
        {
            int employeeHours;
            int employeeCheck = CheckAttendance();
            if (employeeCheck == FULL_TIME)
                employeeHours = FULL_WORKING_HOURS;
            else if (employeeCheck == PART_TIME)
                employeeHours = PART_WORKING_HOURS;
            else
                employeeHours = 0;

            int dailyWage = employeeHours * WAGE_PER_HOUR;

            Console.WriteLine($"Wage : {dailyWage}");
            return dailyWage;
        }

        public void PartTime()
        {
            int employeeCheck = DailyWage();
        }

        public int EmployeeSwitchCase()
        {
            int employeeHours;
            int employeeCheck = CheckAttendance();
            switch (employeeCheck)
            {
                case 1:
                    employeeHours = FULL_WORKING_HOURS;
                    Console.WriteLine("Employee is FullTime worker");
                    break;
                case 2:
                    employeeHours = PART_WORKING_HOURS;
                    Console.WriteLine("Employee is PartTime worker");
                    break;
                default:
                    employeeHours = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            int employeeWage = employeeHours * WAGE_PER_HOUR;
            Console.WriteLine("EmployeeWage: " + employeeWage);
            return employeeWage;
        }
        public int MonthlyWage()
        {
            int monthlyWage = 0;
            for (int day = 1; day <= WORKING_DAYS_PER_MONTH; day++)
            {
                int dailyWage = DailyWage();
                monthlyWage += dailyWage;
            }

            Console.WriteLine($"Monthly Wage is : {monthlyWage}");
            return monthlyWage;
        }

        public void EmployeeWageUsingCondition()
        {

            int TotalEmployeeHours = 0;
            int TotalWorkingDays = 0;
            int maximumHoursInMonth = 100;
            int employeeHours;
            int NumberOfWorkingDays = 20;
            while (TotalEmployeeHours <= maximumHoursInMonth && TotalWorkingDays < NumberOfWorkingDays)
            {
                TotalWorkingDays++;
                Random objectOfRandom = new Random();
                int employeecheck = objectOfRandom.Next(0, 3);
                switch (employeecheck)
                {
                    case 1:
                        employeeHours = FULL_WORKING_HOURS;
                        Console.WriteLine("Employee is FullTime worker");
                        break;
                    case 2:
                        employeeHours = PART_WORKING_HOURS;
                        Console.WriteLine("Employee is PartTime worker");
                        break;
                    default:
                        employeeHours = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                }
                TotalEmployeeHours += employeeHours;
                Console.WriteLine("Day : " + TotalWorkingDays + " employee Hours:" + employeeHours);
            }
            int TotalEmployeeWage = TotalEmployeeHours * WAGE_PER_HOUR;
            Console.WriteLine("Total Employee Wage: " + TotalEmployeeWage);
        }
    }
}
           
    