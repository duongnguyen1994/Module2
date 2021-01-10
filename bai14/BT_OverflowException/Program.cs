using System;

namespace BT_OverflowException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = int.MaxValue;
                int num2 = int.MaxValue;
                int result;
                if((result = num1*num2)<num1)
                {
                    throw new OverflowException();
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
