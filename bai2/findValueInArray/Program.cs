using System;

namespace findValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
            Console.WriteLine("Enter a name's student: ");
            string name = Console.ReadLine();
            name = toUpperCase(name);
            for(int i=0; i<students.Length ;i++)
            {
                if(name == students[i])
                {
                    Console.WriteLine($"Position of {name} in list is {i+1}");
                    break;
                }
                else
                {
                    Console.WriteLine($"{name} is not in this list");
                    break;
                }
            }
        }
        static string toUpperCase(string input)
        {
            char[] letter = input.ToCharArray();
            letter[0] = char.ToUpper(letter[0]);
            return new string(letter);
        }
    }
}
