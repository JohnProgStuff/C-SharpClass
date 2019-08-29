using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClassExample.Model
{
    public class Fruit : Produce
    {
        // default constructor
        public Fruit()
        { }

        public Fruit(string name, double weight, int quantity)
            : base(name, weight, quantity)
        {
        }

        public override string ToString()
        {
            return "Fruit: " + ToString();
        }




    }
}
