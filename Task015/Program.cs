using System;

namespace Task015
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sal = 0;
            decimal tax = 0;
            bool salaryIsNumber = false;
            do
            {
                int intResult;
                decimal decResult;
                try
                {
                    Console.WriteLine("Enter your salary:");
                    var salary = Console.ReadLine();
                    if (int.TryParse(salary, out intResult) || Decimal.TryParse(salary, out decResult))
                    {
                        salaryIsNumber = true;
                        sal = Convert.ToDecimal(salary);
                    }
                    else
                    {
                        throw new Exception();
                    }
                } catch (Exception)
                {
                    Console.WriteLine("Salary must be a number!");
                }
            } while (salaryIsNumber == false);


            bool taxRateisNumber = false;
            do
            {
                int intResult;
                decimal decResult;
                try
                {
                    Console.WriteLine("Enter your tax rate(%): ");
                    var taxRate = Console.ReadLine();
                    if (int.TryParse(taxRate, out intResult) || Decimal.TryParse(taxRate, out decResult))
                    {
                        taxRateisNumber = true;
                        tax = Convert.ToDecimal(taxRate)/100;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Tax rate must be a number!");
                }
            } while (taxRateisNumber == false);
            decimal[] summary = netSalaryAndTaxCalculator(sal, tax);
            Console.WriteLine("Net Salary: " + summary[0]);
            Console.WriteLine("Taxes: " + summary[1]);
        }
        public static decimal[] netSalaryAndTaxCalculator(decimal salary, decimal taxRate)
        {
            decimal[] netSalAndTax = { 1,1 };
            netSalAndTax[0] = salary * (1 - taxRate);
            netSalAndTax[1] = salary * taxRate;
            return netSalAndTax;
        }
    }
}
