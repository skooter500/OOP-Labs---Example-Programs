using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class A
    {
        public static void DoStuff()
        {
            Console.WriteLine("Doing stuff!!");
        }
        private int a;
        public int AA
        {
            get { return a; }
            set { a = value; }
        }

        public A()
        {
            Console.WriteLine("In the constructor for A");
            a = 10;
        }
        public override string ToString()
        {
            return "a = " + a;
        }

    }
}
