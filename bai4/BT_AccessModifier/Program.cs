using System;

namespace BT_AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle TestCircle = new Circle();
            Console.WriteLine(TestCircle.GetRadius());
            Console.WriteLine(TestCircle.GetColor());
        }
    }
}
