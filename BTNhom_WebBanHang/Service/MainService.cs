using BTNhom_WebBanHang.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTNhom_WebBanHang.Service
{
    class MainService
    {
        private OrderService orderService;
        private UserService userService;
        private OrderDetailService OrderDetailService;
        private List<OrderDetail> orderDetails;
        private User account;

        public MainService()
        {
            OrderDetailService = new OrderDetailService();
            orderDetails = new List<OrderDetail>();
            orderService = new OrderService();
            userService = new UserService();
        }

        public void EnterService()
        {
            account = new User();
            string id;
            string pass;
            string name;
            string address;
            bool check;
            int choice;
            do
            {
                Console.WriteLine("Press 1 to Login, press 2 to signup");
                check = int.TryParse(Console.ReadLine(), out choice);
            } while (!check || choice != 1 && choice != 2);
            if (choice == 1)
            {
                Console.Write("ID: ");
                id = Console.ReadLine();
                Console.Write("Pass: ");
                pass = Console.ReadLine();
                account = userService.LogIn(id, pass);
            }
            else
            {
                Console.Write("ID: ");
                id = Console.ReadLine();
                Console.Write("Pass: ");
                pass = Console.ReadLine();
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Address: ");
                address = Console.ReadLine();
                account = userService.SignUp(id, pass, name, address);
            }
            if(account == null)
            {
                EnterService();
            }
        }

        public void ChooseProduct()
        {
            orderDetails.Add(OrderDetailService.ChooseProduct());
            if(orderDetails == null)
            {
                Console.WriteLine("Sold out");
            }
        }

        public void LogOut()
        {
            account = new User();
            Console.WriteLine("Thank you!");
            EnterService();
        }

        public void AddProductToCart()
        {
            orderService.AddToCart(orderDetails, account.userID);
            orderDetails = new List<OrderDetail>();
        }

        public void UpdateProduct()
        {
            orderService.UpdateCart(orderDetails, account.userID);
            orderDetails = new List<OrderDetail>();
        }

        public void ShowUserCart()
        {
            orderService.ShowAllCart(account.userID);
        }

        public void Menu()
        {

        }

        public void Main()
        {
            EnterService();
            Menu();
            Console.WriteLine("1. Search product");
        }
    }
}
