using System;

namespace exchangeCurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            int rate = 23000;
            string choice;
            double money;
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. USD to VND");
            Console.WriteLine("2. VND to USD");
            Console.WriteLine("0. Exit");
            choice = Console.ReadLine();
            if(choice == "1")
            {
                Console.WriteLine("Enter your money:");
                money = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{money*rate} VND");
            }
            else if(choice =="2")
            {
                Console.WriteLine("Enter your money:");
                money = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{money/rate} USD");
            }
            else
            {
                Console.WriteLine("No choice!");
            }
        }
    }
}
