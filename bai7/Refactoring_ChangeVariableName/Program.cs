using System;

namespace Refactoring_ChangeVariableName
{
    class Program
    {
        static void Main(string[] args)
        {
            Caculator caculator = new Caculator();
            double numberTest = caculator.Calculate(5, 10,'-');
            Console.WriteLine(numberTest);
        }
    }
}
