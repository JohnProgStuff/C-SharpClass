using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public int Milage { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving!");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping!");
        }




    }
}
