using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Because a Dog IS A Animal
            // This is ok
            Animal a = new Dog();

            a.Talk();

            // Same here... a has changed from a Dog instance to a Cat instance
            // This is called Polymorphism
            a = new Cat();
            a.Talk();


            Dog rover = new Dog();
            rover.Talk();

            Human bryan = new Human();
            bryan.Talk();


            Dog dori = new Dog();

            dori.age = 3;
            dori.name = "Dori";
            dori.breed = "Mongrel";
            
            Dog misty = new Dog();
            misty.age = 3;
            misty.breed = "King Charles";
            misty.name = "Misty";

            dori.Talk();
            misty.Talk();

            dori.age = 5;
            misty.age = 3;

            misty = dori;
            misty.age = 4;
            

            Console.WriteLine(dori.age);


            Dog mrT = new Dog(7, "Mr T", "King Charles");
            mrT.Talk();

            Cat theo = new Cat();
            theo.name = "Theodore";
            theo.Talk();

            while (theo.isAlive)
            {
                theo.Die();
            }

            Console.ReadLine();
        }
    }
}
