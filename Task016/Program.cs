using System;

namespace Task016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 to convert eur/usd, 2 to convert usd/eur");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Give euro amount:");
                decimal eur = Convert.ToDecimal(Console.ReadLine());
                EurToUsd x = new EurToUsd(Convert.ToDecimal(eur));
                x.convert();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Give usd amount:");
                decimal usd = Convert.ToDecimal(Console.ReadLine());
                UsdToEur x = new UsdToEur(Convert.ToDecimal(usd));
                x.convert();
            }
        }
    }

    class EurToUsd
    {
        public decimal euro;
        public EurToUsd(decimal eur)
        {
            euro = eur;
        }

        public void convert()
        {
            decimal converted = euro * 1.23m;
            decimal rounded = Math.Round(converted, 2);
            Console.WriteLine(euro + "e converted to dollar is $" + rounded);
        }

    }

    class UsdToEur
    {
        public decimal usd;
        public UsdToEur(decimal dollar)
        {
            usd = dollar;
        }

        public void convert()
        {
            decimal converted = usd / 1.23m;
            decimal rounded = Math.Round(converted, 2);
            Console.WriteLine("$" + usd + " converted to dollar is " + rounded + "e");
        }

    }
}
