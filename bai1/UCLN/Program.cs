using System;

namespace UCLN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = Math.Abs(a);
            b = Math.Abs(b);
            if(a == 0 && b ==0)
            {
                Console.WriteLine("No greatest common factor");
            }else if(a ==0 || b ==0)
            {
                Console.WriteLine($"Greatest common factor: {a+b}");
            }else if (a>b)
            {
                Console.WriteLine($"Greatest common factor: {a-b}");
            }
            else if(a<b)
            {
                Console.WriteLine($"Greatest common factor: {b-a}");
            }
            else
            {
                Console.WriteLine($"Greatest common factor: {a}");
            }
        }   
    }
}
