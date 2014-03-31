using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOperatorOverloading
{
    public class EditDistance
    {

        public static float min3(float a, float b, float c)
        {
            // This way...
            return Math.Min(c, Math.Min(a, b));

            /*
            // Or this...
            float min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            return min;

            // Or this!
            if ((a < b) && (a < c))
            {
                return a;
            }
            if ((b < a) && (b < c))
            {
                return b;
            }
            return c;
             */ 
        }

        public static int SubstringED(string needle, string haystack)
        {
            CMatrix m = new CMatrix(needle.Length + 1, haystack.Length + 1);

            for (int i = 0; i < m.Rows; i++)
            {
                m.Set(i, 0, i);
            }

            for (int i = 0; i < m.Cols; i++)
            {
                m.Set(0, i, 0);
            }



            for (int row = 1; row < m.Rows; row++)
            {
                for (int col = 1; col < m.Cols; col++)
                {
                    if (needle[row - 1] == haystack[col - 1])
                    {
                        m.Set(row, col, m.Get(row - 1, col - 1));
                    }
                    else
                    {
                        int min = (int)min3(m.Get(row, col - 1)
                            , m.Get(row - 1, col - 1)
                            , m.Get(row - 1, col));
                        m.Set(row, col, min + 1);
                    }
                }
            }

            Console.WriteLine(m);

            int minV = int.MaxValue;
            for (int i = 0; i < m.Cols; i++)
            {
                if (m.Get(m.Rows - 1, i) < minV)
                {
                    minV = (int) m.Get(m.Rows - 1, i);
                }
            }
            return minV;
            //return (int)m.Get(m.Rows - 1, m.Cols - 1);
        }

        public static int ED(string needle, string haystack)
        {
            CMatrix m = new CMatrix(needle.Length + 1, haystack.Length + 1);

            for (int i = 0; i < m.Rows; i++)
            {
                m.Set(i, 0, i);
            }

            for (int i = 0; i < m.Cols; i++)
            {
                m.Set(0, i, i);
            }

            

            for (int row = 1; row < m.Rows; row++)
            {
                for (int col = 1; col < m.Cols; col++)
                {
                    if (needle[row - 1] == haystack[col - 1])
                    {
                        m.Set(row, col, m.Get(row - 1, col - 1));
                    }
                    else
                    {
                        int min = (int) min3(m.Get(row, col - 1)
                            , m.Get(row - 1, col - 1)
                            , m.Get(row - 1, col));
                        m.Set(row, col, min + 1);
                    }
                }
            }

            Console.WriteLine(m);
            return (int) m.Get(m.Rows - 1, m.Cols - 1);
        }
    }
}
