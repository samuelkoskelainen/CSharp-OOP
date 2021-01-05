using System;

namespace Task034
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier carrier = new Carrier(1, 2, "H.M.S Tiger");
            carrier.Print();
            Destroyer destroyer = new Destroyer(3, 4, "J.J.J JOO");
            destroyer.Print();  
        }
    }

    class Coordinate
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
    }

    class Ship : Coordinate
    {
        private string type;
        private string name;

        protected string Type
        {
            get { return type; }
            set { type = value; }
        }

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Carrier : Ship
    {
        public Carrier(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
            Type = "Carrier";
        }

        public void Print()
        {
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Type);
            Console.WriteLine(Name);
            Console.WriteLine();
        }
    }

    class Destroyer : Ship
    {
        public Destroyer(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
            Type = "Destroyer";
        }

        public void Print()
        {
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Type);
            Console.WriteLine(Name);
            Console.WriteLine();
        }
    }
}
