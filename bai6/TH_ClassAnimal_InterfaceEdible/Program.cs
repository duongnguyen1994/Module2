using System;

namespace TH_ClassAnimal_InterfaceEdible
{
    class Program
    {
        static void Main(string[] args)
        {
            // tiger
            Tiger tiger = new Tiger();
            Console.WriteLine(tiger.MakeSound());

            // chicken
            Chicken chicken = new Chicken();
            Console.WriteLine(chicken.MakeSound());
            Console.WriteLine(chicken.HowToEat());

            // Apple
            Apple apple = new Apple();
            Console.WriteLine(apple.HowToEat());

            // Orange
            Orange orange = new Orange();
            Console.WriteLine(orange.HowToEat());
        }
    }
}
