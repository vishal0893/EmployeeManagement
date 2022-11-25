using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeSalaryUC7
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 100;
        public static int ComputeEmpWage()
        {
            //Variables
            int empHrs = 0, TotalempHrs = 0, TotalWorkingDays = 0;
            //Computation
            while(empHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays<=NM_OF_WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();   
                int empCheck=random.Next(0,3);
                switch(empCheck)
                {
                    case IS_PART_TIME:
                        empHrs=4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs=0;
                        break;
                }
                TotalempHrs+=empHrs;
                Console.WriteLine("Day#:" +TotalWorkingDays +"Emp Hrs " +empHrs);

            }
            int TotalEmpWage = TotalempHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total Emp Wage : " + TotalEmpWage);
            return TotalEmpWage;
        }
    }
}
