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
            Console.WriteLine("Bigger value is " + Max(12, 15));
            Console.WriteLine(Concatenate("First ", "Last"));

            double d1 = 42.0;
            double d2 = 21.0;
            Console.WriteLine("Add: " + (d1 + d2) );

            int aInt = 5;
            aInt++;
            ++aInt;

            //Console.WriteLine("new aInt = " + (aInt++) );

            Console.WriteLine("new aInt = " + aInt);
            aInt++;

            //Console.WriteLine("new aInt = " + (++aInt) );

            aInt++;
            Console.WriteLine("new aInt = " + aInt);







        }

        static int Max(int first, int second)
        {
            if(first < second)
            {
                return second;
            }
            else
            {
                return first;
            }
            
        }

        static string Concatenate(string str1, string str2)
        {
            string whole = str1 + str2;
            return whole;
        }

    }
}
