using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeSalaryUC3
    {
        public static void EmpSalary()
        {
            //Constants
            int IS_FULL_TIME = 1,IS_PART_TIME=2, WagePerHrs = 20, TotalWorkingHrs;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Full-timer.\n");
                TotalWorkingHrs = 8;
            }
            else if(empCheck==IS_PART_TIME)
            {
                Console.WriteLine("Employee is Part-timer");
                TotalWorkingHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent\n");
                TotalWorkingHrs = 0;
            }
            int EmpSalary = WagePerHrs * TotalWorkingHrs;
            Console.WriteLine("Employee salary is " + EmpSalary);
        }
    }
}
