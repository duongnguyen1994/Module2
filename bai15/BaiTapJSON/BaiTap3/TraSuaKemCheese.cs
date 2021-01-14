using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3
{
    class TraSuaKemCheese : IDrinks
    {
        public string name => Name();

        private string Name()
        {
            return "Tra Sua Kem Cheese";
        }
        public int price => Price();

        private int Price()
        {
            return 45000;
        }
    }
}
