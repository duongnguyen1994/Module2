using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cat:Animal
    {
        public Cat() { }
        public Cat(string name) : base(name) { }
        public Cat(string name, int age) : base(name, age) { }
        public Cat(string name, int age, string description) : base(name, age, description) { }
        public override string ViewInfo()
        {
            return $"{base.ViewInfo()}\t\t{Speak()}";
        }
        public override string Speak()
        {
            return "Mew";
        }
    }
}
