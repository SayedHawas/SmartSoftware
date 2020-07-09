using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutMainMethodDemo
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Sayed",
                LastName = "Hawas"
            };
            person.LastName = "Osama";

            DisplayInfo(person);
            ReadLine();

        } 
         
        
        static void DisplayInfo(Person p)
        {
            Console.WriteLine($"Your Name is : {p.FirstName } {p.LastName}");
        }

    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string LastName { get; init }
    }
}
