using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal newAnimal = new Animal();
            newAnimal.Move();
            newAnimal.MakeNoise();
            newAnimal.Age = -2;
            Console.WriteLine("Age of the animal is " + newAnimal.Age);

            newAnimal.NumberOfLegs = 4;
            Console.WriteLine("Number of legs = " + newAnimal.NumberOfLegs);

            Console.WriteLine("Weight = " + newAnimal.Weight);

            newAnimal.Height = 34.23;

            Bird aBird = new Bird();
            aBird.Move();
            aBird.MakeNoise();
            aBird.Age = 1;

            Animal a1 = new Bird();
            Animal a2 = new Dog();

            Dog aDogRef = (Dog)a2;
            aDogRef.Name = "Lucky";
            Console.WriteLine("Dog's name is " + aDogRef.Name);

            Animal a3 = new Fish();
            Animal a4 = new Dog();

            aDogRef = (Dog)a4;
            aDogRef.Name = "Bean";
            Console.WriteLine("Dog's name is " + aDogRef.Name);

            a2 = a4;

            Console.WriteLine("After, Dog's name is " + ((Dog)a2).Name);
            Console.WriteLine("After, Dog's name is " + ((Dog)a4).Name);

            Animal[] zoo = { a1, a2, a3, a4 };
            foreach(var item in zoo)
            {
                item.Move();
            }

            





        }
    }
}
