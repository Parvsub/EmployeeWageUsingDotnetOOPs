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

    }
}