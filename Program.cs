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
            }
        }
    }
}