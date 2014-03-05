using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public struct BVector
    {
        private float x, y;

        public BVector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        #region Arithmetic Operators
        public static BVector operator +(BVector a, BVector b)
        {
            BVector ret = new BVector();
            ret.x = a.x + b.x;
            ret.y = a.y + b.y;
            return ret;
        }

        public static BVector operator -(BVector a)
        {
            BVector ret = new BVector();
            ret.x = - a.x;
            ret.y = - a.y;
            return ret;
        }

        public static BVector operator -(BVector a, BVector b)
        {
            BVector ret = new BVector();
            ret = a + (-b);
            return ret;
        }

        public static BVector operator *(BVector a, float b)
        {
            BVector ret = new BVector();
            ret.x = a.x * b;
            ret.y = a.y * b;
            return ret;
        }

        public static float operator *(BVector a, BVector b)
        {
            return (a.x * b.x) + (a.y * b.y);
        }

        public static BVector operator /(BVector a, float b)
        {
            return a * (1.0f / b);
        }

        public override string ToString()
        {
            return "(" + x + " , " + y + ")";
        }
#endregion
        #region Equality Operators
        public static bool operator ==(BVector a, BVector b)
        {
            return (a.x == b.x) && (a.y == b.y);
        }
        public static bool operator !=(BVector a, BVector b)
        {
            return !(a == b);
        }





        public float Length
        {
            get
            {
                return (float) Math.Sqrt((x * x) + (y * y));
            }
        }

        #endregion

    }
}
