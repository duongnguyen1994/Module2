using System;
using System.Collections.Generic;

namespace BT_IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            if(IsPalindrome("Able was I ere I saw Elba"))
            {
                Console.WriteLine("Palindrome");
            }
        }
        static bool IsPalindrome(string value)
        {
            value = value.ToLower();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            for(int i =0;i<value.Length;i++)
            {
                stack.Push(value[i]);
                queue.Enqueue(value[i]);
            }
            for(int i = 0;i<value.Length/2;i++)
            {
                if(stack.Pop()!=queue.Dequeue())
                {
                    return false;
                }              
            }
            return true;
        }
    }
}
