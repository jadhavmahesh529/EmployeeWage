using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Factroy
    {
        public int wage;
        public int workingDays;
        public int workingHours;

        public Factroy(int wage, int workingDays, int workingHours)
        {
            this.wage = wage;
            this.workingDays = workingDays;
            this.workingHours = workingHours;
        }

        public int CalculateEmployeeWage(int hoursWorked)
        {
            int dailyWage = (int)((wage * workingHours) / workingDays);
            int totalWage = (int)((dailyWage * hoursWorked) / workingHours);
            return totalWage;

        }
    }
}


