using System;
using System.IO;

namespace TH_FileNotFoundException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"D:\codegym\Module2\bai14\TH_FileNotFoundException";
                string input = @"word.txt";
                using (StreamReader sr = new StreamReader($@"{path}\{input}"))
                {
                    sr.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
