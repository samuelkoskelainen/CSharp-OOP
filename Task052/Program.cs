using System;

namespace Task052
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionRange b = new ExceptionRange(1, 10);
            ExceptionRange a = new ExceptionRange(-1, 9);

        }
    }

    class ExceptionRange
    {
        private int beg;
        private int end;

        protected int Beg
        {
            get { return beg; }
            set
            {
                if(value < 0 || value > 10)
                {
                    throw new Exception("Beginning not in range 0 < x <= 10");
                }
                else
                {
                    Console.WriteLine("Beginning in range {0}", value);
                    beg = value;
                }
            }
        }

        protected int End
        {
            get { return end; }
            set
            {
                if (value < 10 || value > 20)
                {
                    throw new Exception("End not in range 10 < x <= 20");
                }
                else
                {
                    Console.WriteLine("End in range {0}", value);
                    end = value;
                }
            }
        }
        public ExceptionRange(int beg, int end)
        {
            Beg = beg;
            End = end;
        }
    }
}
