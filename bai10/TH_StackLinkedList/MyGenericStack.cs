using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace TH_StackLinkedList
{
    class MyGenericStack<T>
    {
        private LinkedList<T> stack;
        public MyGenericStack()
        {
            stack = new LinkedList<T>();
        }
        public void Push(T element)
        {
            stack.AddLast(element);
            Console.WriteLine($"{element} is pushed to Stack");
        }
        public void Pop()
        {
            if(IsEmpty())
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine($"Pop operation done ! removed: {stack.Last.Value}");
                stack.RemoveLast();
            }
        }
        public int Size()
        {
            return stack.Count;
        }
        public bool IsEmpty()
        {
            if(stack.Count ==0)
            {
                return true;
            }
            return false;
        }
    }
}
