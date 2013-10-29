using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCFiles2012
{
    public class Tune
    {
        public int x;
        public string title;
        public string altTitle;
        public string keySig;
        public string timeSig;

        public Tune()
        {
            x = 0;
            title = "";
            altTitle = "";
            keySig = "";
            timeSig = "";
        }

        public Tune(int x, string title)
        {
            this.x = x;
            this.title = title;
            altTitle = "";
            keySig = "";
            timeSig = "";
        }

        public void PrintHeaders()
        {
            Console.Write(x + "," + title);
            if (altTitle != "")
            {
                Console.Write(", " + altTitle);
            }
            if (keySig != "")
            {
                Console.Write(", " + keySig);
            }
            if (timeSig != "")
            {
                Console.Write(", " + timeSig);
            }
            Console.WriteLine();
        }
    }
}
