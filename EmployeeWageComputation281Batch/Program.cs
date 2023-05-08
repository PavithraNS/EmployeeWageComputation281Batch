using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation281Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME=1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welcome to EmployeeWageCompute");
            Random random = new Random();
            int randomInput=random.Next(0,2); //0 or 1
            if (FULL_TIME == randomInput)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage per day:{0}",empWage);
            Console.ReadLine();
        }

    }
}
