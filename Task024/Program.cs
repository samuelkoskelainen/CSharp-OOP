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

            Console.WriteLine();

            Randomize y = new Randomize(1, 6);
            y.value();
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

        public Randomize()
        {

        }

        public Randomize(int low, int high)
        {
            _low = low;
            _high = high;
        }

        public void value()
        {
            Random number = new Random();
            for (int i = 0; i < 20; i++)
            {
                int x = number.Next(_low, _high + 1);
                Console.WriteLine(x);
            }
        }


    }
}
