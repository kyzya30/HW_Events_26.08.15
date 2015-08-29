using System;

namespace HW_Events
{
    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void NewBookComputerLiterature(Book book)
        {

            if (book.Genre == "ComputerLiterature")
            {
                Console.WriteLine("LIBRARY HAVE NEW ComputerLiterature");

            }

        }

        public void NewBookFantastik(Book book)
        {
            if (book.Genre == "Fantastic")
            {
                Console.WriteLine("LIBRARY HAVE NEW Fantastik");

            }

        }

        public void RemovedBookFromLibrary(Book book)
        {

            if (book.Genre != "Fantastic")
            {
                Console.WriteLine("Я не собирался идти за этой книгой");

            }
        }
    }
}
