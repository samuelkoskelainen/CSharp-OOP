using System;
using System.Collections.Specialized;

namespace Task014
{
    class Program
    {
        public static void Main(string[] args)
        {
            NameValueCollection hash = new NameValueCollection()
            {
                { "key", "value" },
                { "----------", "----------" },
                {"Alice Blue", "#F0F8FF" },
                {"Antique White", "#FAEBD7" },
                {"Aqua", "#00FFFF" },
            };

            PrintKeysAndValues(hash);
            Console.ReadLine();
        }

        public static void PrintKeysAndValues( NameValueCollection hashArray)
        {
            foreach (String s in hashArray.AllKeys)
            {
                Console.WriteLine("{0, -10}, {1}", s, hashArray[s]);
            }
        }
    }
}
