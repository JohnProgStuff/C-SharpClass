using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingVariables
{
    class Program
    {
        enum Flavors { Chocolate, Vanilla, Straberry };

        static void Main(string[] args)
        {
            int age = 10;
            int personAge = 20;
            const int NUM_MONTHS = 12;

            age = 25;
            //NUM_MONTHS = 15;

            Console.WriteLine("My favorite flavor is: " + Flavors.Chocolate);

            // date time object
            DateTime dt = new DateTime(2015, 1, 1);
            Console.WriteLine("The date is: " + dt);
            // output date using a format
            Console.WriteLine("The date is: " + dt.ToString("MMMM d, yyyy"));
            Console.WriteLine("The date is: " + dt.ToString("M/d/yyyy"));

            // do simple math with date time objects
            DateTime anotherDay = dt.AddDays(-1);
            Console.WriteLine("Another day is: " 
                + anotherDay.ToString("MMMM d, yyyy"));

            DateTime now = DateTime.Now;
            Console.WriteLine("Current date time is: "
                + now.ToString("MMMM, d, yyyy"));

        } // end of main

        struct person
        {
            int age;
            struct name
            {
                string firstName;
                string lastName;
            }
        }

    }
}
