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

            //#region Data Types
            //// numeric data types
            //sbyte aSignedByte = 127;
            //byte aByte = 255;
            //ushort anUnsignedShort = 65535;
            //short aShort = 32767;
            //int anInt = 2147483647;
            //uint anUnsignedInt = 4294967295;
            //ulong anUnsignedLong = 18446744073709551615;
            //long aLong = 9223372036854775807;
            //float aFloat = 105.5678493F;
            //double aDouble = 105.567849312873245;
            //decimal aDecimal = 105.84923797593487492387492374982347987293487M;

            //// character data types
            //char aChar = 'A';
            //string aString = "A string of chars";

            //// Output values, .NET types, size of data type and max value
            //Console.WriteLine("aByte value is {0}, {1} ,{2} Byte(s), {3}"
            //             , aByte, typeof(byte), sizeof(byte), byte.MaxValue);
            //Console.WriteLine("anInt value is {0}, {1} ,{2} Byte(s), {3}"
            //             , anInt, typeof(int), sizeof(int), int.MaxValue);
            //Console.WriteLine("aDouble value is {0}, {1} ,{2} Byte(s), {3}"
            // , aDouble, typeof(double), sizeof(double), double.MaxValue);
            //Console.WriteLine("aDecimal value is {0}, {1} ,{2} Byte(s), {3}"
            // , aDecimal, typeof(decimal), sizeof(decimal), decimal.MaxValue);
            //#endregion

            // string examples
            char[] helloArray = {'h', 'e', 'l', 'l', 'o' };
            string hello = new string(helloArray);
            //string hello = "hello";
            string helloUpper = hello.ToUpper();
            string helloSub = hello.Substring(3, 2);
            Console.WriteLine(hello);
            Console.WriteLine(helloUpper);
            Console.WriteLine(helloSub);

            // the string is an immutable object,
            // this line destroies the old string and create a new one
            hello += " world!";
            Console.WriteLine(hello);

            // use StringBuilder to modify a string,
            // only use one object in memory, best way to build strings
            StringBuilder builder = new StringBuilder();
            builder.Append("Hello");
            Console.WriteLine(builder.ToString());
            builder.Append(", ");
            builder.Append("world!");
            Console.WriteLine(builder.ToString());

            // chained method call
            builder.Append(" My name is").Append(" Yong ").Append(" Zhang!");
            Console.WriteLine(builder.ToString());

            // parse strings to numbers
            string s = "255";
            int intFromString = Int32.Parse(s);
            int doubledInt = intFromString * 2;
            Console.WriteLine(doubledInt);

            string s2 = "19.85";
            double doubleFromString = Double.Parse(s2);
            Console.WriteLine(doubleFromString);

            // use try parse if not sure about the parsing
            string s3 = "19.33abcdefg";
            double anotherDoubleFromString;
            if (Double.TryParse(s3, out anotherDoubleFromString)) 
            {
                Console.WriteLine(anotherDoubleFromString);
            }
            else
            {
                Console.WriteLine("Couldn't parse the value!");
            }

            // compare string
            string str1 = "Hello";
            string str2 = "hello";

            // okay to use == to compare string objects
            // this is not used to compare to see if two
            // references refer to the same string objects
            if( str1 == str2 )
            {
                Console.WriteLine("Strings are the same");
            } 
            if(str1.Equals(str2))
            {
                Console.WriteLine("Strings are the same");
            }
            if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Strings are the same ignoring the case.");

            }








        }
    }
}
