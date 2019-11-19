using System;

namespace SalaryApp
{
    public class SalaryCalculator
    {
        private int empid;
        private string name;
        private string position;

        public SalaryCalculator(int empid, string name, string position)
        {
            this.empid = empid;
            this.name = name;
            this.position = position;
        }

        public string Test()
        {
            return "Employee Name: "+ this.name;
        }
        
        
        

        public static double CalculateSalary(double gs)
        {
            var salary= gs-(gs*0.3)-(gs*0.05)-(gs*0.03);
            return salary;
        }
    }
}