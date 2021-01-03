using System;
using System.Collections.Generic;

namespace BT_CheckBracket
{
    class Program
    {
        static void Main(string[] args)
        {
            if(CheckBracket("s * (s – a) * (s – b) * (s – c)"))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
            if (CheckBracket("(– b + (b2 – 4*a*c)^0.5) / 2*a"))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
            if (CheckBracket("s * (s – a) * (s – b * (s – c)"))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
            if (CheckBracket("s * (s – a) * s – b) * (s – c)"))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
            if (CheckBracket("(– b + (b^2 – 4*a*c)^(0.5/ 2*a))"))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
        }
        static bool CheckBracket(string expression)
        {
            char left;
            Stack<char> bStack = new Stack<char>();
            for(int i = 0;i<expression.Length;i++)
            {
                if(expression[i]=='(')
                {
                    bStack.Push(expression[i]);
                }
                if(expression[i] == ')')
                {
                    if(bStack.Count==0)
                    {
                        return false;
                    }
                    left = bStack.Pop();
                }
            }
            if(bStack.Count==0)
            {
                return true;
            }
            return false;
        }
    }
}
