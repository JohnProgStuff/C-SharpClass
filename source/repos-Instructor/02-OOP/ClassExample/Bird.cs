using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Bird Flying");
        }
    }
}
