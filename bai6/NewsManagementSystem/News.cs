using System;
using System.Collections.Generic;
using System.Text;

namespace NewsManagementSystem
{
    class News: INews
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private DateTime publishDate;
        public DateTime PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }
        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private float averageRate;
        public float AverageRate
        {
            get { return averageRate; }
        }
        private float[] rateList = new float[3];
        public News()
        {

        }
        public News(string _title, DateTime _publishDate, string _author, string _content)
        {
            title = _title;
            publishDate = _publishDate;
            author = _author;
            content = _content;
        }
        public void Display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Publish Date: {publishDate}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"{content}");
            Console.WriteLine($"Average Rate: {averageRate}");
        }
        public void AddRate()
        {
            float rate1 = Rate();
            float rate2 = Rate();
            float rate3 = Rate();
            Array.Resize(ref rateList, rateList.Length + 1);
            rateList[0] = rate1;
            rateList[1] = rate2;
            rateList[2] = rate3;
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
        public float Rate()
        {
            float rate;
            bool check = true;
            do
            {
                Console.WriteLine("Please rate from 0 to 5");
                check = float.TryParse(Console.ReadLine(), out rate);
            } while (!check || rate < 0 || rate > 5);
            return rate;
        }
        public float CalculateRate()
        {
            float sum = 0;
            for(int i = 0; i< rateList.Length; i++)
            {
                sum += rateList[i];
            }
            averageRate = sum / rateList.Length;
            return averageRate;
        }
    }
}
