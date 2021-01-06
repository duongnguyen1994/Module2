using System;
using System.Threading;

namespace BT_BubbleSort
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
                Console.Write("Enter size of array: ");
                check = int.TryParse(Console.ReadLine(), out size);
            } while (!check);        
            int[] array = CreateArray(size);
            ShowArray(array);
            do
            {
                Console.Write("\nEnter delay: ");
                check = int.TryParse(Console.ReadLine(), out delay);
            } while (!check);
            BubbleSort(array, delay);
            Console.ReadKey();
        }
        static void BubbleSort(int[] array, int milliseconds)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if(array[i]>array[i+1])
                    {
                        Thread.Sleep(milliseconds);
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                        Console.Clear();
                        ShowArray(array);                       
                    }
                }
            } while (swapped);
            Console.WriteLine("\nComplete!");
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
            int[] array = new int[size];
            for(int i  = 0;i<array.Length;i++)
            {
                array[i] = r.Next(1, 20);
            }
            return array;
        }
    }
}
