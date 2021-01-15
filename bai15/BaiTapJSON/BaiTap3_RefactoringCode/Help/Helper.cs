using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace BaiTap3_RefactoringCode.Help
{
    class Helper
    {
        public static T ReadFile<T>(string fullPath)
        {
            using(StreamReader sr = new StreamReader(fullPath))
            {
                var data = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(data);
            }
        }

        internal static T ReadFile<T>()
        {
            throw new NotImplementedException();
        }

        public static void WriteFile<T>(string fullPath, T data)
        {
            using(StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
        }
    }
}
