using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Collection_CollectionGeneric
{
    class Post : IPost
    {
        private static int CountId = 0;
        private int Id;
        public int ID
        {
            get { return Id; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private float averageRate;

        private List<int> Rates = new List<int>();
        public Post()
        {
            Id = ++CountId;
        }
        public Post(string _title, string _content, string _author)
        {
            Id = ++CountId;
            title = _title;
            content = _content;
            author = _author;
        }
        public string Display()
        {
            return $"ID: {ID}\nTitle: {title}\nContent: {content}\nAuthor: {author}\nCount: {Rates.Count}\nAverageRate: {averageRate}\n\n";
        }
        public float CalculatorRate()
        {
            float average = 0;
            foreach (int rate in Rates)
            {
                average += rate;
            }
            return averageRate = average/Rates.Count;
        }
        public void AddRates(int rate)
        {
            Rates.Add(rate);
            CalculatorRate();
        }
    }
}
