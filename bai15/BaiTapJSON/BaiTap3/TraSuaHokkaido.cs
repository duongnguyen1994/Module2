using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3
{
    class TraSuaHokkaido : IDrinks
    {
        public string name => Name();

        private string Name()
        {
            return "Tra Sua Hokkaido";
        }
        public int price => Price();

        private int Price()
        {
            return 49000;
        }
    }
}
