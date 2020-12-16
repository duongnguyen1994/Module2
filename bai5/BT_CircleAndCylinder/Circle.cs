using System;
using System.Collections.Generic;
using System.Text;

namespace BT_CircleAndCylinder
{
    class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Circle()
        {

        }
        public Circle(double _radius, string _color)
        {
            radius = _radius;
            color = _color;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return $"Radius = {radius}\t\tColor = {color}";
        }
    }
}
