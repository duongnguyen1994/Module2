using System;
using System.Collections.Generic;

namespace BT_Collection_CollectionGeneric
{
    class Program
    {
        static Forum forum = new Forum();
        static void Main(string[] args)
        {
            int choice = 0;
            bool checkChoice = true;
            while(choice != 7)
            {
                Console.Clear();
                Menu();
                do
                {
                    checkChoice = int.TryParse(Console.ReadLine(), out choice);
                } while (!checkChoice || choice < 1 || choice > 7);
                switch (choice)
                {
                    case 1:
                        CreatePost();
                        break;
                    case 2:
                        UpdatePost();
                        break;
                    case 3:
                        RemovePost();
                        break;
                    case 4:
                        ShowPost();
                        break;
                    case 5:
                        Search();
                        break;
                    case 6:
                        RatingPost();
                        break;
                    default:
                        Environment.Exit(7);
                        break;
                }
                Console.ReadKey();
            }           
        }
        static void Menu()
        {
            Console.WriteLine("1.	Create Post");
            Console.WriteLine("2.	Update Post");
            Console.WriteLine("3.	Remove Post");
            Console.WriteLine("4.	Show Posts");
            Console.WriteLine("5.	Search");
            Console.WriteLine("6.	Rating");
            Console.WriteLine("7.	Exit");
        }
        static void CreatePost()
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("\nEnter content: ");
            string content = Console.ReadLine();
            Console.Write("\nEnter author: ");
            string author = Console.ReadLine();
            Post newPost = new Post(title, content, author);
            forum.Add(newPost);
            Console.WriteLine("\nComplete!");
        }
        static int ValidateID()
        {
            bool check = true;
            int id = 0;
            do
            {
                Console.Write("Enter ID: ");
                check = int.TryParse(Console.ReadLine(), out id);
            } while (!check);
            return id;
        }
        static void UpdatePost()
        {
            forum.Update(ValidateID());
            Console.WriteLine("Complete!");
        }
        static void RemovePost()
        {
            forum.Remove(ValidateID());
        }
        static void ShowPost()
        {
            Console.WriteLine(forum.ShowPosts());
        }
        static void Search()
        {
            string author;
            string title;
            do
            {
                Console.WriteLine("Enter author:");
                author = Console.ReadLine().Trim();
                Console.WriteLine("Enter title:");
                title = Console.ReadLine().Trim();
            } while (author == "" || title == "");          
            Console.WriteLine(forum.SearchPost(author, title));
        }
        static void RatingPost()
        {
            int id;
            int rate;
            bool check = true;
            do
            {
                Console.Write("Enter ID: ");
                check = int.TryParse(Console.ReadLine(), out id);
            } while (!check || id < 0);
            do
            {
                Console.Write("Enter your rating: ");
                check = int.TryParse(Console.ReadLine(), out rate);
            } while (!check || id < 0||rate>5||rate<0);
            forum.Rating(id, rate);
       }
    }
}
