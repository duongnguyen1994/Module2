using System;
using System.Collections.Generic;
using System.Text;

namespace BT_CircleAndCylinder
{
    class Cylinder:Circle
    {
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Cylinder()
        {

        }
        public Cylinder(double _radius, string _color, double _height):base(_radius,_color)
        {
            height = _height;
        }
        public double GetV(double S)
        {
            return height * S;
        }
        public override string ToString()
        {
            return $"Height = {height}\t\t{base.ToString()}";
        }
    }
}
