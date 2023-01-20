using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int isPresent = 1;
            int empHrs = 0;
            const int empRatePerHr =20
            Console.WriteLine("Welcome To EmployeeWage Computation");

            //UC1 - EmployeeAttendence
            Random random = new Random();
            int empAttendence = random.Next(0,2); //0 or 1
            if (empAttendence == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
