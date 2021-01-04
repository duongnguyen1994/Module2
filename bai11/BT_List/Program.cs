using System;
using System.Collections.Generic;

namespace BT_List
{
    class Program
    {
        static List<Animal> zoo = new List<Animal>();
        static void Main(string[] args)
        {           
            zoo.Add(new Animal("lion"));
            zoo.Add(new Animal("cat"));
            zoo.Add(new Animal("dog"));
            zoo.Add(new Animal("elephant"));
            Console.WriteLine("Before sort:\n");
            foreach (Animal animals in zoo)
            {
                Console.WriteLine(animals.ToString());
            }
            Console.WriteLine("\nAfter sort:\n");
            zoo.Sort(new SortAnimal());
            foreach (Animal animals in zoo)
            {
                Console.WriteLine(animals.ToString());
            }
            Console.WriteLine("\nAfter remove:\n");
            zoo.Remove(FindAnimal("dog"));
            foreach (Animal animals in zoo)
            {
                Console.WriteLine(animals.ToString());
            }           
        }
        static Animal FindAnimal(string type)
        {
            for(int i =0;i<zoo.Count;i++)
            {
                if(type == zoo[i].Type)
                {
                    return zoo[i];
                }
            }
            return null;
        }
    }
}
