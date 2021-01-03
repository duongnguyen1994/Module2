using System;
using System.Collections.Generic;

namespace BT_ReverseStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] arr = new int[r.Next(5,10)];           
            for(int i = 0;i<arr.Length;i++)
            {
                arr[i] = r.Next(1, 10);
            }
            foreach(int items in arr)
            {
                Console.Write($"{items} ");
            }
            Console.WriteLine();
            Reverse(ref arr);
            foreach (int items in arr)
            {               
                Console.Write($"{items} ");
            }
        }
        static void Reverse(ref int[] array)
        {
            Stack<int> stack = new Stack<int>();
            for(int i = 0; i<array.Length;i++)
            {
                stack.Push(array[i]);
            }
            for(int i = 0;i<array.Length;i++)
            {
                array[i] = stack.Pop();
            }
        }
    }
}
