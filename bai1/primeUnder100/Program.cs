using System;

namespace primeUnder100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            bool check = true;
            while(number<100)
            {
                for(int i=2;i<number;i++)
                {
                    if(number%i ==0)
                    {
                        check =false;
                        break;
                    }
                }
                if(check)
                {
                    Console.Write($"{number} ");
                }
                check = true;
                number++;
            }
        }
    }
}
