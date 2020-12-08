using System;

namespace deleteValueOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,1,3,4,5,6,1,8,9,10};
            bool check = true;
            int value = 0;
            do
            {
                Console.WriteLine("Enter value");
                check = int.TryParse(Console.ReadLine(), out value);
            }while(!check);
            int i = 0;
            while(i<array.Length)
            {
                if(value==array[i])
                {
                    for(int j = i;j<array.Length-1;j++)
                    {
                        array[j] = array[j+1];
                    }
                    array[array.Length-1] = 0;
                    i=0;
                }
                else
                {
                    i++;
                }
            }
            foreach(var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
