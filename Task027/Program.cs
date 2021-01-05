using System;

namespace Task027
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookEntry x = new PhoneBookEntry();
            x.SetFirstName = "Sa";
            x.SetLastName = "Kos";
            x.SetNumber = "1234567";
            x.SetStreetAddress = "123 Main Street";
            x.SetPageUrl = "www.sivu.fi";
            x.SetEmailAddress = "email@email.com";
            x.display();

            Console.ReadLine();
        }
    }

    class PhoneBookEntry
    {
        private string firstName;
        private string lastName;
        private string number;
        private string streetAddress;
        private string pageUrl;
        private string emailAddres;

        public string SetFirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string SetLastName
        {
            get { return lastName; }
            set { lastName = value; }
        } 

        public string SetNumber
        {
            get { return number; }
            set { number = value; }
        }

        public string SetStreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public string SetPageUrl
        {
            get { return pageUrl; }
            set { pageUrl = value; }
        }

        public string SetEmailAddress
        {
            get { return emailAddres; }
            set { emailAddres = value; }
        }
        public PhoneBookEntry()
        {

        }

        public void display()
        {
            Console.WriteLine("firstname: " + firstName);
            Console.WriteLine("lastname: " + lastName);
            Console.WriteLine("number: " + number);
            Console.WriteLine("street address: " + streetAddress);
            Console.WriteLine("page URL: " + pageUrl);
            Console.WriteLine("email address: " + emailAddres);
        }
    }
}
