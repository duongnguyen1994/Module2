using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Triangle
{
    class Triangle:Shape
    {
        private double side1;
        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        private double side2;
        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        private double side3;
        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }
        public Triangle()
        {
            side1 = 1.0;
            side2 = 1.0;
            side3 = 1.0;
        }
        public Triangle(double _side1, double _side2, double _side3)
        {
            side1 = _side1;
            side2 = _side2;
            side3 = _side3; 
        }
        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        public override double GetPerimeter()
        {
            return side1 + side2 + side3;
        }
        public override string ToString()
        {
            return $"{side1}\t\t{side2}\t\t{side3}\t\t{GetArea()}\t\t{GetPerimeter()}";
        }
    }
}
