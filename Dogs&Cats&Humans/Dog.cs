using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    public class Dog:Quadroped
    {
        public string breed;

        public Dog()
        {
            age = 0;
            name = "";
            breed = "";
        }

        public Dog(int age, string name, string breed)
        {
            this.age = age;
            this.name = name;
            this.breed = breed;

        }

        public override void Talk()
        {
            Console.WriteLine(this.name + " says Woof woof!");
            Console.WriteLine("I have" + numLegs + " legs");

        }
    }
}
