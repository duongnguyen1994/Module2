using BTNhom_WebBanHang.Helper;
using BTNhom_WebBanHang.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BTNhom_WebBanHang.Service
{
    class PaymentService : BaseService
    {
        private Payment payment;
        private string billPath;

        public PaymentService()
        {
            payment = new Payment();
        }

        public void Pay(string userID)
        {
            billPath = $@"Bill\Bill_{userID}_{DateTime.Now.ToString("ddMMyyyyhhmmss")}.json";
            List<Order> orders = Help.ReadFile<List<Order>>($@"{root}\{dataLog}");
            for(int i = 0;i< orders.Count;i++)
            {
                if(orders[i].userId==userID && !orders[i].isPaid)
                {
                    orders[i].isPaid = true;
                    payment.userId = orders[i].userId;
                    payment.isPaid = true;
                    payment.ordersDetailList = orders[i].ordersDetailList;
                    payment.timePaid = DateTime.Now;                  
                    Help.WriteFile($@"{root}\{billPath}", payment);
                    Help.WriteFile<List<Order>>($@"{root}\{dataLog}", orders);
                    Console.WriteLine("Thank you!");
                    break;
                }
                if(i == orders.Count-1)
                {
                    Console.WriteLine("Cart is empty");
                }
            }                       
            
        }
    }
}
