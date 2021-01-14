using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3
{
    public class Payment
    {
        public string time => GetTime();
        public int table { get; set; }
        private string GetTime()
        {
            return DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }
        public List<IDrinks> Bill { get; set; }
        public int total => Total();
        private int Total()
        {
            int sum = 0;
            for(int i = 0;i<Bill.Count;i++)
            {
                sum += Bill[i].price;
            }
            return sum;
        }
    }
}
