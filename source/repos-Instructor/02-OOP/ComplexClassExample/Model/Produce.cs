using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClassExample.Model
{
    public class Produce
    {
        private string name;
        private double weight;

        public string Name
        {
            get { return this.name.ToUpper(); }
            set { this.name = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public int Quantity { get; set; }

        // constructor
        public Produce()
        { }

        // method overloading
        public Produce(string name, double weight, int quantity)
        {
            this.name = name;
            this.weight = weight;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + "(" + Weight + "oz): " + Quantity;
        }
    }

}
