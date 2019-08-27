using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDateTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // local variables
            sbyte aSignedByte = 127;
            byte aByte = 255;
            ushort aUnsignedShort = 65535;
            ushort aUnsignedShortSep = 65_535;
            decimal aDecimal = 105.2903023443252890M;
            float afloat = 203.2345F;
            double aDouble = 394.22332;


            char aChar = 'A';
            string aString = "Apples";
            string sNewString = "a";

            Console.WriteLine("aByte value is {0}, {1}, {2}, {3}"
                , aByte
                , typeof(byte)
                , sizeof(byte)
                , byte.MaxValue);

            int a = 45;
            int b = 55;
            int c = a + b;

            //string examples
            char[] helloArray = { 'h', 'e', 'l', 'l', 'o', 'J', 'o', 'h', 'n' };
            Console.WriteLine(helloArray);
            string helloString = "hello";
            string hello = new string(helloArray);
            string helloUpper = hello.ToUpper();
            string helloSub = hello.Substring(3, 2);
            Console.WriteLine(hello);
            Console.WriteLine(helloUpper);
            Console.WriteLine(helloSub);

            // the string is an immutable object
            hello += " world";
            Console.WriteLine(hello);
            StringBuilder builder = new StringBuilder(hello);
            builder.Append(" And");
            builder.Append(" ");
            builder.Append(" John");
            Console.WriteLine(builder);
            Console.WriteLine(builder);
            builder.Remove(3, 9);
            Console.WriteLine(builder);
            StringBuilder builder2 = new StringBuilder();
            builder2.Append("Hello ").Append("My Name is ").Append("John");
            Console.WriteLine(builder2);
            StringBuilder builder3 = new StringBuilder();
            //Future of programming
            //builder3.Add(something).At(someLocation).If(noHouse).Build(Road);


            // parse strings to numbers
            string aNumStr = "01234";
            int aNumFromAStr = Int32.Parse(aNumStr);
            Console.WriteLine(aNumFromAStr);

            string aDoubleStr = "12.93";
            double aDoubleFromStr;
            double aDoubleFromStr3;
            if (Double.TryParse(aDoubleStr, out aDoubleFromStr)) // out
            { // first return is a boolean, 2nd and others is defined by out
                Console.WriteLine(aDoubleFromStr);
            }
            bool successfulFlag = false;
            double doubleValue;

            //[successfulFlag, doubleValue] = Double.TryParse(aDoubleStr, out aDoubleFromStr3);

            successfulFlag = Double.TryParse(aDoubleStr, out aDoubleFromStr3);
            if (successfulFlag)
            {
                Console.WriteLine("parse succeeded");
            }
            else
            {
                Console.WriteLine("error Parsing string to double");
            }
            Console.WriteLine("The program is still running.");

            string aDoubleStr2 = "12.95";
            double aDoubleFromStr2 = Double.Parse(aDoubleStr2);
            Console.WriteLine(aDoubleFromStr2);

            string str1 = "hello";
            string str2 = "hello";

            if(str1 == str2)
            {
                Console.WriteLine("Two strings are the same");
            }

            if (str1.Equals(str2))
            {
                Console.WriteLine("Two strings are Equal");
            }

            if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
            {

                Console.WriteLine("Two strings are the same using string comparison ignoring case.");
            }
        }

    }
}
