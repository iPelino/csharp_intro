namespace SalaryApp
{
    public class SalaryCalculator
    {
        public static double CalculateSalary(double gs)
        {
            var salary= gs-(gs*0.3)-(gs*0.05)-(gs*0.03);
            return salary;
        }
    }
}