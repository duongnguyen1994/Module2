using System;

namespace countCharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            char character;
            bool check = true;
            int count = 0;
            do
            {
                Console.WriteLine("Enter a character: ");
                check = char.TryParse(Console.ReadLine(), out character);
            } while (!check);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character)
                {
                    count++;
                }
            }
            if(character ==' ')
            {
                Console.WriteLine($"{str} has {count} non-breaking space"); 
            } 
            else     
            Console.WriteLine($"{str} has {count} {character}");          
        }
    }
}
