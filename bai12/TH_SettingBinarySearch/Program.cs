using System;

namespace TH_SettingBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 7, 33, 44, 55, 12, 43, 22 };
            Sort(array);
            foreach (int values in array)
            {
                Console.Write($"{values} ");
            }
            Console.WriteLine();
            Console.WriteLine(BinarySearch(array, 1));
            Console.WriteLine(BinarySearch(array, 44));
            Console.WriteLine(BinarySearch(array, 55));
            Console.WriteLine(BinarySearch(array, 8));
            Console.WriteLine(BinarySearch(array, 6));

        }
        static int BinarySearch(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;
            while (high >= low)
            {
                int mid = (low + high) / 2;
                if (number == array[mid])
                {
                    return mid;
                }
                else if (number > array[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

        static void Sort(int[] array)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}
