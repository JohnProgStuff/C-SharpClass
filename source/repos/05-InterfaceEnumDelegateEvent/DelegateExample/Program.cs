using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        public delegate void Print(int value);

        public static void PrintNumber(int number)
        {
            Console.WriteLine("Number: {0, -12:N0}", number);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void Printhelper(Print delegateFunc, int value)
        {
            delegateFunc(value);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hex: {0:X}", dec);
        }


        static void Main(string[] args)
        {
            Print pD = PrintNumber;
            pD(50000000);
            pD = PrintMoney;
            pD(5000000);
            Print aD = new Print(PrintMoney);
            aD.Invoke(10_000);

            aD = PrintNumber;
            Printhelper(pD, 12345);
            Printhelper(aD, 12345);

            // multicast delegate;
            Console.WriteLine("Multicast Delegate: ");
            pD += PrintNumber;
            pD += PrintHexadecimal;
            pD(12003400); // prints as money, number, and hexValue
            pD -= PrintMoney;
            pD(54321);


        }

        
    }
}
