using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            float f;
            bool b;

            b = true;
            b = false;

            f = 6.0f;

            i = 10;

            i++;
            ++i;

            i = i + 1;
            i += 1;

            Console.WriteLine("Hello world!");
            Console.WriteLine("What is your name");
            string myName;
            myName = Console.ReadLine();
            Console.WriteLine("Hello " + myName);
            Console.WriteLine("Hello {0} {1}", myName, i);


            

        }
    }
}
