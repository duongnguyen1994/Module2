using System;
using System.Collections;

namespace TH_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Student("Nguyen", 26));
            arrayList.Add(new Student("Trung", 30));
            arrayList.Add(new Student("Duong", 10));
            arrayList.Add(new Student("Mane", 17));
            arrayList.Add(new Student("Salah", 22));
            foreach(Student items in arrayList)
            {
                Console.WriteLine(items.ToString());
            }
            arrayList.RemoveAt(3);
            foreach (Student items in arrayList)
            {
                Console.WriteLine(items.ToString());
            }
            arrayList[3] = new Student("Firmino", 30);
            foreach (Student items in arrayList)
            {
                Console.WriteLine(items.ToString());
            }
        }
    }
}
