using System;

namespace deleteValueOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]{1,2,3,4,5,6,7,8,9,10};
            bool check = true;
            int value = 0;
            do
            {
                Console.WriteLine("Enter value");
                check = int.TryParse(Console.ReadLine(), out value);
            }while(!check);
            for(int i =0;i<array.Length;i++)
            {
                if(value==array[i])
                {
                    for(int j = i;j<array.Length-1;j++)
                    {
                        array[j] = array[j+1];
                    }
                    array[array.Length-1] = 0;
                }
            }
            foreach(var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
