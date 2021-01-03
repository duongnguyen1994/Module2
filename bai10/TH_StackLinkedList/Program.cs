using System;

namespace TH_StackLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Stack of integers");
            StackOfIntegers();
            Console.WriteLine("\n2. Stack of Strings");
            StackOfIStrings();
        }
        private static void StackOfIntegers()
        {
            MyGenericStack<int> stack = new MyGenericStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine($"1.1. Size = {stack.Size()}");
            Console.WriteLine("1.2. Pop elements from stack..");
            while(!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine($"1.3. Size = {stack.Size()}");
        }
        private static void StackOfIStrings()
        {
            MyGenericStack<string> stack = new MyGenericStack<string>();
            stack.Push("Nguyen");
            stack.Push("Trung");
            stack.Push("Duong");
            Console.WriteLine($"2.1. Size = {stack.Size()}");
            Console.WriteLine("2.2. Pop elements from stack..");
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine($"2.3. Size = {stack.Size()}");
        }
    }
}
