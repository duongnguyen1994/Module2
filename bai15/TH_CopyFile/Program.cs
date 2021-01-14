using System;
using System.Collections.Generic;
using System.IO;

namespace TH_CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\codegym\Module2\bai15\TH_CopyFile\Data";
            string input = "input.txt";
            string output = "output.txt";
            List<string> list = new List<string>();
            using(StreamReader reader = new StreamReader($@"{path}\{input}"))
            {
                string line;
                while((line = reader.ReadLine())!=null)
                {
                    list.Add(line);
                }
            }

            using(StreamWriter writer = new StreamWriter($@"{path}\{output}"))
            {
                for(int i =0;i<list.Count;i++)
                {
                    writer.WriteLine(list[i]);
                }
            }
        }
    }
}
