using System;

namespace findMaxInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,3];
            Random r = new Random();
            for(int i = 0; i<arr.GetLength(0);i++)
            {
                for(int j = 0; j<arr.GetLength(1);j++)
                {
                    arr[i,j] = r.Next(10,100);
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            int max = Max(arr);
            Console.WriteLine($"Max = {max}");
        }
        static int Max(int[,] array)
        {
            int max = array[0,0];
            for(int i = 0;i<array.GetLength(0);i++)
            {
                for(int j =0;j<array.GetLength(1);j++)
                {
                    if(array[i,j]>max)
                    {
                        max = array[i,j];
                    }
                }
            }
            return max;
        }
    }
}
