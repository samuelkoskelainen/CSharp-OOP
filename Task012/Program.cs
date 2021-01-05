using System;

namespace Task012
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for(int i = 0; i<= rows; i++)
            {   
                for (int j = 1; j <= rows-i; j++)
                Console.Write(" ");
                for (int j = 1; j <= 2*i-1;j++)
                Console.Write(i);
                Console.Write("\n");
            }
                Console.ReadLine();
        }
    }
}
