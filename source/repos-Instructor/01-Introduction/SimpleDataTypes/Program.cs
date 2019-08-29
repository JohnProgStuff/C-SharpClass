using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // local variables
            sbyte aSignedByte = 127;
            byte aByte = 255;
            ushort aUnsignedShort = 65535;
            decimal aDemical = 105.2903040020030303958963M;
            float aFloat = 203.2345F;
            double aDouble = 394.22332;

            // single quotation marks
            char aChar = 'A';
            string aString = "A string of characters";
            string anotherString = "a";

            Console.WriteLine("aByte value is {0}, {1}, {2}, {3}"
                , aByte
                , typeof(byte)
                , sizeof(byte), 
                byte.MaxValue);

            // int operator+(int aVal)
            // int c = a.operator+(b)
            // int c = a + b;

            // string examples
            char[] helloArray = { 'h', 'e', 'l', 'l', 'o' };
            string hello = new string(helloArray);
            string helloUpper = hello.ToUpper();
            string helloSub = hello.Substring(3, 2);
            Console.WriteLine(hello);
            Console.WriteLine(helloUpper);
            Console.WriteLine(helloSub);

            // the string is an immutable object
            hello += " world";
            Console.WriteLine(hello);
            StringBuilder builder = new StringBuilder();
            builder.Append("Hello");
            builder.Append(" Welcome ");
            builder.Append("World");
            string anotherStr = builder.ToString();

            // chained method call
            builder.Append("Hello ").Append("My Name is ").Append("Yong");

            // parse strings to numbers
            string aNumStr = "01234";
            int aNumFromAStr = Int32.Parse(aNumStr);
            Console.WriteLine(aNumFromAStr);

            string aDoubleStr = "12.95gfafasf";
            double aDoubleFromStr;
            bool successfulFlag = Double.TryParse(aDoubleStr, out aDoubleFromStr);
            if (successfulFlag)
            {
                Console.WriteLine(aDoubleFromStr);

            }
            else
            {
                Console.WriteLine("Couldn't parse the value");
            }

            Console.WriteLine("The program is still running.");

            double val = 1234.5678;
            string strstr = val.ToString();
            Console.WriteLine(strstr);


            string str1 = "Hello";
            string str2 = "hello";

            if(str1 == str2)
            {
                Console.WriteLine("Two strings are the same");
            }

            if(str1.Equals(str2))
            {
                Console.WriteLine("Two strings are the same using Equals");
            }

            if(str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Two strings are the same using Equals " +
                    "ignoring cases");
            }








        }
    }
}
