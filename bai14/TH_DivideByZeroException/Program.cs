using System;

namespace TH_DivideByZeroException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = 10;
                int num2 = 0;
                int result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
