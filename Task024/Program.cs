using System;

namespace Task024
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomize x = new Randomize();
            x.SetLow = 1;
            x.SetHigh = 6;
            x.value();
        }
    }

    class Randomize
    {
        private int _low;
        public int SetLow
        {
            get => _low;
            set => _low = value;
        }

        private int _high;
        public int SetHigh
        {
            get => _high;
            set => _high = value;
        }

        public void value ()
        {
            Random number = new Random();
            for (int i = 0; i < 100; i++)
            {
                int x = number.Next(_low, _high + 1);
                Console.WriteLine(x);
            }
        }
        

    }
}
