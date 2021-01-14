using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3_UseLogToCreateMenu
{
    class Data
    {
        public List<Table> table { get; set; }
        public List<Drinks> menu { get; set; }

        public void Menu()
        {
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i].name}");
            }
        }
    }
}
