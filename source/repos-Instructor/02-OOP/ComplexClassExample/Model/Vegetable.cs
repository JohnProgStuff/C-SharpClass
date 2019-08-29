using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClassExample.Model
{
    public class Vegetable : Produce
    {
        public Vegetable()
        { }

        public Vegetable(string name, double weight, int quantity)
            : base(name, weight, quantity)
        { }

        public override string ToString()
        {
            return "Vegetable: " + base.ToString();
        }


    }
}
