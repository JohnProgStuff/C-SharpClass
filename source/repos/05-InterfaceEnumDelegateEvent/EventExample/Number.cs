using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class Number
    {
        private PrintHelper printHelper;
        private int value;
        
        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        // beforePrintEvent handler

        void printhelper_beforePrintEvent(string message)
        {
            /*Console.WriteLine("BeforePrintEventHandler: " +
                "PrintHelper is going to print a value.");*/
            Console.WriteLine("BeforePrintEvent firest from {0}", message);
            // This is really saying. Okay I know that something is going to print on the screen.
        }

        //constructor
        public Number(int val)
        {
            this.value = val;
            printHelper = new PrintHelper();
            // subscrbe to beforePrintEvent
            printHelper.beforePrintEvent += printhelper_beforePrintEvent;
        }

        public void PrintMoney(int money)
        {
            this.printHelper.PrintMoney(money);
        }

        public void PrintTemperature(int dec)
        {
            this.printHelper.PrintTemperature(dec);
        }

    }
}
