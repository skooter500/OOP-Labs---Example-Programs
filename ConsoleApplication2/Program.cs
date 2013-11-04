using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // A list is like an array but it can grow and shrink depending on how many elements are in it
            List<A> aList = new List<A>(); // You pass the type as a parameter. Thats what the <> mean
            List<int> iList = new List<int>();

            // This is how you add elements to the lists
            iList.Add(6);
            iList.Add(6);
            iList.Add(6);
            iList.Add(7);

            aList.Add(new B());
            aList.Add(new C());
            aList.Add(new B());
            aList.Add(new C());

            // You can iterate through the list like this..
            for (int i = 0; i < iList.Count; i++)
            {
                Console.WriteLine(iList[i]);
            }

            // .. Or like this
            foreach (A a in aList)
            {
                Console.WriteLine(a);
            }


        }
    }
}
