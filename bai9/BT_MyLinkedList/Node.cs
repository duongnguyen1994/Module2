using System;
using System.Collections.Generic;
using System.Text;

namespace BT_MyLinkedList
{
    class Node<T>
    {
        public Object Data { get; set; }
        public Node<T> Next { get; set; }
        public Node()
        {
            Data = default;
            Next = null;
        }
        public Node(Object data)
        {
            Data = data;
            Next = null;
        }
    }
}
