using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Strings in C# are immutable! That means each of the methods on a string returns a new string
            // WIthout modifying the original string
            string n = "";

            // Assignment
            n = "I love";
            // Appending (concatenating) strings
            n = n + " Tunepal";
            Console.WriteLine(n);

            // Extracting a substring. The original string (n) is UNAFFECTED
            string s = n.Substring(8);
            Console.WriteLine(s);
            s = n.Substring(8, 2);
            Console.WriteLine(s);

            // Getting access to the individual elements of a string (returns a char)
            Console.WriteLine("" + n[8] + n[9]);

            // Or another method...(returns a string - a sequence of characters)
            for (int i = n.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(n[i]);
                Console.WriteLine(n.Substring(i, 1));
            }

            // Searching a string for a substring
            int index = n.IndexOf("Tunepal");
            if (index == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("Found at character " + index);
            }
            bool b = n.StartsWith("i Love");

            // Creating a modified string from a string
            string nn = n.Insert(2, "really ");
            Console.WriteLine(n);
            Console.WriteLine(nn);

            nn = n.Remove(n.IndexOf("Tunepal"), 7) + "Star Trek";
            
            //nn = nn.Replace('e', '*');
            nn = nn.Replace("love", "hate");
            Console.WriteLine(nn);

            string a = "Hello";
            string bb = a;

            if (a == bb)
            {
                Console.WriteLine("Same");
            }

            // Splitting strings
            // You can split a string into a string array using split
            // And join a string array using join
            string test = "Bryan, Pat, Ann, Mary";
            string[] arr = test.Split(',');
            for (int i = 0; i < arr.Count(); i++)
            {
                // Trim trims whitespace from the start and end of the string
                Console.WriteLine(arr[i].Trim());
            }

            // Now join them all back together
            // This time use a ; as a delimiter
            test = String.Join(";", arr);
            Console.Write(test);

            // Converting strings to floats and ints
            s = "3.14";
            float f = float.Parse(s);
            s = "3";
            int iVal = int.Parse(s);

            // Converting floats and ints to strings
            s = "" + f;
            s = "" + iVal;
            Console.ReadLine();
        }
    }
}
