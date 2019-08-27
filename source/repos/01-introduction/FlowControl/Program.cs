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
            bool result = false;
            int val = 2;
            result = (1 == 1);
            if (val == 1)
            {
                Console.WriteLine("val was 1");
            }
            if (result)
            {
                Console.WriteLine("result was true");
            }
            else
            {
                Console.WriteLine("result was false");
            }

            //if-else-if
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
                Console.WriteLine("value is something else.");
            }

            // 4+ conditions, use switch
            val = 1;
            switch (val)
            {
                case 0:
                case 1:
                    Console.WriteLine("value is no more than 1");
                    break;
                case 2:
                case 3:
                case 4:
                default:
                    Console.WriteLine("value is no more than 1");
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
                case "q":
                    Console.WriteLine("Goodbye");
                    
                    break;
                default:
                    break;
            }

            // repitition
            // 1- for loop
            for (int i=1; i < 100; i++)
            {

            }
            // type syntax keyword for and hit tab twice and Vstudio will put in a template
            /*for (int i = 0; i < length; i++)
            {

            }*/

            for (int loopVal = 0; loopVal < 10; loopVal++)
            {
                Console.WriteLine(0);
                // Console.WriteLine(LoopVal);
            }

            // 2- foreach loop
            /* // template is below for foreach
            foreach (var item in collection)
            {

            }*/

            int[] arrIns = new int[] { 3, 5, 7, 9, 11 };
            foreach (int item in arrIns)
            {
                //item += 9; //doesn't work because you cannot change the list of values given to foreach
                // regular for loop you can change it but not with foreach
                Console.WriteLine(item);
            }

            foreach (int x in Enumerable.Range(1,9))
            {
                Console.WriteLine(x);
            }

            // 3 - while loop
            int count = 0;
            while (count < 10)
            {
                count++;
                Console.WriteLine(count + " Apple Jacks Eaten.");
            }

            // 4 - do loop
            int sentinel = 0;
            do
            {
                sentinel++;
                Console.WriteLine(sentinel + " loops ran.");
                
            } while (sentinel < 10);

            // using break and continue
            Fruit[] groceries = { Fruit.Apple, Fruit.Orange, Fruit.Apple, Fruit.Banana, Fruit.Orange };
            int numApples = 0;
            foreach (Fruit item in groceries)
            {
                if (item == Fruit.Banana)
                {
                    Console.WriteLine("break from loop");
                    break;
                }

                if(item == Fruit.Apple)
                {
                    ++numApples;
                    Console.WriteLine("add apple");
                    if (numApples > 1)
                    {
                        // continue will exit current loop and go to next iteration of loop. 
                        // or exit function to where it was called.
                        continue;
                    }
                }
                
                if(item == Fruit.Orange)
                {
                    Console.WriteLine("do nothing");
                }
                Console.WriteLine(item);
            }
            Console.WriteLine("There are " + numApples + " apples.");
        }
    }
}
