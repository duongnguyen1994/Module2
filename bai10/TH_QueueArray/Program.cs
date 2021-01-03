using System;

namespace TH_QueueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue(5);
            myQueue.EnQueue(1);
            myQueue.EnQueue(2);
            myQueue.EnQueue(3);
            myQueue.EnQueue(4);
            myQueue.EnQueue(5);
            myQueue.EnQueue(6);
            myQueue.DeQueue();
            myQueue.DeQueue();
            myQueue.DeQueue();
            myQueue.DeQueue();
            myQueue.DeQueue();
            myQueue.DeQueue();
        }
    }
}
