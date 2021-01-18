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
        private List<Order>? ordersList;
        private string fullPath;

        public OrderService()
        {
            fullPath = Path.Combine(root, dataLog);
            if (File.Exists(fullPath))
            {
                ordersList = Help.ReadFile<List<Order>>(fullPath);
            }
            else
            {
                ordersList = new List<Order>();
            }
        }

        public void AddToCart(List<OrderDetail> orderDetailsList, string userId)
        {
            Order newOrder = GetOrderByUserID(userId);
            if (newOrder.userId == null)
            {
                newOrder = new Order()
                {
                    userId = userId,
                    isPaid = false,
                    ordersDetailList = orderDetailsList
                };
                foreach (OrderDetail od in newOrder.ordersDetailList)
                {
                    if (od.quantity == 0)
                    {
                        newOrder.ordersDetailList.Remove(od);
                        if (newOrder.ordersDetailList != null)
                        {
                            ordersList.Add(newOrder);
                            Help.WriteFile<List<Order>>(fullPath, ordersList);
                        }
                    }
                    else
                    {
                        ordersList.Add(newOrder);
                        Help.WriteFile<List<Order>>(fullPath, ordersList);
                    }
                }               
            }
            else if (newOrder.userId != null)
            {
                UpdateCart(orderDetailsList, userId);
            }           
        }
        public void UpdateCart(List<OrderDetail> orderDetailsList, string userId)
        {
            bool isExist;
            Order orderUpdate = GetOrderByUserID(userId);
            if (orderDetailsList.Count != 0)
            {
                try
                {
                    foreach (OrderDetail newOd in orderDetailsList)
                    {
                        isExist = false;
                        foreach (OrderDetail OldOd in orderUpdate.ordersDetailList)
                        {
                            if (newOd.productName == OldOd.productName)
                            {
                                isExist = true;
                                OldOd.quantity += newOd.quantity;
                                if (OldOd.quantity == 0)
                                {
                                    orderUpdate.ordersDetailList.Remove(OldOd);
                                    break;
                                }                               
                            }
                        }
                        if (!isExist)
                        {
                            orderUpdate.ordersDetailList.Add(newOd);
                        }
                    }
                    if (orderUpdate.ordersDetailList.Count == 0)
                    {
                        ordersList.Remove(orderUpdate);
                    }
                    Help.WriteFile<List<Order>>(fullPath, ordersList);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

        }

        public Order GetOrderByUserID(string userID)
        {          
            foreach (Order items in ordersList)
            {
                if (items.userId == userID && !items.isPaid)
                {
                    return items;
                }
            }
            return new Order();
        }

        public void ShowAllCart(string userID)
        {
            ordersList = Help.ReadFile<List<Order>>(fullPath);
            Order order = GetOrderByUserID(userID);
            if (order.userId != null)
            {
                foreach (OrderDetail items in order.ordersDetailList)
                {
                    Console.WriteLine($"Product: {items.productName}\nPrice: {items.price}\nQuantity: {items.quantity}\nAmount: {items.Amount}");
                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("=");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Your cart is empty");
            }
        }
    }
}
