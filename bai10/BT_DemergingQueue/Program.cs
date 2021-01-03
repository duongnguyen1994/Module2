using System;

namespace BT_DemergingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Demerging List = new Demerging();
            Person p1 = new Person("Duong", false, new DateTime(1994, 4, 17));
            Person p2 = new Person("My", true, new DateTime(1994, 1, 1));
            Person p3 = new Person("Cuong", false, new DateTime(1994, 2, 1));
            Person p4 = new Person("Quyen", false, new DateTime(1994, 4, 23));
            Person p5 = new Person("Giang", true, new DateTime(1994, 4, 23));
            List.InsertPerson(p1);
            List.InsertPerson(p2);
            List.InsertPerson(p3);
            List.InsertPerson(p4);
            List.InsertPerson(p5);
            Console.WriteLine(List.Demerge());
            Console.WriteLine(List.Demerge());
            Console.WriteLine(List.Demerge());
            Console.WriteLine(List.Demerge());
            Console.WriteLine(List.Demerge());
            Console.WriteLine(List.Demerge());
        }
    }
}
