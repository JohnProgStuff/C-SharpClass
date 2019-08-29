using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Dog : Animal
    {
        private string name;
        private string owner;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override void Move()
        {
            Console.WriteLine("Dog Running");
        }

    }
}
