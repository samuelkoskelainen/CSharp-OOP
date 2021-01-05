using System;

namespace Task036
{
    class Program
    {
        static void Main(string[] args)
        {
            SlotMachine fruits = new SlotMachine();
            fruits.Play();
            fruits.Result();

            Console.ReadLine();
        }
    }

    class FruitsGame
    {
        private string[] fruits = { "Pineapple", "Cherry", "Banana" };
        
        protected string[] Fruits
        {
            get { return fruits; }
        }
    }

    class SlotMachine : FruitsGame
    {
        private string[] slots = new string[3];
        
        public void Play()
        {
            for (int i = 0; i < slots.Length; i++)
            {
                Random fruit = new Random();
                slots[i] = Fruits[fruit.Next(0, Fruits.Length)];
            }
        }

        public void Result()
        {
            Console.Write("{0} | {1} | {2}", slots[0], slots[1], slots[2]);
            Console.WriteLine();
        }

    }
}
