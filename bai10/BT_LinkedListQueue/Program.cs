using System;

namespace BT_LinkedListQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            EnQueue(queue,1);
            EnQueue(queue, 2);
            EnQueue(queue, 3);
            DisplayQueue(queue);
            DeQueue(queue);
            DeQueue(queue);
            DeQueue(queue);
            DisplayQueue(queue);
        }
        static void EnQueue(Queue queue, int value)
        {
            Node temp = new Node();
            temp.Data = value;
            if(queue.Front == null)
            {
                queue.Front = temp;
            }
            else
            {
                queue.Rear.Link = temp;
            }
            queue.Rear = temp;
            queue.Rear.Link = queue.Front;
        }
        static int DeQueue(Queue queue)
        {
            int value;
            if(queue.Front == null)
            {
                throw new Exception("Queue is empty");
            }
            else if(queue.Front == queue.Rear)
            {
                value = queue.Front.Data;
                queue.Front = null;
                queue.Rear = null;
            }
            else
            {
                value = queue.Front.Data;
                queue.Front = queue.Front.Link;
                queue.Rear.Link = queue.Front;
            }
            return value;
        }
        static void DisplayQueue(Queue queue)
        {
            Node temp = queue.Front;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                do
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Link;
                } while (temp != queue.Front);
            }            
        }
    }
}
