using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3
{
    class TraSuaOLong : IDrinks
    {
        public string name => Name();

        private string Name()
        {
            return "Tra Sua O Long";
        }
        public int price => Price();

        private int Price()
        {
            return 49000;
        }
    }
}
