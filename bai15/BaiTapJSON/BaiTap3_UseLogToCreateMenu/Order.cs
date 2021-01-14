using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3_UseLogToCreateMenu
{
    class Order
    {
        public Table tablel { get; set; }
        public List<Drinks> drinksList { get; set; }
        public string startTime { get; }
        public string endTime { get; set; }
        public int total => Total();

        public Order()
        {
            startTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        public Order(Drinks drinks)
        {
            drinksList = new List<Drinks>();
            drinksList.Add(drinks);
            startTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        public Order(int tableID, Drinks drinks)
        {
            tablel = new Table();
            drinksList = new List<Drinks>();
            tablel.tableID = tableID;
            tablel.status = false;
            drinksList.Add(drinks);
            startTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private int Total()
        {
            int sum = 0;
            foreach(Drinks items in drinksList)
            {
                sum += items.price;
            }
            return sum;
        }
    }
}
