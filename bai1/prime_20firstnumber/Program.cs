using System;

namespace prime_20firstnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int number = 2;
            bool check = true;
            while(count<20)
            {
                for(int i =2;i<number;i++)
                {
                    if(number%i == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if(check == true)
                {
                    Console.Write($"{number} ");
                    count++;
                }
                check = true;
                number++;
            }
        }
    }
}
