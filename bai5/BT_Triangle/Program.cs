using System;

namespace BT_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(10, 10, 10);
            Console.WriteLine("Side 1\t\tSide 2\t\tSide 3\t\tArea\t\tPerimeter");
            Console.WriteLine(triangle.ToString());
        }
    }
}
