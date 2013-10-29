using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class C:A
    {
        private int c;
        public int CC
        {
            get { return c; }
            set { c = value; }
        }

        public C()
        {
            c = 13;
            Console.WriteLine("In the constructor for C");
        }
    }
}
