using System;

namespace Task051
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionDivide xy = new ExceptionDivide(1, 0);
            xy.Divide();
            Console.ReadLine();
        }
    }

    class ExceptionDivide
    {
        private int x;
        private int y;

        protected int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int Y
        {
            get { return y; }
            set { y = value; }
        }
        public ExceptionDivide(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Divide()
        {
            try
            {

            if (X / Y == 0)
            {
                throw new Exception();
            } 
            else
                {
                    Console.WriteLine("{0}", X / Y);
                }
            } catch(Exception)
            {
                Console.WriteLine("Now I have to give you an error for that");
            }
        }
    }
}
