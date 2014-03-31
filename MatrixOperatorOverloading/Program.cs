using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            CMatrix am = new CMatrix(10, 10);
            CMatrix bm = new CMatrix(10, 10);

            am.Identity();
            bm.Identity();

            Console.WriteLine(am);
            Console.WriteLine(bm);

            CMatrix cm = am + bm;
            Console.WriteLine(cm);

            CMatrix identity = new CMatrix(4, 4);
            identity.Identity();
            CMatrix test = new CMatrix(4, 4);
            test.Set(0, 1, 10);
            test.Set(3, 1, 8);
            test.Set(2, 0, -5);

            Console.WriteLine(test);
            Console.WriteLine(identity);
            Console.WriteLine(test * identity);
            Console.WriteLine(test * test);

            CMatrix m1 = new CMatrix(3, 2);
            m1.Set(0, 0, 1);
            m1.Set(0, 1, 3);
            m1.Set(1, 0, 2);
            m1.Set(1, 1, 5);
            m1.Set(2, 0, 0);
            m1.Set(2, 1, 8);

            CMatrix m2 = new CMatrix(2, 4);
            m2.Set(0, 0, 1);
            m2.Set(0, 1, 2);
            m2.Set(0, 2, 3);
            m2.Set(0, 3, 4);
            m2.Set(1, 0, 2);
            m2.Set(1, 1, 1);
            m2.Set(1, 2, 3);
            m2.Set(1, 3, 0);

            CMatrix m3 = m1 * m2;
            Console.WriteLine(m3);

            string a = "ABDEFGHIJK";
            string b = "XDEFGHXXK";

            int ed = EditDistance.ED(a, b);

            Console.WriteLine(ed);
        }
    }
}
