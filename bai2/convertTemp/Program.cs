using System;

namespace convertTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choice;
            bool check = true;
            double temp = 0;
            double result = 0;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit ");
            do
            {
                check = Byte.TryParse(Console.ReadLine(), out choice);
            }while(!check || choice>2);
            if(choice == 0)
            {
                Console.WriteLine("No choice!");
            }
            else if(choice == 1)
            {
                do
                {
                    Console.WriteLine("Enter temp:");
                    check = double.TryParse(Console.ReadLine(), out temp); 
                }while(!check);
                result = convertFtoC(temp);
                Console.WriteLine($"{result} C");
            }
            else
            {
                do
                {
                    Console.WriteLine("Enter temp:");
                    check = double.TryParse(Console.ReadLine(), out temp); 
                }while(!check);
                result = convertCtoF(temp);
                Console.WriteLine($"{result} F");
            }
        }
        static double convertFtoC(double F)
        {
            double C = (F-32) * 5/9;
            return C;
        }
        static double convertCtoF(double C)
        {
            double F = C*9/5 + 32;
            return F;
        }
    }
}
