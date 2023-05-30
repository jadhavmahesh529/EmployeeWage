namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random random = new Random();
                int attendance = random.Next(2);

                if (attendance == 1)
                {
                    Console.WriteLine("Employee is Present");
                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }
                int wagePerHour = 20;
                int fullDayHours = 8;

                int dailyWage = wagePerHour * fullDayHours;

                Console.WriteLine("Daily Employee Wage: $" + dailyWage);

                int partTimeHours = 4;

                int fullTimeWage = wagePerHour * fullDayHours;
                int partTimeWage = wagePerHour * partTimeHours;

                Console.WriteLine("Full-time Employee Wage: $" + fullTimeWage);
                Console.WriteLine("Part-time Employee Wage: $" + partTimeWage);
                int workingDaysPerMonth = 20;

                int monthlyWage = 0;

                for (int day = 1; day <= workingDaysPerMonth; day++)
                {
                    switch (day % 3)
                    {
                        case 1:
                            monthlyWage += partTimeWage;
                            break;
                        default:
                            monthlyWage += fullTimeWage;
                            break;
                    }
                }

                Console.WriteLine("Monthly Employee Wage: $" + monthlyWage);

                int workingHoursLimit = 100;
                int workingDaysLimit = 20;

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
}