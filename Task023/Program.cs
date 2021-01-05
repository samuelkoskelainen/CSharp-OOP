using System;

namespace Task023
{
    class Program
    {
        static void Main(string[] args)
        {
            Rand number = new Rand();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(number.value(1, 6));
            }
        }
    }

    class Rand
    {
        public int value(int x, int y)
        {
            Random value = new Random();
            int z= value.Next(x, y + 1);

            return z;
        }
    }
}
