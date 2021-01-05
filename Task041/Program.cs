using System;

namespace Task041
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportingScreen report = new ReportingScreen();
            report.PrintError("This is a error message.");
            report.PrintWarning("This is a warning message.");
            report.PrintNote("This is a note message.");
        }
    }
    interface IReporting
    {
        void PrintError(string errorMessage);
        void PrintWarning(string warningMessage);
        void PrintNote(string noteMessage);
    }

    class ReportingScreen : IReporting
    {
        public void PrintError(string errorMessage)
        {
            Console.WriteLine("ERROR: {0}", errorMessage);
        }

        public void PrintWarning(string warningMessage)
        {
            Console.WriteLine("WARNING: {0}", warningMessage);
        }

        public void PrintNote(string noteMessage)
        {
            Console.WriteLine("NOTE: {0}", noteMessage);
        }
    }
}
