using System;
using System.Collections.Generic;
using System.Text;

namespace TH_SimpleLinkedList
{
    class Node
    {
        public Object Data { get; set; }
        public Node Next { get; set; }
        public Node(Object data)
        {
            Data = data;
            Next = null;
        }
    }
}
