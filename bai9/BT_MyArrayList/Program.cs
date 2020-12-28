using System;
using System.Collections.Generic;
using System.Collections;

namespace BT_MyArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> a = new MyList<int>();
            a.AddRange(new int[] { 1, 2, 3, 4, 5 });
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            a.Reverse();
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }


        }
    }
}
