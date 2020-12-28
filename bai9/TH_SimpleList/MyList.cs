using System;
using System.Collections.Generic;
using System.Text;

namespace TH_SimpleList
{
    class MyList<T>
    {
        private int Capacity { get; set; }
        private Object[] Items;
        public MyList()
        {
            Items = new Object[10];
        }
        private void EnsureCapacity()
        {
            int newSize = Items.Length * 2;
            Array.Resize(ref Items, newSize);
        }
        public void Add(T data)
        {
            if(Capacity == Items.Length)
            {
                EnsureCapacity();
            }
            Items[Capacity++] = data;
        }
        public T GetData(int idx)
        {
            if (idx >= Capacity || idx < 0)
                {
                    throw new IndexOutOfRangeException("Index: " + idx + ", Capacity: " + Capacity);
                }

            return (T)Items[idx];
        }
    }
}
