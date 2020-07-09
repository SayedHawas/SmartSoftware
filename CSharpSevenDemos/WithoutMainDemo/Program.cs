 using static System.Console;
   
            var person = new Person
            {
                FirstName = "Sayed",
                LastName = "Hawas"
            };
            DisplayInfo(person);
            ReadLine();




        static void DisplayInfo(Person p)
        {
            WriteLine($"Your Name is : {p.FirstName } {p.LastName}");
        }


    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

