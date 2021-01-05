using System;

namespace TH_SettingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 640, 4, 250, -12, 232, 11, -90 };
            ShowArray(arr);
            BubbleSort(ref arr);
            Console.WriteLine();
            ShowArray(arr);
        }
        static void BubbleSort(ref int[] array)
        {
            int temp;
            bool swapped;
            do
            {
                swapped = true;
                for (int i = 0;i< array.Length-1;i++)
                {
                    if(array[i]> array[i+1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i+1] = temp;
                        swapped = false;
                    }
                }
            } while (!swapped);
        }
        static void ShowArray(int[] array)
        {
            foreach(int items in array)
            {
                Console.Write($"{items} ");
            }
        }
    }
}
