using System;
using System.Linq;


namespace Task026
{
    class Program
    {
        static void Main(string[] args)
        {
            Craps game = new Craps();
            int [] array = game.throwDices();
            string result = game.result(array);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }


    class Craps
    {
        private string results;
        private string s;
        public Craps()
        {

        }
        public int[] throwDices()
        {
            int[] crapsArray = new int[2];
            Random number = new Random();
            for (int i = 0; i < 2; i++ )
            {
                int diceNumber = number.Next(1, 7);
                crapsArray[i] = diceNumber;
            }
            
            return crapsArray;
        }

        public string result(int [] numbers) 
        {
            int r = numbers[0] + numbers[1];
            
            if (r == 2 ||r == 3 || r == 12)
            {
                s = "craps";
            } 
            else if ( r == 7 || r == 11)
            {
                s = "natural";
            } 
            else if (r == 4 ||r == 5 || r == 6 || r == 8 || r == 9 || r == 10)
            {
                s = "point";
            }

            results = $"[{numbers[0]}, {numbers[1]}], result: {r}, {s}";

            return results;
        }
    }
}
