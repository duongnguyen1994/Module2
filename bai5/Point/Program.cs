using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(5, 5);
            Console.WriteLine(point2D.ToString());

            Point3D point3D = new Point3D(3, 4, 5);
            Console.WriteLine(point3D.ToString());
        }
    }
}
