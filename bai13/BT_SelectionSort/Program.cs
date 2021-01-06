using System;
using System.Threading;

namespace BT_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            int delay = 0;
            bool check = true;
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
            SelectionSort(array, delay);
            Console.ReadKey();
        }
        static int[] CreateArray(int size)
        {
            Random r = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 20);
            }
            return arr;
        }
        static void ShowArray(int[] array)
        {
            Console.Write("Array: ");
            foreach(int items in array)
            {
                Console.Write($"{items} ");
            }
        }
        static void SelectionSort(int[] array, int delay)
        {
            for(int i = 0;i<array.Length;i++)
            {
                int min = array[i];
                int indexOfMin = i;
                for(int j = i+1;j<array.Length;j++)
                {
                    if(array[j]<min)
                    {
                        min = array[j];
                        indexOfMin = j;
                    }
                }
                if(indexOfMin != i)
                {
                    Thread.Sleep(delay);
                    array[indexOfMin] = array[i];
                    array[i] = min;
                    Console.Clear();
                    ShowArray(array);
                }               
            }
        }
    }
}
    
    
