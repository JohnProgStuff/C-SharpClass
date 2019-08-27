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
            string username = "";
            string hoursWorkedstr = "";
            int hoursWorked = 0;
            int result = 0;
            int trycount = 0;

            Console.Write("Enter your name: ");
            username = Console.ReadLine();
            Console.WriteLine("Hello " + username);

            while (result < 1)
            {
                Console.Write("How many hours did you spend in the office? ");
                hoursWorkedstr = Console.ReadLine();

                if (int.TryParse(hoursWorkedstr, out result))
                {
                    hoursWorked = int.Parse(hoursWorkedstr);
                }
                else
                {
                    // does the user want to quit
                    if ((hoursWorkedstr == "q") || (hoursWorkedstr == "quit"))
                    {
                        break;
                    }
                    // if they don't want to quit then they must be dumb
                    trycount++;
                    if (trycount < 5)
                    {
                        Console.WriteLine("Enter a valid number");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("you failed to enter a valid number " + username + ". are you dumb? exiting program");
                        break;
                    }
                }
                

            }
            switch(hoursWorked)
            {
                case 0:
                    if (hoursWorkedstr == "q" || hoursWorkedstr == "quit")
                    {
                        Console.WriteLine("Goodbye");
                    }
                    else {
                        Console.WriteLine("Get to work you lasy possum");
                    }
                    break;
                default:
                    if (hoursWorked > 8)
                    {
                        Console.WriteLine("have a break");
                    }
                    else
                    {
                        Console.WriteLine("you are fine");
                    }
                    break;
            }

        }
    }
}
