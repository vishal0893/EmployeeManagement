using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeSalaryUC4
    {
        public static void EmpSalarySwitchCase()
        {

            //Constants
            int IS_FULL_TIME = 0, IS_PART_TIME = 1, WagePerHrs = 20, TotalWorkingHrs=0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            switch(empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Full-timer.\n");
                    TotalWorkingHrs = 8;
                    break;
                case 1:
                    Console.WriteLine("Employee is Part-timer.\n");
                    TotalWorkingHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent.\n");
                    break;
            }
            int EmpSalary = WagePerHrs * TotalWorkingHrs;
            Console.WriteLine("Employee salary is " + EmpSalary);
        }
    }
}
