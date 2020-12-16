using System;

namespace NewsManagementSystem
{
    class Program
    {
        static News[] newslist = new News[0];
        static int Id = 0;
        static void Main(string[] args)
        {
            int choice = 0;
            bool check = true;
            do
            {
                Menu();
                check = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Id = Id + 1;
                        AddNews(CreateNews());
                        break;
                    case 2:
                        ShowNews();
                        break;
                    case 3:
                        CaculateAverageRate();
                        ShowNews();
                        break;
                }
            } while(!check||choice !=4);            
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("NEWS MANAGEMENT SYSTEM");
            Console.WriteLine("1. Insert news\n2. View list news\n3. Average rate\n4. Exit");
        }
        static News CreateNews()
        {
            bool check = true;
            DateTime publishDate;
            Console.WriteLine("Title");
            string title = Console.ReadLine();
            do
            {
                Console.WriteLine("Publish Date");
                check = DateTime.TryParse(Console.ReadLine(), out publishDate);
            } while (!check || publishDate > DateTime.Now);
            Console.WriteLine("Author");
            string author = Console.ReadLine();
            Console.WriteLine("Content");
            string content = Console.ReadLine();
            News news = new News(title, publishDate, author, content);
            news.AddRate();
            news.ID = Id;
            return news;
        }
        static void AddNews(News news)
        {
            Array.Resize(ref newslist, newslist.Length + 1);
            newslist[newslist.Length - 1] = news;
        }
        static void ShowNews()
        {
            for(int i =0; i<newslist.Length;i++)
            {
                Console.WriteLine($"ID: {newslist[i].ID}");
                newslist[i].Display();
            }
            Console.Read();
        }
        static void CaculateAverageRate()
        {
            for(int i = 0; i< newslist.Length;i++)
            {
                newslist[i].CalculateRate();
            }
        }
    }
}
