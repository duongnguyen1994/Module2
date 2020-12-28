using System;
using System.Collections.Generic;
using System.Text;

namespace TH_SimpleLinkedList
{
    class MyLinkedList
    {
        Node Head;
        int NodeCnt = 0;
        public MyLinkedList(Object data)
        {
            Head = new Node(data);
        }
        public void Add(Object data, int idx)
        {
            Node temp = Head;
            Node holder;
            for(int i=0;i<idx-1 && temp.Next !=null;i++)
            {
                temp = temp.Next;
            }
            holder = temp.Next;
            temp.Next = new Node(data);
            temp.Next.Next = holder;
            NodeCnt++;
        }
        public void AddFirst(Object Data)
        {
            Node temp = Head;
            Head = new Node(Data);
            Head.Next = temp;
            NodeCnt++;
        }
        public Node GetData(int idx)
        {
            Node temp = Head;
            for (int i = 0; i < idx; i++)
            {
                temp = temp.Next;
            }
            return temp;
        }
        public void PrintList()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
