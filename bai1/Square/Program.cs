using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.WriteLine("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine($"Area is: {area}");
        }
    }
}
