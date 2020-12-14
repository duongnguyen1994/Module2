using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dog:Animal
    {
        public Dog() { }
        public Dog(string name) : base(name) { }
        public Dog(string name, int age) : base(name, age) { }
        public Dog(string name, int age, string description) : base(name, age, description) { }
        public override string ViewInfo()
        {
            return $"{base.ViewInfo()}\t\t{Speak()}";
        }
        public override string Speak()
        {
            return "woof-woof";
        }
    }
}
