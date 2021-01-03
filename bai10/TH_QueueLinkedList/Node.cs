using System;
using System.Collections.Generic;
using System.Text;

namespace TH_QueueLinkedList
{
    class Node
    {
        public int key;
        public Node Next;
        public Node(int _key)
        {
            key = _key;
            Next = null;
        }
    }
}
