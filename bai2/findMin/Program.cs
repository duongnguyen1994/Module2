using System;

namespace findMin
{
    class Program
    {
        static void Main(string[] args)
        {
            byte size;
            bool check=true;
            do
            {
                Console.WriteLine("Enter size of array:");
                check = byte.TryParse(Console.ReadLine(), out size);
                if(size>20)
                {
                    Console.WriteLine("Too large!");
                }
            }while(!check||size==0||size>20);
            int[] array = new int[size];
            for(byte j = 0;j<array.Length;j++)
            {
                do
                {
                    Console.WriteLine($"Enter value of array at index = {j}");
                    check = int.TryParse(Console.ReadLine(), out array[j]);
                }while(!check);
            }
            Console.Write("Value of array: ");
            foreach(int value in array)
            {
                Console.Write($"{value} ");
            }
            int min = findMinValue(array);
            Console.WriteLine($"\nMin value of array is {min}");
        }
        public static int findMinValue(int[] array)
        {
            int min = array[0];
            for(byte i =1;i<array.Length-1;i++)
            {
                if(array[i]<min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
