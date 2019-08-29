using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace UsingNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle.Car myCar = new Vehicle.Car();
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Escape";
            myCar.Color = "Black";
            myCar.Milage = 10_000;
            myCar.Drive();
            myCar.Stop();

        }
    }
}
