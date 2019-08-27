using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bigger value is: " + Max(15, 23));
            Console.WriteLine("Concatenate .... " + Concatenate("hello", "John"));

            double d1 = 42.0;
            double d2 = 21.0;

            Console.WriteLine("Add: " + (d1 + d2));


        }
        
        static int Max(int first, int second)
        {
            if (first < second)
            {
                return second;
            }
            return first;
        }

        // instead of implementing lots of different functions to handle Maximum of lots of types we use a generic function instead

        static string Concatenate(string str1, string str2)
        {
            if (str1.Substring(str1.Length-1) == " "){
                Console.WriteLine("good");
                return str1 + str2;
            }
            Console.WriteLine("adding space");
            return str1 + " " + str2;
        }
    

    }
}
