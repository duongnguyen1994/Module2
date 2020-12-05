using System;

namespace LinearEquationResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'ax + b = 0', please enter constants:");
            Console.WriteLine("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if(a!=0)
            {
                Console.WriteLine($"x = {-b/a}");
            }
            else
            {
                if(b == 0)
                {
                    Console.WriteLine("The solution is all x!");
                }
                else
                {
                    Console.WriteLine("Nod solution!");
                }
            }
        }
    }
}
