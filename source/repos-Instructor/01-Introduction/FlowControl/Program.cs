using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        enum Fruit { Apple, Banana, Orange };

        static void Main(string[] args)
        {
            // if-else statements
            bool result;
            int val = 2;
            result = (1 == 2);
            if (result)
            {
                Console.WriteLine("result was true");
            }
            else
            {
                Console.WriteLine("result was false");
            }

            // if-else-if
            val = 2;
            if (val == 0)
            {
                Console.WriteLine("value is 0");
            }
            else if (val == 1)
            {
                Console.WriteLine("value is 1");
            }
            else
            {
                Console.WriteLine("value is something else");
            }

            // 4+ conditions, use switch
            val = 0;
            switch (val)
            {
                case 0:
                case 1:
                    Console.WriteLine("value is 0 or 1");
                    break;
                case 2:
                    Console.WriteLine("value is 2");
                    break;
                case 3:
                case 4:
                default:
                    break;
            }

            char aChar = 'a';
            switch (aChar)
            {
                case 'a':
                    Console.WriteLine("the char is a");
                    break;
                case 'b':
                    Console.WriteLine("the char is b");
                    break;
                default:
                    Console.WriteLine("the char is something else");
                    break;
            }

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "hello":
                    Console.WriteLine("Hello");
                    break;
                case "goodbye":
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    break;

            }

            // repitition
            // 1- for loop
            for (int loopVal = 0; loopVal < 11; loopVal++)
            {
                Console.WriteLine(0);
            }


            // 2 - foreach loop
            int[] arrIns = new int[] { 3, 5, 7, 9, 11 };
            foreach (int item in arrIns)
            {
                //item += 9;
                Console.WriteLine(item);
            }

            foreach(int x in Enumerable.Range(1, 9))
            {
                
            }

            // 3 - while loop
            int sentinel = 0;
            while (sentinel < 10)
            {
                Console.WriteLine(sentinel);
                sentinel++;
            }

            // 4 - do loop
            sentinel = 10;
            do
            {
                Console.WriteLine("Sentinel = " + sentinel);
                sentinel++;
            } while (sentinel < 10);

            // using break and continue
            Fruit[] groceries = { Fruit.Apple, Fruit.Apple, Fruit.Banana};
            int numApples = 0;
            foreach (var item in groceries)
            {
                if(item == Fruit.Banana)
                {
                    break;
                }

                if(item == Fruit.Apple)
                {
                    ++numApples;
                    if(numApples > 1)
                    {
                        continue;
                    }
                }
                Console.WriteLine(item);

            }
            Console.WriteLine("There are " + numApples + " apples.");

        }
    }
}
