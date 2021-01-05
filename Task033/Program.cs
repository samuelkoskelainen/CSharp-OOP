using System;

namespace Taask033
{
    class Program
    {
        static void Main(string[] args)
        {
            King wK = new King("e1", "White");
            Queen wQ = new Queen("d1", "White");
            wK.PieceDetail();
            wQ.PieceDetail();

            Console.ReadLine();
        }
    }

    class ChessPiece
    {
        protected string coordinate;
        protected string color;
        protected string type;

        public void PieceDetail()
        {
            Console.WriteLine(color);
            Console.WriteLine(type);
            Console.WriteLine(coordinate);
            Console.WriteLine();
        }
    }

    class King : ChessPiece
    {
        public King(string _coordinate, string _color)
        {
            coordinate = _coordinate;
            color = _color;
            type = "King";
        }
    }

    class Queen : ChessPiece
    {
        public Queen(string _coordinate, string _color)
        {
            coordinate = _coordinate;
            color = _color;
            type = "Queen";
        }
    }
}
