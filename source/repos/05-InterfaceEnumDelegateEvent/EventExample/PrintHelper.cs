using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class PrintHelper
    {
        // declare a delegate
        public delegate void BeforePrint(string str);

        // declare an event of type delegate
        public event BeforePrint beforePrintEvent;

        public PrintHelper()
        { }

        public void PrintNumber(int number)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent("Print Number");
            }
            Console.WriteLine("Number: {0, -12:N0}", number);
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent("Print Decimal");
            }
            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent("Print Hex");
            }
            Console.WriteLine("Hex: {0:X}", dec);
        }

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent("Print Money");
            }
            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int dec)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent("Print Temperature");
            }
            Console.WriteLine("Temperature: {0, 4:N1} F", dec);
        }

    }
}
