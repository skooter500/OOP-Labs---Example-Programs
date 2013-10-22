using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Cat:Quadroped
    {
        public int numLives;
        public bool isAlive;

        public Cat()
        {
            numLives = 9;
            isAlive = true;
        }

        public void Die()
        {
            if (numLives > 0)
            {                
                numLives--;
                Console.WriteLine("Ouch! " + numLives + " left");
            }
            if (numLives == 0)
            {
                isAlive = false;
            }
        }

        // OVERRIDES the method from the BASE class
        public override void Talk()
        {         
            if (isAlive)
            {
                Console.WriteLine("Meow meow!");
            }
            else
            {
                Console.WriteLine("Im dead!");
            }
        }

    }
}
