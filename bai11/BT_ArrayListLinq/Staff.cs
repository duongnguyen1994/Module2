using System;
using System.Collections.Generic;
using System.Text;

namespace BT_ArrayListLinq
{
    class Staff
    {
        private static int count = 0;
        private int id;

        public int ID
        {
            get { return id; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Staff(string _name, int _age)
        {
            id = ++count;
            Name = _name;
            Age = _age;
        }
        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nAge: {Age}";
        }
    }
}
