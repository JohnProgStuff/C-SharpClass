using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello " + "World!");
            Console.WriteLine("Welcome Back!");
            int feet = 30;
            Console.WriteLine(FeetToInches(feet));
            Console.WriteLine("after fun call, feet = " + feet);

        }

        // this is a function to convert feet to inches
        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }

    }
}
