using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Animal
    {
        protected string name;
        public string Name
        {
            get { return name; }
        }
        protected int age;
        protected string description;
        public Animal() { }
        public Animal(string name)
        {
            this.name = name;
        }
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Animal(string name, int age, string description)
        {
            this.name = name;
            this.age = age;
            this.description = description;
        }
        public virtual string ViewInfo()
        {
            return $"{name}\t\t{age}\t\t{description}\t";
        }
        public virtual string Speak()
        {
            return "";
        }
    }
}
