using System;
namespace EmployeeManagement
{
    class EmployeeManagement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Management program.\n");
            //EmployeeSalaryUC1.EmployeeAttandance();
            //EmployeeSalaryUC2.EmployeeWage();
            //EmployeeSalaryUC3.EmpSalary();
            //EmployeeSalaryUC4.EmpSalarySwitchCase();
            //EmployeeSalaryUC5.EmployeeSalary();
            //EmployeeSalaryUC6.EmpSalary();
            //EmployeeSalaryUC7.ComputeEmpWage();
            //EmployeeSalaryUC8.ComputeWage("Dmart", 20, 5, 40);
            //EmployeeSalaryUC8.ComputeWage("Reliance", 30, 10, 80);
            EmployeeSalaryUC9 Dmart = new EmployeeSalaryUC9("Dmart",20,5,40);
            EmployeeSalaryUC9 Reliance = new EmployeeSalaryUC9("Reliance", 30, 10, 80);
            Dmart.ComputeWage();
            Console.WriteLine(Dmart.toString());
            Reliance.ComputeWage();
            Console.WriteLine(Reliance.toString());
        }
    }
}
