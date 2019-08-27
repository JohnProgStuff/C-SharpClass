using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingVariables
{
    class Program
    {
        // member variable
        enum Flavors { Chocolate, Vanilla, Strawberry};
        enum hairColors { blond, brown, black, red, white, gray, other}
        static void Main(string[] args)
        {
            // all local variables
            int age = 10;
            int personAge = 20;
            int total = age + personAge;
            const int NUM_MONTHS = 12;

            Console.WriteLine(Flavors.Chocolate);
            // date time object
            DateTime dt = new DateTime(2019, 8, 26);
            Console.WriteLine("The date is: " + dt);
            Console.WriteLine("The date is: " + dt.ToString("MM d, yyyy"));
            Console.WriteLine("The date is: " + dt.ToString("MM/d/yyyy"));
            
            Console.WriteLine("The date is: " + dt.AddDays(-20).ToString("MM/dd/yy"));

            DateTime anotherDay = dt.AddDays(-1);
            Console.WriteLine("AnotherDay is: " +
                anotherDay.ToString("MMM d, yyyy"));
            Console.WriteLine("AnotherDay is: " +
                anotherDay.ToString("MMMM d, yyyy"));

            DateTime anotherDay1 = new DateTime();
            Console.WriteLine("The date is: " + anotherDay1);

            
        }

        struct Person
        {
            int age;
            struct Name
            {
                string firstName;
                string lastName;
            }
            hairColors hairColor;

        }
    }
}
