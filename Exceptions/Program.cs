using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = null;

            try
            {
                throw new IndexOutOfRangeException("Out or range");
                //myArray = new int[1];
                //myArray[1] = 10;
                //Console.WriteLine(myArray.Length);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Got here!");
            }
            
            
        }
    }
}
