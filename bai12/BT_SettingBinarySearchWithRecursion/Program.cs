using System;

namespace BT_SettingBinarySearchWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 22, 33, 21, 52, 6, 43, 78, 5, 27 };
            Sort(list);
            Console.Write("Array after sort: ");
            foreach(int items in list)
            {
                Console.Write($"{items} ");
            }
            Console.WriteLine();
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 1));
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 54));
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 21));
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 33));
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 34));
        }
        static void Sort(int[] array)
        {
            for(int i =0;i<array.Length;i++)
            {
                int min = array[i];
                int indexOfMin = i;
                for(int j = i;j<array.Length;j++)
                {
                    if(array[j]<min)
                    {
                        min = array[j];
                        indexOfMin = j;
                    }
                }
                if(indexOfMin !=i)
                {
                    array[indexOfMin] = array[i];
                    array[i] = min;
                }
            }
        }
        static int BinarySearch(int[] array,int low, int high, int number)
        {
            if(high>=low)
            {
                int mid = (high + low) / 2;
                if (array[mid] == number)
                {
                    return mid;
                }
                else if (array[mid] > number)
                {
                    return BinarySearch(array, low, mid - 1, number);
                }
                return BinarySearch(array, mid + 1, high, number);
            }
            return -1;     
        }
    }
}
