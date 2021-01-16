using System;
using System.Collections.Generic;
using System.Text;

namespace BTNhom_WebBanHang.Service
{
    class BaseService
    {
        protected string root = @"D:\codegym\Module2\BTNhom_WebBanHang"; 
        protected string data = @"Data\ProductData.json";              
        protected string dataLog = $@"DataLog\Log_{DateTime.Now.ToString("ddMMyyyy")}";         
        protected string dataUser = @"DataUser\users.json";
    }
}
