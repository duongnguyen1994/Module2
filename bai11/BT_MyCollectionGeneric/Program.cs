using System;

namespace BT_MyCollectionGeneric
{
    class Program
    {
        static MyClass<int> number = new MyClass<int>();
        static MyClass<string> str = new MyClass<string>();
        static void Main(string[] args)
        {
            GetResult(number.CheckValue(10, 10));
            GetResult(str.CheckValue("Duong", "duong"));
        }
        static void GetResult(bool value)
        {
            if (value)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
        }
    }
}
