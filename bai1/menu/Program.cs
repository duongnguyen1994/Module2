using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string draw = "";
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice");
            choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                Console.WriteLine("Draw the triangle");
                for(int i = 0;i<6;i++)
                {
                    draw += "*";
                    Console.WriteLine(draw);
                }
                break;
                case 2:
                Console.WriteLine("2. Draw the square");
                for(int i =0;i<6;i++)
                {
                    for(int j =0;j<6;j++)
                    {
                        draw += "* ";
                    }
                    Console.WriteLine(draw);
                    draw = "";
                }
                break;
                case 3:
                Console.WriteLine("3. Draw the rectangle");
                for(int i = 0; i<3;i++)
                {
                    for(int j=0;j<6;j++)
                    {
                        draw += "* ";
                    }
                    Console.WriteLine(draw);
                    draw = "";
                }
                break;
                case 0:
                Environment.Exit(0);
                break;
                default:
                Console.WriteLine("No choice");
                break;
            }
        }
    }
}
