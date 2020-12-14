using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tiger : Animal
    {
        public Tiger() { }
        public Tiger(string name) : base(name) { }
        public Tiger(string name, int age):base(name, age) { }
        public Tiger(string name, int age, string description) : base(name, age, description) { }
        public override string ViewInfo()
        {
            return $"{base.ViewInfo()}\t\t{Speak()}";
        }
        public override string Speak()
        {
            return "Roar";
        }
    }
}
