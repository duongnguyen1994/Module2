using System;

namespace StopWatch
{
    class Program
    {
        public static Random r = new Random();
        static void Main(string[] args)
        {
            StopWatch test = new StopWatch();
            int[] arr = GetArray();
            test.Start();
            Sort(arr);
            test.End();
            Console.WriteLine(test.GetElapsedTime());
        }
        static int[] GetArray()
        {
            int[] arr = new int[100000];
            for(int i = 0;i<arr.Length;i++)
            {
                arr[i]= r.Next(1,1000);
            }
            return arr;
        }
        static int[] Sort(int[] array)
        {
            int smallest,temp;
            for(int i =0;i<array.Length-1;i++)
            {
                smallest = i;
                for(int j = i+1;j<array.Length;j++)
                {
                    if(array[j]<array[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}
