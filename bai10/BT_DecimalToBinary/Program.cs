using System;
using System.Collections.Generic;

namespace BT_DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertDecimalToBinary(111);
        }
        static void ConvertDecimalToBinary(int number)
        {
            Stack<int> stack = new Stack<int>();
            do
            {
                stack.Push(number % 2);
                number = number / 2;
            } while (number != 0);
            int[] arr = new int[stack.Count];
            for(int i =0;i<arr.Length;i++)
            {
                arr[i] = stack.Pop();
                Console.Write(arr[i]);
            }             
        }
    }
}
