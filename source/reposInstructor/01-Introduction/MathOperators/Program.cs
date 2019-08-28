using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1 = 42;
            double v2 = 12;
            //Console.WriteLine( "Add: " + v1 + v2 );
            Console.WriteLine("Add: " + (v1 + v2) );
            Console.WriteLine("Subtract: " + (v1 - v2));
            Console.WriteLine("Multiply: " + (v1 * v2));
            Console.WriteLine("Divide: " + (v1 / v2));
            Console.WriteLine("Remainder: " + (v1 % v2));

            v1++;
            ++v1;
            Console.WriteLine("New v1: " + v1);
            Console.WriteLine("New v2: " + v2--);
            Console.WriteLine("New v2: " + v2);
            Console.WriteLine("New v2: " + (--v2) );

            Console.WriteLine("New v2: " + (v2--));
            Console.WriteLine("New v2: " + v2);

            double v3 = v1++;
            double v4 = ++v1;






        }
    }
}
