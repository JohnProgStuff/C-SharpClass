using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            String input = Console.ReadLine();
            Console.WriteLine("You input: " + input);

            Console.WriteLine("Hi" +
                " multiline" +
                " text in editor.");
            int feet = 30;
            Console.WriteLine("FeetToInches: " + FeetToInches(feet) + " inches");
            Console.WriteLine("after func call, feet = " + feet);




            var johnsTuple = ("hello", 25);
            var yourTuple = ("john", 24);
            
            
            int i = 2 * 3;
            Console.WriteLine("2*3=" + i);
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey(); // to keep Console on screen
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
        
        /*int operator*()
        {
            
        }*/


    }
}
