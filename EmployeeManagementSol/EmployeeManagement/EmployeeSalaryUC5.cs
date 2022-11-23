using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeSalaryUC5
    {
        public static void EmployeeSalary()
        {
            //Constants
            int IS_FULL_TIME = 0, IS_PART_TIME = 1, WagePerHrs = 20, TotalWorkingHrs = 0, EmpSalary=0, TotalWorkingDays =20;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            for(int i=1;i<=TotalWorkingDays;i++)
            {
                switch (empCheck)
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
                EmpSalary = WagePerHrs * TotalWorkingHrs;
                Console.WriteLine("Employee salary for day " +i +" is" + EmpSalary +"\n");
            }
            int MonthlySalary = EmpSalary * TotalWorkingDays;
            Console.WriteLine("Total monthly salary is " +MonthlySalary);
        }
    }
}
