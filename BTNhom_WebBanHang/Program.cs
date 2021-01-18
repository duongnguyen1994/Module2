using BTNhom_WebBanHang.Model;
using BTNhom_WebBanHang.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BTNhom_WebBanHang
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<OrderDetail> test = new List<OrderDetail>()
            {
                new OrderDetail()
                {
                    productName = "a",
                    quantity = 1,
                    price = 10000
                },
                new OrderDetail()
                {
                    productName = "b",
                    quantity = 2,
                    price = 20000
                }
            };
            MainService main = new MainService();
            main.EnterService();
            main.ChooseProduct();
            main.AddProductToCart();
            main.ChooseProduct();
            main.AddProductToCart();
        }
    }
}
