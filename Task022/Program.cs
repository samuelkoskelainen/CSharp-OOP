using System;

namespace Task022
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice x = new Dice();

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(x.diceRoll());
            }
        }
    }


    class Dice
    {
        public int diceRoll()
        {
            Random dice = new Random();
            int diceRoll = dice.Next(1, 7);
            return diceRoll;
        }
    }
}
