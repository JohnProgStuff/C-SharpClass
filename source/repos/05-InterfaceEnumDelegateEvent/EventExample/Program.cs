using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number(2345839);
            num.PrintMoney(34324);
            num.PrintTemperature(34055);
        }
    }
}
