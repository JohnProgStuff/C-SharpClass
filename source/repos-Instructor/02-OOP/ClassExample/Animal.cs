using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Animal
    {
        private double weight = 1.0;
        private double height;
        private int age;
        private string color;
        private string type;

        // property
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Age cannot be negative.");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Color
        {
            //get { return this.color; }
            set { this.color = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int NumberOfLegs
        {
            get;set;
        }

        public double Weight
        {
            get { return this.weight; }
        }

        public double Height
        {
            set { this.height = value; }
        }


        // methods define behavoirs:
        public virtual void Move()
        {
            Console.WriteLine("Animal Moved!");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Animal Made Noise!");
        }




    }
}
