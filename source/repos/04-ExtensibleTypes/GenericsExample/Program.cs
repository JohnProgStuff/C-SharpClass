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
            // non-generic version of a collection
            Stack myStack = new Stack();
            myStack.Push("a string");
            myStack.Push(123);
            myStack.Push(3.3);
            //myStack.Push(myStack);
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Peek().GetType());
            double aDouble = (double)myStack.Pop(); //unboxing
            Console.WriteLine(aDouble + " unboxed");
            Console.WriteLine(myStack.Peek().GetType());
            //double aInt = (double)myStack.Pop(); //since the current item is an int. it will give a invalidCastException
            Console.WriteLine(myStack.Peek().GetType());

            // generic version of a collection
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Apples");
            stringStack.Push("Grapes");
            //stringStack.Push(123); //compiler won't let you add different types (C#&Java are strongly typed)
            string myStr = stringStack.Pop(); // pop grapes
            Console.WriteLine(stringStack.Pop());

            var intStack = new Stack<int>();
            intStack.Push(123);
            //intStack.Push(3.3); // can't put double in intstack
            Console.WriteLine(intStack.Pop());
            short aShort = 10;
            intStack.Push(aShort); //implicit conversion from short to int happens
            long aLong = 10505050505050L;
            //intStack.Push(aLong); //implicit conversion doesn't work from long to int
            intStack.Push((int)aLong); // this works because you convert it first, but the
                                       // value might change when you cast long to int
            Console.WriteLine(intStack.Pop());


            GenericList<string> strList = new GenericList<string>();
            strList.AddHead("Apples");
            strList.AddHead("Grapes");
            strList.AddHead("Peaches");
            strList.AddHead("Pears");
            Console.WriteLine(strList);
            strList.AddFoot("Nectarines");
            strList.AddFoot("Raspberries");
            Console.WriteLine(strList);


            GenericList<int> intList = new GenericList<int>();
            intList.AddHead(5);
            intList.AddHead(2);
            intList.AddHead(9);
            intList.AddHead(4);
            Console.WriteLine(intList);
            intList.AddFoot(1);
            intList.AddFoot(8);
            Console.WriteLine(intList);

            var doubleList = new GenericList<double>();
            doubleList.AddHead(5.5);
            doubleList.AddHead(2.2);
            doubleList.AddHead(9.9);
            doubleList.AddHead(4.4);
            Console.WriteLine(doubleList);
            doubleList.AddFoot(1.8);
            doubleList.AddFoot(8.85);
            Console.WriteLine(doubleList);

            foreach (var item in strList)
            {
                Console.WriteLine(item + " -");
            }
            foreach (var item in intList)
            {
                Console.WriteLine(item + " -");
            }
            foreach (var item in doubleList)
            {
                Console.WriteLine(item + " -");
            }


            // value types:
            int intVal = 10;

            // reference types:
            object IntValAsRefType = intVal; //boxing

            int anotherVal = (int)IntValAsRefType;
            // you can only convert if you know what the type is otherwise it could act weird.
            Console.WriteLine(anotherVal);

            //All the collections store references to objects not the full objects themselves
            // so the stuff in nongeneric myStack above is being boxed as on object reference with each Push
            // this causes extra time.

            // Type-safety
            /*foreach (var item in myStack)
            {
                Console.WriteLine(item);
            } */

            int x = 5;
            int y = 10;
            Swap(ref x, ref y);
            Console.WriteLine("x=" + x + ", y=" + y);
            double d1 = 2.2;
            double d2 = 5.5;
            Swap(ref d1, ref d2);
            Console.WriteLine("d1=" + d1 + ", d2=" + d2);
            string s1 = "first";
            string s2 = "second";
            Swap(ref s1,ref s2);
            Console.WriteLine("s1=" + s1 + ", s2=" + s2);
            String st1 = "aaa";
            String st2 = "zzz";
            Swap(ref st1, ref st2);
            Console.WriteLine("st1=" + st1 + ", st2=" + st2);
            var anotherList = new GenericList<int>();
            anotherList.AddFoot(20);
            anotherList.AddHead(50);
            Console.WriteLine(intList);
            Console.WriteLine(anotherList);
            Swap(ref intList, ref anotherList); // types must be the same
            Console.WriteLine("s1=" + d1 + ", s2=" + d2);
        } // endof main

        // use ref below to force objects to be passed by reference
        static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            // a = b+a; // swap without a temp variable, won't work on some datatypes
            // b = a-b;
            // a = a-b;
        }// end of swap function

    } // end of Program class
} // end of the .... namespace
