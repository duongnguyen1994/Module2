using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BT_MyArrayList
{
    class MyList<T>
    {
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
        }
        private int count;

        public int Count
        {
            get { return count; }
        }
        private T[] list;
        public T this[int index]
        {
            get
            {
                if(index>=0 && index<count)
                {
                    return list[index];
                }
                throw new IndexOutOfRangeException();
            }
        }
        public MyList()
        {
            count = 0;
            list = new T[0];
            capacity = list.Length;
        }
        public void Add(T item)
        {
            if(count==0)
            {
                Array.Resize(ref list, 2);
                capacity = 2;
            }else if(count == capacity)
            {
                Array.Resize(ref list, capacity * 2);
                capacity = capacity * 2;
            }
            list[count] = item;
            count++;
        }
        public void AddRange(T[] items)
        {
            for(int i = 0; i<items.Length;i++)
            {
                Add(items[i]);                            
            }
        }
        public void Clear()
        {
            list = null;
            count = 0;
            capacity = 0;
        }
        public object Clone()
        {
            MyList<T> newList = new MyList<T>();
            for(int i =0;i<count;i++)
            {
                newList.Add(list[i]);
            }
            return newList;
        }
        public bool Contains(T value)
        {
            for(int i = 0; i<count;i++)
            {
                if(list[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        public void CopyTo(T[] Array)
        {
            for(int i =0;i<count;i++)
            {
                Array[i] = list[i];
            }
        }
        public void CopyTo(T[] Array, int index)
        {
            for(int i = 0; i<count;i++)
            {
                Array[index + i] = list[i];
            }
        }
        public void CopyTo(int index, T[] Array, int indexArray, int count)
        {
            if(this.count-index<count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Array[indexArray + i] = list[index + i];
                }
            }           
        }
        public int IndexOf(T value)
        {
            for(int i =0;i<count;i++)
            {
                if(list[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        public int IndexOf(T value, int index)
        {
            for(int i =index;i<count;i++)
            {
                if(list[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Insert(int index, T value)
        {
            if (count == 0)
            {
                Array.Resize(ref list, 2);
                capacity = 2;
            }
            else if (count == capacity)
            {
                Array.Resize(ref list, capacity * 2);
                capacity = capacity * 2;
            }
            ++count;
            for(int i = count-1;i>index;i--)
            {
                list[i] = list[i - 1];
            }
            list[index] = value;
        }
        public void InsertRange(int index, T[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Insert(index, array[i]);
            }
        }
        public void RemoveAt(int index)
        {
            for(int i = index;i<count-1;i++)
            {
                list[i] = list[i + 1];
            }
            count--;
        }
        public void Remove(T value)
        {
            for(int i = 0;i<count;i++)
            {
                if(list.Equals(value))
                {
                    RemoveAt(i);
                }
            }
        }
        public void RemoveRange(int index, int count)
        {
            for(int i = 0;i<count;i++)
            {
                RemoveAt(index);
            }
        }
        public void Reverse()
        {
            T temp;
            for(int i = 0;i<count/2;i++)
            {
                temp = list[i];
                list[i] = list[count - 1 - i];
                list[count - 1 - i] = temp;
            }
        }
    }
}
