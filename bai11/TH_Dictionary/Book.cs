using System;
using System.Collections.Generic;
using System.Text;

namespace TH_Dictionary
{
    class Book
    {
        private string iSBN;

        public string ISBN
        {
            get { return iSBN; }
            set { iSBN = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public Book(string _iBSN, string _name, string _author)
        {
            ISBN = _iBSN;
            Name = _name;
            Author = _author;
        }
        public override string ToString()
        {
            return $"IBSN: {ISBN}\nName: {Name}\nAuthor: {Author}";
        }
    }
}
