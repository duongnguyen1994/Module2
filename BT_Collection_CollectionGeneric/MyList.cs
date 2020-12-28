using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Collection_CollectionGeneric
{
    class MyList<T>
    {
        private int count;
        public int Count
        {
            get { return count; }
        }
        private int capacity;
        public int Capacity
        {
            get { return capacity; }
        }
        private T[] list;
        public T this[int index]
        {
            get
            {
                if (index >= 0&&index<count)
                {
                    return list[index];
                }
                throw new IndexOutOfRangeException();   
            }
        }
        public MyList()
        {
            list = new T[0];
            capacity = list.Length;
        }
        public void Add(T item)
        {
            if (capacity == 0)
            {
                Array.Resize(ref list, 2);
                list[count] = item;
                capacity = 2;
            }
            else if (count == capacity)
            {
                Array.Resize(ref list, capacity * 2);
                list[count] = item;
                capacity = capacity * 2;
            }
            else
            {
                list[count] = item;
            }
            count++;
        }
        public int IndexOf(T item)
        {
            for(int i =0;i<count;i++)
            {
                if(item.Equals(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Remove(T item)
        {
            int index = IndexOf(item);
            for (int i = index; i < count-1; i++)
            {
                list[i] = list[i + 1];
            }
            Array.Resize(ref list, count - 1);
            count--;
        }
    }
}
