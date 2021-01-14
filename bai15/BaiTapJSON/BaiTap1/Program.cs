using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\codegym\Module2\bai15\BaiTapJSON\BaiTap1\data\";
            string input = "input.json";
            string output1 = "output1.json";
            string output2 = "output2.json";
            string data;

            using (StreamReader sr = File.OpenText($@"{path}\{input}"))
            {
                data = sr.ReadToEnd();
            }
            ListNumbers result = JsonConvert.DeserializeObject<ListNumbers>(data);

            SumNumber sumNumber = new SumNumber();
            List<int> temp = new List<int>();
            foreach(Numbers value in result.list)
            {
                int item = value.a + value.b + value.c;
                temp.Add(item);
            }
            sumNumber.sum = temp;

            using (StreamWriter sw = new StreamWriter($@"{path}\{output1}"))
            {
                sw.Write(JsonConvert.SerializeObject(sumNumber));
            }

            ListNumbers multiResult = new ListNumbers();
            List<Numbers> tempMulti = new List<Numbers>();

            foreach(Numbers value in result.list)
            {
                var item = new Numbers()
                {
                    a = value.a * 2,
                    b = value.b * 2,
                    c = value.c * 2
                };
                tempMulti.Add(item);
            }
            multiResult.list = tempMulti;

            using(StreamWriter sw = new StreamWriter($@"{path}\{output2}"))
            {
                sw.Write(JsonConvert.SerializeObject(multiResult));
            }
            
            
        }
    }

    public class ListNumbers
    {
        public List<Numbers> list { get; set; }
    }

    public class Numbers
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
    }
    public class SumNumber
    {
        public List<int> sum { get; set; }
    }
   
}
