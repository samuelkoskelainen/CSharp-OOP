using System;

namespace Task011
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] greetings = { "Hello!", "Whadap!", "Yo!" };
            Random random = new Random();
            int randomNumber = random.Next(0, greetings.Length);

            Console.Write(greetings[randomNumber]);
            Console.ReadLine();
        }
    }
}
