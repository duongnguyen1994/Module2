using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BaiTap3_UseLogToCreateMenu
{
    class Program
    {
        static string path = @"D:\codegym\Module2\bai15\BaiTapJSON\BaiTap3_UseLogToCreateMenu";
        static string dataPath = @"Data\data.json";
        static string orderLog = $@"Log\OrderLog_{DateTime.Now.ToString("ddMMyyyy")}.json";
        static void Main(string[] args)
        {
            string dataRoot;
            using (StreamReader sr = new StreamReader($@"{path}\{dataPath}"))
            {
                dataRoot = sr.ReadToEnd();
            }
            Data data = JsonConvert.DeserializeObject<Data>(dataRoot);

            OrderLog todayLog = ReadTodayLog();

            UseApp(todayLog, data);

        }

        static void UseApp(OrderLog log, Data data)
        {
            int choice = 0;
            bool check;
            while(choice !=3)
            {
                do
                {
                    Console.WriteLine("1. Create new order");
                    Console.WriteLine("2. Paid");
                    Console.WriteLine("3. Turn off App");
                    check = int.TryParse(Console.ReadLine(), out choice);
                } while (!check || choice < 1 || choice > 3);
                switch (choice)
                {
                    case 1:
                        CreateOrder(log, data);
                        break;
                    case 2:
                        GetPaid(log);
                        break;
                    case 3:
                        Environment.Exit(3);
                        break;
                }
            }           
        }

        static int ValidTableID()
        {
            int tblID;
            bool check;
            do
            {
                Console.Write("Enter table ID: ");
                check = int.TryParse(Console.ReadLine(), out tblID);
            } while (!check || tblID < 0 || tblID > 10);
            return tblID;
        }

        static void CreateOrder(OrderLog orderlog, Data data)
        {
            int tableId = ValidTableID();
            if(File.Exists($@"{path}\{orderLog}"))
            {
                for (int i = 0; i < orderlog.log.Count; i++)
                {
                    if (orderlog.log[i].tablel.tableID == tableId && orderlog.log[i].tablel.status == false)
                    {
                        Drinks newDrink = ChooseDrink(data);
                        orderlog.log[i].drinksList.Add(newDrink);
                        SaveLog(orderlog);
                        break;
                    }
                    if(i == orderlog.log.Count-1)
                    {
                        Drinks newDrink = ChooseDrink(data);
                        Order newOrder = new Order(tableId, newDrink);
                        orderlog.log.Add(newOrder);
                        SaveLog(orderlog);
                        break;
                    }
                }
            }
            else
            {
                Drinks newDrink = ChooseDrink(data);
                Order newOrder = new Order(tableId, newDrink);
                List<Order> temp = new List<Order>();
                temp.Add(newOrder);
                orderlog.log = temp;
                SaveLog(orderlog);
            }
        }

        static Drinks ChooseDrink(Data data)
        {
            int choice;
            bool check;
            do
            {
                data.Menu();
                Console.WriteLine("\nEnter drink");
                check = int.TryParse(Console.ReadLine(), out choice);
            } while (!check);
            return new Drinks(data.menu[choice - 1].name, data.menu[choice - 1].price);
        }

        static OrderLog ReadTodayLog()
        {
            if (File.Exists($@"{path}\{orderLog}"))
            {
                string orderToday;
                using (StreamReader sr = new StreamReader($@"{path}\{orderLog}"))
                {
                    orderToday = sr.ReadToEnd();
                }
                return JsonConvert.DeserializeObject<OrderLog>(orderToday);
            }
            return new OrderLog();
        }

        static void SaveLog(OrderLog log)
        {
            using (StreamWriter sw = new StreamWriter($@"{path}\{orderLog}"))
            {
                sw.Write(JsonConvert.SerializeObject(log));
            }
        }

        static void GetPaid(OrderLog orderLogToday)
        {
            int tableId = ValidTableID();
            string billPath = $@"Bill\Bill_TableID{tableId}_{DateTime.Now.ToString("ddMMyyyyhhmmss")}.json";
            if(!File.Exists($@"{path}\{orderLog}"))
            {
                Console.WriteLine("Invalid table");
            }
            for (int i = 0; i < orderLogToday.log.Count; i++)
            {
                if (orderLogToday.log[i].tablel.tableID == tableId && orderLogToday.log[i].tablel.status == false)
                {
                    orderLogToday.log[i].tablel.status = true;
                    orderLogToday.log[i].endTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    using (StreamWriter sw = new StreamWriter($@"{path}\{billPath}"))
                    {
                        sw.Write(JsonConvert.SerializeObject(orderLogToday.log[i]));
                    }
                    SaveLog(orderLogToday);
                    break;
                }
                if(i == orderLogToday.log.Count-1)
                {
                    Console.WriteLine("Invalid table");
                    break;
                }
            }

        }
    }
}
