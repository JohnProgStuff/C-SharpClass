using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repitition
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }

            // foreach loop
            int[] arrInts = new int[] { 3, 5, 6, 20, 25, 33, 46 };
            foreach (int item in arrInts)
            {
                Console.WriteLine(item);
            }

            // while loop
            int sentinel = 0;
            while (sentinel < 10)
            {
                Console.WriteLine(sentinel);
                sentinel++;
            }

            // do loop
            sentinel = 10;
            do
            {
                Console.WriteLine(sentinel);
                sentinel++;
            } while (sentinel < 10);






        }
    }
}
