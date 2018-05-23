using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Color
    {
        public float r, g, b;
    }

    class Dog
    {
        public string name;
        public int size;
        public string breed;
        public Color color;

        public void Walk()
        {
            Console.WriteLine(name + " is walking.");
        }

        public void Eat(string food)
        {
            Console.WriteLine(name + " is eating " + food);
        }

        public void Shit()
        {
            Console.WriteLine(name + " is shitting.");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }

        public void Wag()
        {
            Console.WriteLine(name + " is wagging it's tail");
        }

        public void Speak()
        {
            Console.WriteLine(name + " says: Zucc");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Color brown = new Color();
            brown.r = 139;
            brown.g = 69;
            brown.b = 19;

            Dog dog1 = new Dog();
            dog1.name = "Lassie";
            dog1.size = 5;
            dog1.breed = "Cavoodle";
            dog1.color = brown;

            dog1.Speak();
            dog1.Walk();
            dog1.Eat("Meat");
            dog1.Shit();

            Console.ReadLine();
        }
    }
}
