using System;

namespace TH_SettingInsertionSort
{
    class Program
    {
        static int[] array = { 12, 11, 13, 5, 6 };
        static void Main(string[] args)
        {
            ShowArray();
            Console.WriteLine();
            InsertiontSort();
            ShowArray();
        }
        static void InsertiontSort()
        {
            for(int i = 1;i<array.Length;i++)
            {
                if(array[i]<array[i-1])
                {
                    int temp = array[i];
                    for(int j = i;j>0;j--)
                    {                       
                        if(array[j]>array[j-1])
                        { 
                            break;
                        }
                        if(j==1&&array[j]<array[j-1])
                        {
                            array[1] = array[0];
                            array[0] = temp;
                            break;
                        }
                        array[j] = array[j - 1];
                        array[j-1] = temp;
                    }
                }
            }
        }
        static void ShowArray()
        {
            foreach(int items in array)
            {
                Console.Write($"{items} ");
            }
        }        
    }
}
