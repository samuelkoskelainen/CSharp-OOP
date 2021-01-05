using System;

namespace Task042
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(2, 2);
            Square squ = new Square(3);
            Console.WriteLine(rec.Area());
            Console.WriteLine(squ.Area());
        }
    }

    abstract class BaseShape2D
    {
        private int height;
        private int length;

        protected int Height
        {
            get { return height; }
            set { height = value; }
        }

        protected int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Area()
        {
            return Height * Length;
        }
    }

    class Rectangle : BaseShape2D
    {
        public Rectangle(int height, int length)
        {
            Height = height;
            Length = length;
        }
    }

    class Square : BaseShape2D
    {
        public Square(int length)
        {
            Height = length;
            Length = length;
        }
    }
}
