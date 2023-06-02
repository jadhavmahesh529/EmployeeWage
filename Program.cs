namespace EmployeeWage
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            //Refactor refactor = new Refactor();
            //Refactor.CalculateDailyWage();




            Factroy factroy1 = new Factroy(10, 20, 8);
            Factroy factroy2 = new Factroy(15, 22, 7);

            int employeeWage1 = factroy1.CalculateEmployeeWage(160);
            Console.WriteLine($"Employee wage for company 1: {employeeWage1}");

            int employeeWage2 = factroy2.CalculateEmployeeWage(154);
            Console.WriteLine($"Employee wage for company 2: {employeeWage2}");
        }
    }

}   

        




