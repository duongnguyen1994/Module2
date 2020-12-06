using System;

namespace drawRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Draw the rectangle");
            Console.WriteLine("2. Draw the square triangle");
            Console.WriteLine("3. Draw the isosceles triangle");
            Console.WriteLine("0. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            string draw = "";
            if(choice == 1)
            {
                Console.WriteLine("Draw the rectangle");
                for(int i =0;i<3;i++)
                {
                    for(int j =0;j<6;j++)
                    {
                        draw += "* ";
                    }
                    Console.WriteLine(draw);
                    draw = "";
                }
            }
            else if(choice == 2)
            {
                Console.WriteLine("Choose style:");
                Console.WriteLine("1. Bottom left");
                Console.WriteLine("2. Top left");
                Console.WriteLine("3. Bottom right");
                Console.WriteLine("4. Top right");
                Console.WriteLine("0. Exit");
                int phase2 = Convert.ToInt32(Console.ReadLine());
                if(phase2 == 1)
                {
                    Console.WriteLine("Draw the square triangle bottom left");
                    for(int i = 1;i<=6;i++)
                    {
                        for(int j=0;j<i;j++)
                        {
                            draw += "* ";
                        }
                        Console.WriteLine(draw);
                        draw = "";
                    }
                }
                else if(phase2 == 2)
                {
                    Console.WriteLine("Draw the square triangle top left");
                    for(int i = 6; i>0;i--)
                    {
                        for(int j =0;j<i;j++)
                        {
                            draw += "* ";
                        }
                        Console.WriteLine(draw);
                        draw = "";
                    }
                }
                else if(phase2 == 3)
                {
                    Console.WriteLine("Draw the square triangle bottom right");
                    for(int i =1;i<=6;i++)
                    {
                        for(int j = 7;j>i;j--)
                        {
                            draw +="  ";
                        }
                        for(int z = 0;z<i;z++)
                        {
                            draw += "* ";
                        }
                        Console.WriteLine(draw);
                        draw = "";
                    }
                }
                else if(phase2 == 4)
                {
                    Console.WriteLine("Draw the square triangle top right");
                    for(int i = 6;i>0;i--)
                    {
                        for(int z = 7;z>i;z--){
                            draw += "  ";
                        }
                        for(int j = 0;j<i;j++)
                        {
                            draw += "* ";
                        }
                        Console.WriteLine(draw);
                        draw ="";
                    }
                }
                else
                {
                    Console.WriteLine("Exit!");
                }
            }
            else if(choice == 3)
            {
                Console.WriteLine("Draw the isosceles triangle");
                for(int i = 1;i<=6;i++)
                {
                    for(int z=7;z>i;z--)
                    {
                        draw += " ";
                    }
                    for(int j=0;j<i;j++)
                    {
                        draw+="* ";
                    }
                    Console.WriteLine(draw);
                    draw ="";
                }
            }
            else
            {
                Console.WriteLine("Exit!");
            }
        }
    }
}
