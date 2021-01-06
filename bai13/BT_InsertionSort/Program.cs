using System;
using System.Threading;

namespace BT_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            int size = 0;
            int delay = 0;
            do
            {
                Console.Write("Enter size: ");
                check = int.TryParse(Console.ReadLine(), out size);
            } while (!check);
            int[] array = CreateArray(size);
            ShowArray(array);
            do
            {
                Console.Write("\nEnter delay: ");
                check = int.TryParse(Console.ReadLine(), out delay);
            } while (!check);
            InsertionSort(array, delay);
            Console.WriteLine("\nComplete!");
            Console.ReadKey();
        }
        static void InsertionSort(int[] array, int delay)
        {
            for(int i = 1;i<array.Length;i++)
            {
                bool swapped = false;
                for(int j = i;j>0;j--)
                {
                    if(array[j]<array[j-1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        swapped = true;
                    }
                }
                if(swapped)
                {
                    Console.Clear();
                    ShowArray(array);
                    Thread.Sleep(delay);
                }
            }
        }
        static void ShowArray(int[] array)
        {
            Console.Write("Array: ");
            foreach(int items in array)
            {
                Console.Write($"{items} ");
            }
        }
        static int[] CreateArray(int size)
        {
            Random r = new Random();
            int[] arr = new int[size];
            for(int i =0;i<arr.Length;i++)
            {
                arr[i] = r.Next(1, 20);
            }
            return arr;
        }
    }
}
