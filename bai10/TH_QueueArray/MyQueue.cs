using System;
using System.Collections.Generic;
using System.Text;

namespace TH_QueueArray
{
    class MyQueue
    {
        private int capacity;
        private int[] queueArr;
        private int head;      
        private int tail;
        private static int count = 0;
        public MyQueue(int queueSize)
        {
            capacity = queueSize;
            queueArr = new int[capacity];           
            head = 0;
            tail = -1;            
        }
        public bool IsQueueFull()
        {
            if(capacity == count)
            {
                return true;
            }
            return false;
        }
        public bool IsQueueEmpty()
        {
            if(count ==0)
            {
                return true;
            }
            return false;
        }
        public void EnQueue(int item)
        {
            if(IsQueueFull())
            {
                Console.WriteLine($"Overflow ! Unable to add element: {item}");
            }
            else
            {
                queueArr[count++] = item;
                Console.WriteLine($"Element {item} is pushed to Queue !");
            }
        }
        public void DeQueue()
        {
            if(IsQueueEmpty())
            {
                Console.WriteLine("Underflow ! Unable to remove element from Queue");
            }
            else
            {
                Console.WriteLine($"Pop operation done ! removed: {queueArr[0]}");
                for(int i = 0;i<queueArr.Length-1;i++)
                {
                    queueArr[i] = queueArr[i + 1];
                }
                count--;
            }
        }
    }
}
