using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Collection_CollectionGeneric
{
    class Forum
    {
        MyList<Post> listPosts = new MyList<Post>();
        public void Add(Post newPost)
        {
            listPosts.Add(newPost);
        }
        private int SearchID(int ID)
        {
            for(int i =0;i<listPosts.Count;i++)
            {
                if(listPosts[i].ID == ID)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Update(int ID)
        {
            int index = SearchID(ID);
            if(index == -1)
            {
                Console.WriteLine($"This {ID} is not exist!");
            }
            else
            {
                Console.WriteLine("Update content:");
                listPosts[index].Content = Console.ReadLine();
                Console.WriteLine($"Post ID {ID} has been updated content!");
            }           
        }
        public void Remove(int ID)
        {
            int index = SearchID(ID);
            if (index == -1)
            {
                Console.WriteLine($"This {ID} is not exist!");
            }
            else
            {
                listPosts.Remove(listPosts[index]);
                Console.WriteLine($"Post ID {ID} has been removed!");
            }          
        }
        public string ShowPosts()
        {
            string result = "";
            for(int i = 0;i<listPosts.Count;i++)
            {
                result += listPosts[i].Display();
            }
            return result;
        }
        public string SearchPost(string author, string title)
        {
            string result = "";
            author = author.ToLower();
            title = title.ToLower();
            for(int i =0;i<listPosts.Count;i++)
            {
                if(((listPosts[i].Author).ToLower()).Contains(author)||((listPosts[i].Title).ToLower()).Contains(title))
                {
                    result += listPosts[i].Display();
                }
            }
            return result;
        } 
        public void Rating(int ID, int rate)
        {
            int index = SearchID(ID);
            if (index == -1)
            {
                Console.WriteLine($"This {ID} is not exist!");
            }
            else
            {
                listPosts[index].AddRates(rate);
                Console.WriteLine($"Thanks for your rating!");
            }                    
        }
    }
}
