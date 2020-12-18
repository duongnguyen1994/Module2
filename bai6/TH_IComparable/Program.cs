using System;

namespace TH_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            ComperableCircle[] circles = new ComperableCircle[3];
            circles[0] = new ComperableCircle(10);
            circles[1] = new ComperableCircle(9);
            circles[2] = new ComperableCircle(17);

            Console.WriteLine("Pre-sorted:");
            for(int i = 0;i<3;i++)
            {
                Console.WriteLine(circles[i].Radius);
            }
            Array.Sort(circles);
            Console.WriteLine("After-sorted:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(circles[i].Radius);
            }
        }
    }
}
