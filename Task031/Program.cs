using System;

namespace Task031
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D coordinate = new Point3D();
            coordinate.X = 3;
            coordinate.Y = 2;
            coordinate.Z = 1;


            Console.WriteLine("( " + coordinate.X + ", " + coordinate.Y +  ", " + coordinate.Z+ " )");
        }
    }


    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {

        }
    }

    class Point3D : Point
    {
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }
    }
}
