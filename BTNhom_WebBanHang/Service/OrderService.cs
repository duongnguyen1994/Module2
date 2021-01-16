using BTNhom_WebBanHang.Helper;
using BTNhom_WebBanHang.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BTNhom_WebBanHang.Service
{
    class OrderService : BaseService
    {
        private UserService userService;
        private List<Order> ordersList;
        private string fullPath;

        public OrderService()
        {
            userService = new UserService();
            fullPath = Path.Combine(data, dataLog);
            if(File.Exists(fullPath))
            {
                ordersList = Help.ReadFile<List<Order>>(fullPath);
            }
            else
            {
                ordersList = new List<Order>();
            }
        }

        public void CreateNewOrder(List<OrderDetail> orderDetailsList, string userId)
        {
            Order newOrder = new Order()
            {
                userId = userId,
                isPaid = false,
                ordersDetailList = orderDetailsList
            };
            ordersList.Add(newOrder);
            Help.WriteFile(fullPath,ordersList);
        }
    }
}
