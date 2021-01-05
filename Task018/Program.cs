using System;

namespace Task018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give adding rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give adding columns");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(rows + " * " + columns + " multiplication table");
            Console.WriteLine();
            MultiplicationTable(rows, columns);
        }

        static void MultiplicationTable(int rows, int columns)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int  j = 1; j <= columns; j++)
                {
                    if (i*j<=10)
                    {
                        Console.Write("  " + i * j + "  ");
                    }
                    else
                    {
                        Console.Write("  " + i * j + " ");  
                    }

                    if (j == columns)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}
