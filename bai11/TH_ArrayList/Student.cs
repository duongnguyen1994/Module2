using System;
using System.Collections.Generic;
using System.Text;

namespace TH_ArrayList
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private ushort age;

        public ushort Age
        {
            get { return age; }
            set { age = value; }
        }
        public Student(string _name, ushort _age)
        {
            Name = _name;
            Age = _age;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
    }
}
