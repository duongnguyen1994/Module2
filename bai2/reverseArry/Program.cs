using System;

namespace reverseArry
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            bool check = true;
            int temp;
            do
            {
                Console.WriteLine("Enter size: ");
                check = int.TryParse(Console.ReadLine(), out size);
                if(size>20)
                {
                    Console.WriteLine("This size too large");
                }
            }while(!check || size >20);
            int[] array = new int[size];
            int z =0;
            do
            {
                Console.WriteLine($"Enter element at index = {z}:");
                check = int.TryParse(Console.ReadLine(), out array[z]);
                if(check)
                {
                    z++;
                }
            }while(!check || z<size);
            Console.Write("Element in array: ");
            foreach(int value in array)
            {
                Console.Write($"{value} ");
            }
            for(int j = 0;j<array.Length/2;j++)
            {
                temp = array[j];
                array[j] = array[size-j-1];
                array[size-j-1] = temp;
            }
            Console.Write("\nReverse array:");
            foreach(int valueReverse in array)
            {
                Console.Write($"{valueReverse} ");
            }
        }
    }
}
