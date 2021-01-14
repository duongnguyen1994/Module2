using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace TH_ReadFileXML
{
    public class AddressDetails
    {
        [XmlElement("Number")]
        public int HouseNo { get; set; }
        [XmlElement("Street")]
        public string StreetName { get; set; }
        [XmlElement("CityName")]
        public string City { get; set; }
        private string PoAddress { get; set; }

        public AddressDetails()
        {

        }

        public AddressDetails(int houseNo, string streetName, string city)
        {
            HouseNo = houseNo;
            StreetName = streetName;
            City = city;
        }

        public override string ToString()
        {
            return $"Number: {HouseNo}\nStreet: {StreetName}\nCity: {City}";
        }
    }
}
