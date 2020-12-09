using System;

namespace Rectangle
{
    public class Rectangle
    {
        double width,height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return this.width * this.height;
        }
        public double GetPerimeter()
        {
            return (this.width+this.height)*2;
        }
        public void Display()
        {
            Console.WriteLine($"Rectangle:\nwidth = {this.width}, height = {this.height}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width,height);
            rectangle.Display();
            Console.WriteLine($"Area = {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter = {rectangle.GetPerimeter()}");
        }
    }
}
