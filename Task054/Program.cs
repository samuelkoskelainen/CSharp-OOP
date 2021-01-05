using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Task054
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader x = new FileReader(@"file path");
            searchChar y = new searchChar("ee", "search");
            Console.WriteLine("These Exceptions are inside try-catch, remove the try-catch to see the Exception.");
            Console.ReadLine();
        }
    }

    class MyFileNotExistsException : Exception
    {
        public MyFileNotExistsException(string filePath)
            : base(String.Format("File path does not have text file: {0}", filePath))
        {

        }
    }

    class MyInvalidArgumentException : Exception
    {
        public MyInvalidArgumentException(string sth)
            : base(String.Format("First parameter must be one character long: {0}", sth))
        {

        }
    }

    class FileReader
    {
        private List<string> lines;
        
        protected List<string> Lines
        {
            set
            {
                lines = value;
            }
        }

        public FileReader(string file)
        {
           try
            {
                Lines = File.ReadAllLines(file).ToList();   
            } 
            catch(FileNotFoundException)
            {
                try
                {
                    throw new MyFileNotExistsException(file);   
                } 
                catch(MyFileNotExistsException)
                {
                    Console.WriteLine("Error handled with MyFileNotExistsException");
                }
            }
            
        }

        public void Read()
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }

    class searchChar
    {
        private char theChar;
        private string theString;

        protected string TheChar
        {
            set
            {
                if (value.Length == 1)
                {
                    theChar = value.ToCharArray()[0];
                } 
                else
                {
                    try 
                    {
                        throw new MyInvalidArgumentException(value);
                    } 
                    catch(MyInvalidArgumentException)
                    {
                        Console.WriteLine("Error handled with MyInvalidArgument");
                    }
                }
            }
        }

        protected string TheString
        {
            set
            {
                theString = value;
            }
        }
        
        public searchChar(string theChar, string theString)
        {
            TheChar = theChar;
            TheString = theString;
        }
    }
}
