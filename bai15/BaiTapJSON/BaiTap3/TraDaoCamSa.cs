using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3
{
    class TraDaoCamSa : IDrinks
    {
        public string name => Name();

        private string Name()
        {
            return "Tra Dao Cam Sa"; 
        }
        public int price => Price();

        private int Price()
        {
            return 50000; 
        }
    }
}
