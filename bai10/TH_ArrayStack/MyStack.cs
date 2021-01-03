using System;
using System.Collections.Generic;
using System.Text;

namespace TH_ArrayStack
{
    class MyStack
    {
        private int[] arr;
        private int size;
        private static int index = -1;
        public MyStack(int _size)
        {
            size = _size;
            arr = new int[size];
        }
        public bool IsEmpty()
        {
            if(index == -1)
            {
                return true;
            }
            return false;
        }
        public bool IsFull()
        {
            if(index == size-1)
            {
                return true;
            }
            return false;
        }
        public int Size()
        {
            return index + 1;
        }
        public void Push(int value)
        {
            if(IsFull())
            {
                throw new Exception("Stack is full");
            }
            arr[++index] = value;
        }
        public int Pop()
        {
            if(IsEmpty())
            {
                throw new Exception("Stack is empty");
            }
            return arr[index--];
        }
    }
}
