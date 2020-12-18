using System;
using System.Collections.Generic;
using System.Text;

namespace TH_Interface_ICompare
{
    public class Circle
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(int _radius)
        {
            radius = _radius;
        }
    }
}
