using System;
using System.Collections.Generic;
using System.Text;

namespace BT_MyLinkedList
{
    class MyLinkedList<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        public int Count = 0;      
        public MyLinkedList()
        {
            First = new Node<T>();
        }
        public void AddFirst(Node<T> value)
        {
            if(Count==0)
            {
                First = new Node<T>()
                {
                    Data = value
                };
                Last = First;
                Count++;
            }
            else if(Count == 1)
            {
                Last = new Node<T>
                {
                    Data = First.Data,
                    Next = null
                };
                First = new Node<T>()
                {
                    Data = value
                };
                First.Next = Last;
                Count++;
            }
            else
            {
                Node<T> temp = First;
                First = new Node<T>()
                {
                    Data = value
                };
                First.Next = temp;
                Count++;
            }           
        }
        public void AddFirst(T value)
        {
            if(Count==0)
            {
                First = new Node<T>(value);
                Last = First;
                Count++;
            }
            else if(Count==1)
            {
                Last = new Node<T>
                {
                    Data = First.Data,
                    Next = null
                };
                First = new Node<T>(value);
                First.Next = Last;
                Count++;
            }
            else
            {
                Node<T> temp = First;
                First = new Node<T>(value);
                First.Next = temp;
                Count++;
            }           
        }
        public void AddLast(Node<T> value)
        {
            Last.Next = new Node<T>
            {
                Data = value.Data,
                Next = null
            };
            Last = Last.Next;
            Count++;
        }
        public void AddLast(T value)
        {
            Last.Next = new Node<T>(value);
            Last = Last.Next;
            Count++;
        }
        public void Clear()
        {
            for (int i = 0; i < Count - 2; i++)
            {
                First.Next = First.Next.Next;
                First.Data = First.Next.Data;
            }
            First = new Node<T>();
            Last = First;
            Count = 0;
        }
        public bool Contains(T value)
        {
            Node<T> temp = First;
            for(int i =0;i<Count;i++)
            {
                if (temp.Data.Equals(value))
                {
                    return true;
                }
                else
                    temp = temp.Next;
            }
            return false;
        }
        public void CopyTo(Object[] array, int index)
        {
            Node<T> temp = First;
            for(int i =0;i<Count;i++)
            {
                array[i + index] = temp.Data;
                temp = temp.Next;
            }
        }
    }
}
