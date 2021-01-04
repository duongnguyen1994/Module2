using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_ArrayListLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowLINQ();
        }
        static List<Staff> BuildList()
        {
            List<Staff> staffs = new List<Staff>();
            staffs.Add(new Staff("Nam", 24));
            staffs.Add(new Staff("Kien", 21));
            staffs.Add(new Staff("Viet", 21));
            staffs.Add(new Staff("Hang", 23));
            staffs.Add(new Staff("Tien", 24));
            return staffs;
        }
        static void ShowLINQ()
        {
            List<Staff> staffs = BuildList();
            var subset = from theElement in staffs
                         where theElement.Age < 24
                         orderby theElement.Name
                         select theElement;
            foreach(Staff theElement in subset)
            {
                Console.WriteLine(theElement.ToString());
            }
        }
    }
}
