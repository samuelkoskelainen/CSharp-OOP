using System;

namespace Task017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give string, I will tell you if it's a palindrome." );
            string input = Console.ReadLine();

            PalindromeCheck x = new PalindromeCheck(input);
            x.check();
        }
    }

    class PalindromeCheck
    {
        public string input;

        public PalindromeCheck(string userInput)
        {
            input = userInput;
        }

        public void check()
        {
            char[] characters = input.ToCharArray();
            Array.Reverse(characters);
            string reversedInput = new string(characters);
            bool isPalindrome = input.Equals(reversedInput, StringComparison.OrdinalIgnoreCase);
            if (isPalindrome == true)
            {
                Console.WriteLine(input + " is a palindrome.");
            } 
            else if (isPalindrome == false)
            {
                Console.WriteLine(input + " is not a palindrome.");
            }
        }
    }
}
