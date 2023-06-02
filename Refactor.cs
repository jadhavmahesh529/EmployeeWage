using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Refactor
    {
        public static int wagePerHour = 20;
        public static int fullDayHours = 8;
        public static int partTimeHours = 4;
        public static int workingDaysPerMonth = 20;
        public static int workingHoursLimit = 100;
        public static int workingDaysLimit = 20;
        public  void Main(string[] args)
        {
            Random random = new Random();
            int attendance = random.Next(2);

            if (attendance == 1)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
                CalculateDailyWage();
                CalculateTimeWageHours();
                CalculateMonthlyWage();
                CalculateTotalWage();
            }
;
        }
        public static void CalculateDailyWage()
        {
            int dailyWage = wagePerHour * fullDayHours;

            Console.WriteLine("Daily Employee Wage: $" + dailyWage);

        }
        public static void CalculateTimeWageHours()
        {
            int fullTimeWage = wagePerHour * fullDayHours;
            int partTimeWage = wagePerHour * partTimeHours;

            Console.WriteLine("Full-time Employee Wage: $" + fullTimeWage);
            Console.WriteLine("Part-time Employee Wage: $" + partTimeWage);
        }
        public static void CalculateMonthlyWage()
        {
            int monthlyWage = 0;
            int fullTimeWage = wagePerHour * fullDayHours;
            int partTimeWage = wagePerHour * partTimeHours;
            for (int day = 1; day <= workingDaysPerMonth; day++)
            {
                switch (day % 3)
                {
                    case 0:
                        monthlyWage += partTimeWage;
                        break;
                    default:
                        monthlyWage += fullTimeWage;
                        break;
                }
            }
            Console.WriteLine(" Monthly Employee Wage: $" + monthlyWage);
        }
        public static void CalculateTotalWage()
        {
            int totalWage = 0;
            int totalWorkingHours = 0;
            int totalWorkingDays = 0;

            while (totalWorkingHours < workingHoursLimit && totalWorkingDays < workingDaysLimit)
            {
                switch (totalWorkingDays % 3)
                {
                    case 0:
                        totalWage += wagePerHour * partTimeHours;
                        totalWorkingHours += partTimeHours;
                        break;
                    default:
                        totalWage += wagePerHour * fullDayHours;
                        totalWorkingHours += fullDayHours;
                        break;
                }

                totalWorkingDays++;

            }
            Console.WriteLine("Total Monthly Employee Wage: $" + totalWage);

        }
    }
}
