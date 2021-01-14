using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3_UseLogToCreateMenu
{
    class Drinks
    {
        public string name { get; set; }
        public int price { get; set; }

        public Drinks(string _name, int _price)
        {
            name = _name;
            price = _price;
        }
    }
}
