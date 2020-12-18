using System;

namespace TH_Interface_ICompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(10);
            circles[1] = new Circle(70);
            circles[2] = new Circle(5);
            for(int i = 0; i<3;i++)
            {
                Console.WriteLine(circles[i].Radius);
            }
            CircleComparator circleComparator = new CircleComparator();
            Array.Sort(circles, circleComparator);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(circles[i].Radius);
            }
        }
    }      
}
