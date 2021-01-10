using System;
using System.Collections.Generic;
using System.Text;

namespace BT_InvalidOperationException
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Person(string _name, int _age, string _email)
        {
            Name = _name;
            Age = _age;
            Email = _email;
        }
    }
}
