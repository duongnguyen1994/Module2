using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace BaiTap3_UseLogToCreateMenu
{
    class OrderLog
    {
        public List<Order> log;
        public OrderLog()
        {
            log = new List<Order>();
        }
    }
}
