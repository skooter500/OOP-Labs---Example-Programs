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
            BVector v1, v2, v3;

            v1 = new BVector(5, 8);
            v2 = new BVector(2, 5);

            v3 = v1 + v2;
            Console.WriteLine("v1: " + v1);
            Console.WriteLine("v2: " + v2);
            Console.WriteLine("v3: " + v3);

            v1 += v2;

            v1 = v2 - v3;

            float f = 10.0f;
            v1.X = 5;
            v1.Y = 5;
            v2 = v1 * f;
            Console.WriteLine(v2);
            Console.ReadLine();
        }
    }
}
