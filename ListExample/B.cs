using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class B:A
    {
        private int b;
        public int BB
        {
            get { return b; }
            set { b = value; }
        }

        public B()
        {
            b = 20;
            Console.WriteLine("In the constructor for B");
        }
    }
}
