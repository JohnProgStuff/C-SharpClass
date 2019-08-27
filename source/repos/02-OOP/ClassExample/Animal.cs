using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Animal
    {
        private double weight;
        private double height;
        private int age;
        private int numberOfLegs;
        public int Total { get; set; } = 12;
        private string name;

        private string color;
        private string type;

        // property *******************************
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be negative.");

                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            set {
                int numberOfLets = 1000;
                this.numberOfLegs = value;
            }
        }

        public double Weight
        {
            get;
        }
        
        // when you use just get; and set; it automatically creates a member variable numberOfEyes
        // for the property NumberOfEyes I don't know if you can access it from another 
        public int NumberOfEyes
        {
            get;
            set;
        }

        public double Height
        {
            set { this.height = value; }
        }

        //methods define behaviors: **************************************
        public virtual void Move() // make it virtual so parent classes can override it
        {
            Console.WriteLine("Animal Moved!");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Animal Made Noise!");
        }

        public void Eat()
        {
            Console.WriteLine("Animal Ate!");
        }



    }
}
