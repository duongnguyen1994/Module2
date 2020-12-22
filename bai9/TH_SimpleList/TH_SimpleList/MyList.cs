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
            Array.Copy(Items, Items, newSize);
        }
        public void Add(T data)
        {
            if(Capacity == Items.Length)
            {
                EnsureCapacity();
            }
            Items[Capacity++] = data;
        }
        public T GetData(int index)
        {
            if (index >= Capacity || index < 0)
            {
                throw new IndexOutOfRangeException($"index: {index}\tcapacity: {Capacity}");
            }
            return (T)Items[index];
        }
    }
}
