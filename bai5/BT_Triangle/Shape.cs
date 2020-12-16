using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Triangle
{
    abstract class Shape
    {
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Shape()
        {

        }
        public Shape(double _height)
        {
            height = _height;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();      
    }
}
