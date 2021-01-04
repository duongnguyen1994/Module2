using System;
using System.Collections.Generic;
using System.Text;

namespace BT_MyCollectionGeneric
{
    class MyClass<T>
    {
        public bool CheckValue(T value1, T value2)
        {
            string a = value1.ToString().ToLower();
            string b = value2.ToString().ToLower();
            if(a == b)
            {
                return true;
            }
            return false;
        }
    }
}
