using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingVariables
{
    class Program
    {
        // memeber variable
        enum Flavors { Chocolate, Vanilla, Strawberry};

        static void Main(string[] args)
        {
            // all local variables need to be initialized
            int age;
            int personAge = 20;
            const int NUM_MONTHS = 12;

            Console.WriteLine("My favorite flavor is: " + Flavors.Chocolate);

            // date time object
            DateTime dt = new DateTime(2015, 1, 1);
            Console.WriteLine("The date is " + dt);
            Console.WriteLine("The date is " + dt.ToString("MM d, yyyy"));
            Console.WriteLine("The date is " + dt.ToString("MM/d/yyyy"));

            DateTime anotherDay = dt.AddDays(-1);
            Console.WriteLine("Another Day is: " +
                anotherDay.ToString("MMMM d, yyyy"));

            DateTime now = DateTime.Now;
            Console.WriteLine("Current Day is: " +
                now.ToString("MMMM d, yyyy"));

            age = 25;
            int total = age + personAge;
        }

        struct Person
        {
            int age;
            struct Name
            {
                string firstName;
                string lastName;
            }
        }
    }
}
