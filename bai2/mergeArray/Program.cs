using System;

namespace mergeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[9];
            Random r = new Random();
            Console.Write("arr1: ");
            for(int i = 0;i<arr1.Length;i++)
            {
                arr1[i] = r.Next(10,51);
                Console.Write($"{arr1[i]} ");
            }
            Console.Write("\narr2: ");
            for(int j = 0;j<arr2.Length;j++)
            {
                arr2[j] = r.Next(0,10);
                Console.Write($"{arr2[j]} ");
            }
            int[] arr3 = new int[arr1.Length+arr2.Length];
            Console.Write("\nNew arry: ");
            for(int z = 0;z<arr3.Length;z++)
            {
                if(z<arr1.Length)
                {
                    arr3[z] = arr1[z];
                    Console.Write($"{arr3[z]} ");
                }
                else
                {
                    arr3[z] = arr2[z-arr1.Length];
                    Console.Write($"{arr3[z]} ");
                }
            }
        }
    }
}
