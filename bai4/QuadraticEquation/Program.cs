using System;

namespace QuadraticEquation
{
    class Program
    {
        static double a = NhapHeSo("a");
        static double b = NhapHeSo("b");
        static double c = NhapHeSo("c");
        public static QuadraticEquation quadratic = new QuadraticEquation(a, b, c);
        static void Main(string[] args)
        {
            double delta = 0;
            delta = quadratic.GetDiscriminant();
            ShowRoots(delta,a,b,c);
        }
        static double NhapHeSo(string heso)
        {
            bool check = true;
            double hs = 0;
            do
            {
                Console.WriteLine($"Enter {heso}");
                check = double.TryParse(Console.ReadLine(), out hs);
            } while (!check);
            return hs;
        }
        static void ShowRoots(double delta, double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("No Root");
                }
                else
                {
                    Console.WriteLine($"Root = {-c / b}");
                }
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("No root!");
                }
                else if (delta == 0)
                {
                    Console.WriteLine($"Has double root:\nRoot 1 = Root 2 = {quadratic.GetRoot1()}");
                }
                else
                {
                    Console.WriteLine($"Root 1 ={quadratic.GetRoot1()}");
                    Console.WriteLine($"Root 2 ={quadratic.GetRoot2()}");
                }
            }
        }
    }
}
