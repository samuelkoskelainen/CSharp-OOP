using System;

namespace Task034
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(1, 2);
            ship.Type = "destroyer";
            ship.Name = "H.M.S Tiger";
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

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }    
        }

        public Ship(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
