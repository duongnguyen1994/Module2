using System;
using System.Collections.Generic;
using System.Text;

namespace TH_ClassShape
{
    class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle():base()
        {
            radius = 1.0;
        }
        public Circle(double _radius) : base ()
        {
            radius = _radius;        
        }
        public Circle(string _color, bool _filled, double _radius) : base(_color, _filled)
        {
            radius = _radius;
        }
        public double GetArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public double GetPerimeter()
        {
            return Math.PI * radius * 2;
        }
        public override string ToString()
        {
            return $"A Circle with radius = {radius}, which is a subclass of {base.ToString()}";
        }

    }
}
