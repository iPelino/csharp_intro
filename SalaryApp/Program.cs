using System;

namespace SalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new SalaryCalculator(1, "James", "Secretary");
            Console.WriteLine(SalaryCalculator.CalculateSalary(500000));
            Console.WriteLine(employee1.Test());
        }
    }
}