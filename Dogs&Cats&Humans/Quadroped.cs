using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    // Quadroped is a SUBCLASS of Animal, it gets everything the Animal class has
    public class Quadroped:Animal
    {
        // Set the number of legs to be 4 in the constructor...
        public Quadroped()
        {
            numLegs = 4;
        }
    }
}
