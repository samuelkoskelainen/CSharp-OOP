using System;
using System.Linq;

namespace Task025
{
    class Program
    {
        static void Main(string[] args)
        {
            Lottery x = new Lottery(1, 40);
            x.reset();
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("[{0}]", string.Join(", ", x.play(i)));
            }
            Console.ReadLine();
        }
    }

    class Lottery
    {
        private int begin;
        private int end;
        private int[] numbers = new int[7];

        public Lottery(int _begin, int _end)
        {
            begin = _begin;
            end = _end;
        }

        public void reset()
        {
            string[] numberstr = new string[7];
            Array.Clear(numbers, 0, numbers.Length);
            Random number = new Random();
            numbers = Enumerable.Range(begin, end + 1).OrderBy(x => number.Next(begin, end + 1)).Take(7).ToArray();
        }

        public int[] play(int amount)
        {
            int[] result = new int[amount];
            for (int i = 0; i < amount; i ++)
            {
                result[i] = numbers[i];
            }
            return result;
        }
    }
}
