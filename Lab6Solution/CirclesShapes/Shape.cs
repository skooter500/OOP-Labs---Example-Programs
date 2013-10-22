using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CirclesShapes
{
    public  abstract class Shape
    {
        private Point centre;

        public Point Centre
        {
            get { return centre; }
            set { centre = value; }
        }

        public Shape(Point centre)
        {
            this.centre = centre;
        }

        public Shape()
        {
            centre = new Point();
        }

        public abstract float Area();       
    }
}
