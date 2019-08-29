using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // non-generic version of collection
            Stack myStack = new Stack();
            myStack.Push("a string");
            myStack.Push(123);
            myStack.Push(3.3);
            myStack.Push(myStack);
            Console.WriteLine(myStack);

            //Console.WriteLine(myStack.Pop().GetType());
            //double aDobule = (double)myStack.Pop();

            //Console.WriteLine(myStack.Pop().GetType());
            //Console.WriteLine(myStack.Pop().GetType());
            //Console.WriteLine(myStack.Pop().GetType());

            // generic version of collections
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("a string");
            //stringStack.Push(123);
            string myStr = stringStack.Pop();

            var intStack = new Stack<int>();
            intStack.Push(123);
            //intStack.Push("a string");
            short aShort = 10;
            intStack.Push(aShort);
            long aLong = 100L;
            intStack.Push((int)aLong);

            GenericList<int> intList = new GenericList<int>();
            intList.AddHead(1);
            intList.AddHead(2);
            intList.AddHead(3);
            Console.WriteLine(intList);

            GenericList<string> strList = new GenericList<string>();
            strList.AddHead("Added First, Displayed Last!");
            strList.AddHead("Added Second, Displayed Second!");
            strList.AddHead("Added Last, Displayed First!");
            Console.WriteLine(strList);

            var doubleList = new GenericList<double>();
            doubleList.AddHead(1.1);
            doubleList.AddHead(2.2);
            doubleList.AddHead(3.3);
            Console.WriteLine(doubleList);

            foreach (var item in doubleList)
            {
                Console.WriteLine(item + " - ");
            }

            // value types:
            int intVal = 10;

            // reference types:
            object intValAsRefType = intVal;  // boxing
            int anotherVal = (int)intValAsRefType; // unboxing

            // type-safety
            //foreach (int item in myStack)
            //{
            //    Console.WriteLine(item);
            //}// end of foreach loop

            int x = 5;
            int y = 10;
            Swap(ref x, ref y);
            Console.WriteLine("x = " + x + ", y = " + y);
            double d1 = 2.2;
            double d2 = 5.5;
            Swap(ref d1, ref d2);
            Console.WriteLine("d1 = " + d1 + ", d2 = " + d2);
            string s1 = "first";
            string s2 = "second";
            Swap(ref s1, ref s2);
            Console.WriteLine("s1 = " + s1 + ", s2 = " + s2);

            GenericList<int> anotherList = new GenericList<int>();
            anotherList.AddHead(111);
            anotherList.AddHead(222);
            anotherList.AddHead(333);
            Swap(ref intList, ref anotherList);
            Console.WriteLine(intList);
            Console.WriteLine(anotherList);


        }// end of Main()

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


    }// end of Program class
}// end of the ... namespace
