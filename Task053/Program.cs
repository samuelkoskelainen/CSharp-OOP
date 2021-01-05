using System;
using System.Linq;

namespace Task053
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailCheck x = new EmailCheck("test@test.com");
            EmailCheck y = new EmailCheck("test@test.c");
            EmailCheck z = new EmailCheck("test");
            Console.ReadLine();
            
        }
    }

    class EmailCheck
    {
        private string email;
        private int atIndex;
        private char[] emailArray;

        public string Email
        {
            get { return email; }
            set
            {
                try
                {
                    emailArray = value.ToCharArray();
                    if (emailArray.Contains('@'))
                    {
                        atIndex = Array.IndexOf(emailArray, '.');
                        if (emailArray.Length - atIndex == 3 || emailArray.Length - atIndex == 4 || emailArray.Length - atIndex == 5)
                        {
                            Console.WriteLine("Email set succesfully: {0}", value);
                            email = value;
                        } 
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                } catch (Exception)
                {
                    Console.WriteLine("Email not correct: {0}", value);
                }
            }
        }
        public EmailCheck(string email)
        {
            Email = email;
        }
    }
}
