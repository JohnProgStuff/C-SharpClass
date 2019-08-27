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
            newAnimal.Age = 10;
            Console.WriteLine("Age of the animal is: " + newAnimal.Age);
            newAnimal.Color = "green";
            Console.WriteLine("Color of animal is: " + newAnimal.Color);
            newAnimal.MakeNoise();
            newAnimal.NumberOfLegs = 4;
            Console.WriteLine("Number of legs = " + newAnimal.NumberOfLegs);

            Console.WriteLine(newAnimal.Weight);

            newAnimal.Height = 34.23;
            newAnimal.NumberOfEyes = 4;
            Console.WriteLine(newAnimal.NumberOfEyes + " eyes are staring at you!");


            Bird newBird = new Bird();
            newBird.Move();
            newBird.MakeNoise();
            newBird.Age = 1;

            // aFish is a reference to the Fish object
            Fish aFish = new Fish();
            aFish.Move();

            // Polymorphing ****************************************
            Animal a1 = new Bird();
            a1.Move();
            // Bird a2 = new Animal(); // Animal is not a bird.... a bird is a animal
            Animal a2 = new Dog();
            Animal a3 = new Fish();
            Animal a4 = new Dog();

            Console.WriteLine("Setting up Zoo");
            Animal[] zoo = { a1, a2, a3, a4 };
            foreach (Animal animal in zoo)
            {
                animal.Move();
            }

            // INVALID CAST EXCEPTION
            // Bird b = (Bird)a4;
            // Console.Write("dogBird: ");
            // b.Move();


            Dog aDogRef = (Dog)a2;
            aDogRef.Name = "Lucky";
            Console.WriteLine("Dog's name is " + aDogRef.Name);
            //Console.WriteLine("Dog's name is " + ((Dog)a2.Name));
            aDogRef = (Dog)a4;
            aDogRef.Name = "Bean";
            Console.WriteLine("Dog's name is " + aDogRef.Name);
            //Console.WriteLine("Dog's name is " + ((Dog)a4.Name));

        }
    }
}
