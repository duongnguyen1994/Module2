using System;
using System.Collections.Generic;
using System.Text;

namespace TH_IComparable
{
    class Circle
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle() { }
        public Circle(int _radius)
        {
            radius = _radius;
        }
    }
}
