using System;
using System.Collections.Generic;
using System.Text;

namespace TH_QueueLinkedList
{
    class MyLinkedListQueue
    {
        private Node head;
        private Node tail;
        public MyLinkedListQueue()
        {
            head = null;
            tail = null;
        }
        public void Enqueue(int key)
        {
            Node newNode = new Node(key);
            if(head==null)
            {
                head = tail = newNode;
            }
            else if(head == tail)
            {
                tail = newNode;
                head.Next = tail;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }
        public Node Dequeue()
        {
            if(head == null)
            {
                return null;
            }
            Node temp = head;
            head = head.Next;
            return temp;
        }
    }
}
