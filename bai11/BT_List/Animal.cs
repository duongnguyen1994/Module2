using System;
using System.Collections.Generic;
using System.Text;

namespace BT_List
{
    class Animal
    {
        private string type;
        public string Type
        {
            get { return type; }
        }
        public Animal(string _type)
        {
            type = _type;
        }
        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
