using System;
using System.Collections.Generic;
using System.IO;

namespace BT_ReadFileCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\codegym\Module2\bai15\BT_ReadFileCSV";
            string dataPath = @"Data\FileData.csv";
            List<List<string>> data = new List<List<string>>();
            using (StreamReader sr = new StreamReader($@"{rootPath}\{dataPath}"))
            {             

                string[] value;
                string line;
                while((line = sr.ReadLine())!=null)
                {
                    List<string> test = new List<string>();
                    value = line.Split(',');
                    foreach(string items in value)
                    {
                        test.Add(items.Trim('"'));
                    }
                    data.Add(test);
                }              
            }
            foreach(List<string> list in data)
            {
                Console.WriteLine(list[list.Count-1]);
            }
        }
    }
}
