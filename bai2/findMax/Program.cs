using System;

namespace findMax
{
    class Program
    {
        static void Main(string[] args)
        {
            byte size;
            bool check = true;
            do
            {
                Console.WriteLine("Enter array's size: ");
                check = Byte.TryParse(Console.ReadLine(), out size);
                if(size >20)
                {
                    Console.WriteLine("Too large!");
                }
            }while(!check||size ==0||size >20);
            int[] array = new int[size];
            for(byte i =0;i<array.Length;i++)
            {
                do
                {
                    Console.WriteLine($"Enter element at index = {i}");
                    check = int.TryParse(Console.ReadLine(), out array[i]);
                }while(!check);
            }
            Console.Write("Element in array: ");
            foreach(int value in array)
            {
                Console.Write($"{value} ");
            }
            int max = array[0];
            for(byte j =1;j<array.Length;j++)
            {
                if(max<array[j])
                {
                    max = array[j];
                }
            }
            Console.WriteLine($"\nMax element is {max}");
        }
    }
}
