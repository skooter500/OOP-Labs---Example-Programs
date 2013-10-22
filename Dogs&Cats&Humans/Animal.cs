using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    public class Animal
    {
        public string name;
        public int age;
        public int numLegs;


        public virtual void Talk()
        {
            Console.WriteLine("I cant talk!! I might be a fish");
        }

        public void walk()
        {

        }
    }
}
