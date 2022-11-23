using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeSalaryUC6
    {
        public static void EmpSalary()
        {
            //Constants
            int IS_FULL_TIME = 0, IS_PART_TIME = 1, WagePerHrs = 20, TotalWorkingHrs =0, EmpSalary = 0, TotalWorkingDays = 0, EmpHrs=0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            while(TotalWorkingHrs<100 && TotalWorkingDays<20)
            {
                TotalWorkingHrs++;
                
                    TotalWorkingDays++;
                    switch (empCheck)
                    {
                        case 0:
                            Console.WriteLine("Employee is Full-timer.\n");
                            EmpHrs = 8;
                            break;
                        case 1:
                            Console.WriteLine("Employee is Part-timer.\n");
                            EmpHrs = 4;
                            break;
                        default:
                            Console.WriteLine("Employee is Absent.\n");
                            break;
                    }
                    EmpSalary = WagePerHrs * EmpHrs;
                    Console.WriteLine("Employee salary is" + EmpSalary + "\n");
                
            }
            int MonthlySalary = EmpSalary * TotalWorkingDays;
            Console.WriteLine("Total monthly salary is " + MonthlySalary);
        }
    }
}
