using System;
using System.IO;

namespace TH_CountNumberOfText
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\codegym\Module2\bai15\TH_CountNumberOfText\Data";
            string input = "input.txt";
            int count = 0;

            using (StreamReader reader = new StreamReader($@"{path}\{input}"))
            {
                string line;
                while((line = reader.ReadLine())!=null)
                {
                    bool check;
                    double number;
                    string[] temp = line.Trim().Split(' ');
                    for(int i =0;i<temp.Length;i++)
                    {
                        if(check = double.TryParse(temp[i], out number))
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
