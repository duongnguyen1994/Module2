using System;
using System.Collections.Generic;

namespace BT_MaxLengthString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = GetListOfString("abcdxyznfdsfdsamgfhfdsfdsacyfdsklfds");

            Console.WriteLine(GetStringMaxLength(stringList));
            
        }
        
        static List<string> GetListOfString(string str)
        {
            List<string> list = new List<string>();
            int begin = 0;
            for(int i = 1;i<str.Length-1;i++)
            {
                string temp = "";
                if (str[i + 1] == str[begin])
                {
                    for (int j = begin; j <= i; j++)
                    {
                        temp += str[j];
                        begin++;
                    }
                    list.Add(temp);
                }
                if (i == str.Length - 2)
                {
                    for (int j = begin; j <= i; j++)
                    {
                        temp += str[j];
                    }
                    list.Add(temp);
                }
            }
            return list;
        }
        static string GetStringMaxLength(List<string> list)
        {
            string MaxLength = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Length>MaxLength.Length)
                {
                    MaxLength = list[i];
                }
            }
            return MaxLength;
        }
    }
}
