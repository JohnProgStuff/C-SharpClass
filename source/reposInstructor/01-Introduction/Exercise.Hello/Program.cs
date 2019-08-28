using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[0];
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("How much hours did you spend in your office yesterday?");
            string hourStr = Console.ReadLine();
            int workingHours = Int32.Parse(hourStr);

            if (workingHours < 8)
            {
                Console.WriteLine("You are fine!");
            }
            else
            {
                Console.WriteLine("You should have a break!");

            }

        }
    }
}
