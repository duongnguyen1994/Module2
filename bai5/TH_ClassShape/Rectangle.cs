using System;
using System.Collections.Generic;
using System.Text;

namespace TH_ClassShape
{
    class Rectangle : Shape
    {
        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        private double length;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Rectangle() : base()
        {
            width = 1.0;
            length = 1.0;
        }
        public Rectangle(double _width, double _length):base()
        {
            width = _width;
            length = _length;
        }
        public Rectangle(string _color, bool _filled, double _width, double _length):base(_color,_filled)
        {
            width = _width;
            length = _length;
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return (length + width) * 2;
        }
        public override string ToString()
        {
            return $"A Rectangle with width = {width} and length = {length}, which is a subclass of {base.ToString()}";
        }
    }
}
