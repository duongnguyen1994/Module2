using System;

namespace BT_CircleAndCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(20, "black");
            Console.WriteLine(circle.ToString());
            Console.WriteLine($"Area of Circle = {circle.GetArea()}");
            Cylinder cylinder = new Cylinder(15, "red", 20);
            Console.WriteLine(circle.ToString());
            Console.WriteLine($"V = {cylinder.GetV(cylinder.GetArea())}");
        }
    }
}
