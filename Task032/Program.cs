using System;

namespace Task032
{
    class Program
    {
        static void Main(string[] args)
        {
            Student me = new Student("sam", "kos");
            me.Id = 111;
            me.Ects = 120;

            Console.WriteLine("{0}, {1}, {2}, {3}",me.FirstName, me.LastName, me.Id, me.Ects);
        }
    }

    class Person
    {
        protected string firstName;
        protected string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }


    class Student : Person
    {
        private int id;
        private int ects;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Ects
        {
            get { return ects; }
            set { ects = value; }
        }

        public Student(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
        }
    }
}
