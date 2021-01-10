using System;
using System.Collections.Generic;

namespace TH_IndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 3, 5, 3, 6, 7 };
                int test = arr[6];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
