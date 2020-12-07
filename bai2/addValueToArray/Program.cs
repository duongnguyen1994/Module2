using System;

namespace addValueToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            byte size;
            bool check = true;
            byte index =0;
            do
            {
                Console.WriteLine("Enter size of array:");
                check = byte.TryParse(Console.ReadLine(), out size);
                if (size > 20)
                {
                    Console.WriteLine("Too Large!");
                }
            } while (!check || size == 0 || size > 20);
            int[] arr = new int[size];
            for (byte i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            do
            {
                Console.WriteLine("Enter index to push value:");
                check = byte.TryParse(Console.ReadLine(), out index);
                if(index<=1||index>=arr.Length-1)
                {
                    Console.WriteLine("Can not push value to this index!\nPlease try again!");
                }
            }while(!check||index>=arr.Length-1||index<=1);
            for(int j = arr.Length-1;j>index;j--)
            {
                arr[j]=arr[j-1];
            }
            do
            {
                Console.WriteLine("Enter new value:");
                check = int.TryParse(Console.ReadLine(), out arr[index]);
            }while(!check);
            Console.Write("New array: ");
            foreach(int value in arr)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
