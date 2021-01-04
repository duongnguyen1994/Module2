using System;
using System.Collections;

namespace TH_SortedList
{
    class Program
    {
        static SortedList list = new SortedList();
        static void Main(string[] args)
        {
            list.Add(1, "Cuu Am Chan Kinh");
            list.Add(2, "Cuu Duong Than Cong");
            list.Add(3, "Cuu Am Bach Cot Trao");
            list.Add(4, "Doc Co Cuu Kiem");
            list.Add(5, "Thai Cuc Quyen");
            foreach(DictionaryEntry items in list)
            {
                Console.WriteLine(items.Value);
            }
            CheckKey(1);
            CheckValue("Thai Cuc Quyen");
        }
        static void CheckKey(object key)
        {
            if (list.ContainsKey(key))
            {
                Console.WriteLine(list.IndexOfKey(key));
            }
            else
                Console.WriteLine("Not found!");
        }
        static void CheckValue(object value)
        {           
            if (list.ContainsValue(value))
            {
                Console.WriteLine($"List has {value}");  
            }
            else
                Console.WriteLine("Not found"); 
        }
    }
}
