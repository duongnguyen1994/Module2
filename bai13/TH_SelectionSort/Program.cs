using System;

namespace TH_SelectionSort
{
    class Program
    {
        static int[] arr = { 64, 25, 12, 22, 11 };
        static void Main(string[] args)
        {
            ShowArray();
            Console.WriteLine();
            SelectionSort();
            ShowArray();
        }
        static void SelectionSort()
        {           
            for(int i =0;i<arr.Length-1;i++)
            {
                int indexOfMin = i;
                int min = arr[i];
                for(int j = i;j<arr.Length;j++)
                {
                    if(arr[j]<min)
                    {
                        min = arr[j];
                        indexOfMin = j;
                    }
                }
                if (indexOfMin != i)
                {
                    arr[indexOfMin] = arr[i];
                    arr[i] = min;
                }
                else
                    break;
            }
        }
        static void ShowArray()
        {
            foreach(int items in arr)
            {
                Console.Write($"{items} ");
            }
        }
    }
}
