using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeSalaryUC2
    {
        public static void EmployeeWage()
        {
            //Constants
            int IS_FULL_TIME = 1, WagePerHrs = 20, TotalWorkingHrs;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present\n");
                TotalWorkingHrs = 8;
            }
            else 
            {
                Console.WriteLine("Employee is absent\n");
                TotalWorkingHrs = 0;
            }
            int EmpSalary = WagePerHrs * TotalWorkingHrs;
            Console.WriteLine("Employee salary is " +EmpSalary);
        }
    }
}
