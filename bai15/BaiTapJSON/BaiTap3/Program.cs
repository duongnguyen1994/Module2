using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BaiTap3
{
    class Program
    {
        static SortedList<int, List<IDrinks>> listTable = new SortedList<int, List<IDrinks>>();
        static string path = $@"D:\codegym\Module2\bai15\BaiTapJSON\BaiTap3";
        static string order = $@"Order\Order_{DateTime.Now.ToString("ddMMyyyy")}.json";
        static GongCha gongCha = new GongCha();

        static void Main(string[] args)
        {        
            gongCha.tables = listTable;
            int choice = 0;
            bool check = true;
            while(choice!=3)
            {
                do
                {
                    MenuAction();
                    check = int.TryParse(Console.ReadLine(), out choice);
                } while (!check || choice > 3 || choice < 1);
                switch (choice)
                {
                    case 1:
                        CreateOder();
                        GetOrderLog();
                        break;
                    case 2:
                        GetBill();
                        break;
                    default:
                        Environment.Exit(3);
                        break;
                }
            }                         
        }

        static void MenuAction()
        {
            Console.Clear();
            Console.WriteLine("Choose feature");
            Console.WriteLine("1. Start order");
            Console.WriteLine("2. Start payment");
            Console.WriteLine("3. Exit");
        }

        static void Menu()
        {
            Console.WriteLine("1. Tra Dao Cam Sa\tPrice: 50k");
            Console.WriteLine("2. Tra Sua Hokkaido\tPrice: 49k");
            Console.WriteLine("3. Tra Sua Kem Cheese\tPrice: 45k");
            Console.WriteLine("4. Tra Sua O Long\tPrice: 49k");
            Console.WriteLine("5. Tra Xanh Dao\tPrice: 46k");
        }

        static void CreateOder()
        {
            List<IDrinks> drinks = new List<IDrinks>();
            int tableNumber = 0;
            bool check = true;
            do
            {
                Console.WriteLine("Enter table number:");
                check = int.TryParse(Console.ReadLine(), out tableNumber);
            } while (!check || tableNumber < 0 || tableNumber > 50);
            if(IsTableExits(tableNumber))
            {
                Order(drinks);
                foreach(IDrinks values in drinks)
                {
                    listTable[tableNumber].Add(values);
                }              
            }
            else
            {
                Order(drinks);
                listTable.Add(tableNumber, drinks);
            }
        }
        
        static void Order(List<IDrinks> drinks)
        {
            bool checkchoice = true;
            int choice = 1;
            while(choice!=0)
            {
                do
                {
                    Menu();
                    Console.WriteLine("\nEnter new drink or press 0 to exist");
                    checkchoice = int.TryParse(Console.ReadLine(), out choice);
                } while (!checkchoice || choice < 0 || choice > 5);
                switch (choice)
                {
                    case 1:
                        drinks.Add(new TraDaoCamSa());
                        break;
                    case 2:
                        drinks.Add(new TraSuaHokkaido());
                        break;
                    case 3:
                        drinks.Add(new TraSuaKemCheese());
                        break;
                    case 4:
                        drinks.Add(new TraSuaOLong());
                        break;
                    case 5:
                        drinks.Add(new TraXanhDao());
                        break;
                }
            }           
        }

        static bool IsTableExits(int tableNumber)
        {
            if (listTable.ContainsKey(tableNumber))
            {
                return true;
            }
            return false;
        }

        static void GetOrderLog()
        {
            using(StreamWriter sw = new StreamWriter($@"{path}\{order}",true))
            {
                sw.Write(JsonConvert.SerializeObject(gongCha));
            }
        }

        static void GetBill()
        {
            bool check = true;
            int tableNum = 0;
            do
            {
                Console.WriteLine("Enter table number");
                check = int.TryParse(Console.ReadLine(), out tableNum);
            } while (!check || tableNum<1);
            if(!IsTableExits(tableNum))
            {                
                Console.WriteLine("Invalid table");
            }
            else
            {
                string billPath = $@"Bill\Bill_{tableNum}_{DateTime.Now.ToString("ddMMyyyyhhmmss")}.json";
                Payment bill = new Payment();
                bill.table = tableNum;
                bill.Bill = listTable[tableNum];
                listTable.Remove(tableNum);
                using (StreamWriter sw = new StreamWriter($@"{path}\{billPath}"))
                {
                    sw.Write(JsonConvert.SerializeObject(bill));
                }
            }           
        }
    }   
}
