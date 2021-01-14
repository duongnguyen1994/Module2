using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3
{
    class TraXanhDao : IDrinks
    {
        public string name => Name();

        private string Name()
        {
            return "Tra Xanh Dao";
        }
        public int price => Price();

        private int Price()
        {
            return 46000;
        }
    }
}
