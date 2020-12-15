using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        private double a,b,c;
        public double A{get => a;}
        public double B{get => b;}
        public double C{get => c;}
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetDiscriminant()
        {
            return b*b - 4*a*c;
        }
        public double GetRoot1()
        { 
            return (-b-Math.Sqrt(GetDiscriminant()))/(2*a);
        }
        public double GetRoot2()
        { 
            return (-b+Math.Sqrt(GetDiscriminant()))/(2*a);
        }
    }
}