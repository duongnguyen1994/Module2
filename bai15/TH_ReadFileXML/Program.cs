using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TH_ReadFileXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddressDetails details = new AddressDetails();
            //details.HouseNo = 32;
            //details.StreetName = "Trần Thúc Nhẫn";
            //details.City = "Huế";
            //XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            //using(TextWriter tx = new StreamWriter(@"D:\codegym\Module2\bai15\test\input.xml"))
            //{
            //    serializer.Serialize(tx, details);
            //}
            List<AddressDetails> list = new List<AddressDetails>();
            XmlSerializer deserializer = new XmlSerializer(typeof(AddressDetails));
            using (TextReader reader = new StreamReader(@"D:\codegym\Module2\bai15\test\input.xml"))
            {
                AddressDetails addressDetails =(AddressDetails)deserializer.Deserialize(reader);
                list.Add(addressDetails);
            }
            Console.WriteLine(list[0].ToString());
        }
    }
}
