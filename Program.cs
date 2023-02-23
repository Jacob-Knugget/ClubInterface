using System;
namespace club
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
    }
    class Program
    {
        struct Security : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Height { get; set; }
            public int Age { get; set; }
            public double Pay { get; set; }
            public Security(int id, string firstName, string lastName, double height, int age, double pay)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Height = height;
                Age = age;
                Pay = pay;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public string Display()
            {
                return "ID: " + Id + "\nName: " + Fullname() + "\nHeight: " + Height + "\nAge: " + Age +"\nHourly Pay: " + Pay;
            }
        }
        static void Main(string[] args)
        {
            Security first = new Security(2, "Joe", "Large", 6.3, 44, 28);
            Console.WriteLine($"{first.Display()}");
        }
    }
}