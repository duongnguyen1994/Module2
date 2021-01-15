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
            string path = @"D:\codegym\Module2\bai15\TH_ReadFileXML";
            string input = @"Input\input.xml";
            string output = @"Output\output.xml";
            AddressDetails details = new AddressDetails();
            details.HouseNo = 32;
            details.StreetName = "Trần Thúc Nhẫn";
            details.City = "Huế";


            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            using (StreamWriter tx = new StreamWriter($@"{path}\{input}"))
            {
                serializer.Serialize(tx, details);
            }


            List<AddressDetails> list = new List<AddressDetails>();
            XmlSerializer deserializer = new XmlSerializer(typeof(AddressDetails));
            AddressDetails addressDetails;


            using (StreamReader reader = new StreamReader($@"{path}\{input}"))
            {
                addressDetails =(AddressDetails)deserializer.Deserialize(reader);
                list.Add(addressDetails);
            }


            using (StreamWriter tx = new StreamWriter($@"{path}\{output}"))
            {
                serializer.Serialize(tx, addressDetails);
            }
        }
    }
}
