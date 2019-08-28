using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement
            bool result = false;
            if (1 == 1)
            {
                Console.WriteLine("Result was true");
            }
            else
            {
                Console.WriteLine("Result was false");
            }

            // if... else if
            int value = 2;
            if( value == 0 )
            {
                Console.WriteLine("Value = 0");
            }
            else if (value == 1)
            {
                Console.WriteLine("Value = 1");
            }
            else
            {
                Console.WriteLine("Value = something else");
            }

            string input = Console.ReadLine();
            if (input.Equals("hello"))
            {
                Console.WriteLine("You said hello.");
            }
            else if (input.Equals("goodbye"))
            {
                Console.WriteLine("You said goodbye.");
            }
            else
            {
                Console.WriteLine("You said something else.");
            }

            if (value == 0)
            {


            }
            if (value == 1)
            {

            }




        }
    }
}
