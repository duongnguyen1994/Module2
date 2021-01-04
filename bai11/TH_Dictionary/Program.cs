using System;
using System.Collections.Generic;

namespace TH_Dictionary
{
    class Program
    {
        static Dictionary<string, Book> bookList = new Dictionary<string, Book>();
        static void Main(string[] args)
        {           
            bookList.Add("001", new Book("001", "Tay Du Ky", "Ngon Thua An"));
            bookList.Add("002", new Book("002", "Anh Hung Xa Dieu", "Kim Dung"));
            bookList.Add("003", new Book("003", "Nhat ky trong tu", "Ho Chi Minh"));
            bookList.Add("004", new Book("004", "One Piece", "Oda"));
            bookList.Add("005", new Book("005", "Cuu Am Chan Kinh", "Hoang Thuong"));
            ShowInfo();
            bookList.Remove("001");
            bookList.Remove("005");
            ShowInfo();
            CheckBook("001");
            CheckBook("002");
        }
        static void ShowInfo()
        {
            foreach(KeyValuePair<string, Book> items in bookList)
            {
                Console.WriteLine(items.Value.ToString());
            }
        }
        static void CheckBook(string key)
        {
            if (bookList.ContainsKey(key))
            {
                Console.WriteLine("Dictionary has this book");
            }
            else
            {
                Console.WriteLine("This book is not exist");
            }
        }
    }
}
