using System;
using System.Collections.Generic;

namespace BT_IncreaseStringHasMaxLength
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = GetStringList("abczxyzadef");
            string stringMaxLength = stringList[0];
            for(int i =0;i<stringList.Count-1;i++)
            {
                if(EqualsString(stringList[i],stringList[i+1]))
                {
                    stringMaxLength = stringList[i];
                }
            }
            Console.WriteLine(stringMaxLength);
        }
        static List<string> GetStringList(string str)
        {
            List<string> list = new List<string>();
            int begin = 0;
            for(int i =1;i<str.Length;i++)
            {
                if(str[i-1]>str[i])
                {
                    string temp = "";
                    for(int j =begin;j<i;j++)
                    {
                        temp += str[j];
                        begin = j + 1;
                    }
                    list.Add(temp);
                }
                if(i==str.Length-1)
                {
                    string temp = "";
                    for (int j = begin; j <= i; j++)
                    {
                        temp += str[j];
                        begin = j + 1;
                    }
                    list.Add(temp);
                }
            }
            return list;
        }
        static bool EqualsString(string str1, string str2)
        {
            if(str1.Length>str2.Length)
            {
                return true;
            }
            return false;
        }
    }
}
