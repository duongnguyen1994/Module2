using System;

namespace ProductManagement
{
    class Program
    {
        public static Shop store = new Shop();
        static void Main(string[] args)
        {
            int choice = 0;
            bool checkChoice = true;
            do
            {
                Console.Clear();
                Menu();
                checkChoice = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        AddNewProduct();
                        break;
                    case 2:
                        DeleteProduct();
                        break;
                    case 3:
                        IterateList();
                        break;
                    case 4:
                        Search();
                        break;
                    default:
                        Console.WriteLine("Please try again!");
                        break;
                }
                Console.WriteLine("Please press enter to continued");
                string Enter = Console.ReadLine();
            } while (choice != 0 || !checkChoice);
        }
        static void Menu()
        {
            Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
            Console.WriteLine("1. Add new product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. Iterate product list");
            Console.WriteLine("4. Search product");
            Console.WriteLine("0. Exit");
            Console.WriteLine("\nPlease choice");
        }
        static void AddNewProduct()
        {
            bool check = true;
            double price = 0;
            Console.WriteLine("Enter new product's name");
            string name = Console.ReadLine();
            Console.WriteLine("Desription: ");
            string description = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter product's price: ");
                check = double.TryParse(Console.ReadLine(), out price);
            } while (!check || price <= 0);
            store.AddProduct(name, description, price);
        }
        static void DeleteProduct()
        {
            Console.WriteLine("Enter product's name want to delete:");
            string name = Console.ReadLine();
            store.RemoveProduct(name);
        }
        static void IterateList()
        {
            Console.WriteLine("Enter product's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Name\t\tDescription\tPrice\t\tRate");
            Console.WriteLine(store.IterateProductList(name));
        }
        static void Search()
        {
            bool check = true;
            double max = 0;
            double min = 0;
            do
            {
                Console.WriteLine("Enter max price:");
                check = double.TryParse(Console.ReadLine(), out max);
            }while(!check||max<0);
            do
            {
                Console.WriteLine("Enter min price:");
                check = double.TryParse(Console.ReadLine(), out min);
            }while(!check||min<0||min>max);
            store.SearchProduct(min, max);
        }
    }
}
