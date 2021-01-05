using System;

namespace Task013
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] winning = { 1, 2, 3, 4, 5, 6, 7 };
            int[] spare = { 8, 9, 10 };
            Console.WriteLine("FINNISH LOTTERY");
            Console.Write("Winning numbers: ");
            for (int i = 0; i <= winning.Length-1; i++)
            {
                Console.Write(winning[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write("Spare numbers: ");
            for (int i = 0; i <= spare.Length-1; i++)
            {
                Console.Write(spare[i]);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
