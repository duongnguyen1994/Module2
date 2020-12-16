using System;

namespace TH_ClassShape
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape test
            Shape shape = new Shape();
            Console.WriteLine(shape.ToString());
            shape = new Shape("Black", false);
            Console.WriteLine(shape.ToString());

            // Circle test
            Circle circle = new Circle();
            Console.WriteLine(circle.ToString());
            circle = new Circle(5);
            Console.WriteLine(circle.ToString());
            circle = new Circle("Red", false, 10);
            Console.WriteLine(circle.ToString());

            // Rectangle test
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.ToString());
            rectangle = new Rectangle(10, 20);
            Console.WriteLine(rectangle.ToString());
            rectangle = new Rectangle("Yellow", false, 5, 10);
            Console.WriteLine(rectangle.ToString());

            // Square test
            Square square = new Square();
            Console.WriteLine(square.ToString());
            square = new Square(1);
            Console.WriteLine(square.ToString());
            square = new Square("Blue", true,2);
            Console.WriteLine(square.ToString());
        }
    }
}
