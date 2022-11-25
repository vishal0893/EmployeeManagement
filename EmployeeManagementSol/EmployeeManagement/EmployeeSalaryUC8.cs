using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{   
    class EmployeeSalaryUC8
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int ComputeWage(string Company,int EmpRatePerHour,int NumOfWorkingDays, int MaxHrsPerMonth)
        {
            //Varirables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while(totalEmpHrs<=MaxHrsPerMonth &&totalWorkingDays<=NumOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default: 
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs " + empHrs);
            }
            int totalEmpWage = totalEmpHrs*EmpRatePerHour;
            Console.WriteLine("total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
