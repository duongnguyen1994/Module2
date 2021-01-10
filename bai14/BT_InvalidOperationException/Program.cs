using System;
using System.Collections.Generic;

namespace BT_InvalidOperationException
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> school = new List<Person>();
            school.Add(new Person("Duong", 26, "duong@gmail.com"));
            school.Add(new Person("Nguyen", 26, "nguyen@gmail.com"));
            school.Add(new Person("Hoang", 26, "hoang@gmail.com"));
            school.Add(new Person("My", 19, "my@gmail.com"));
            school.Add(new Person("Linh", 24, "linh@gmail.com"));
            try
            {
                for(int i = school.Count-1;i>=0;i--)
                {
                    if(school[i].Age <20)
                    {
                        throw new InvalidOperationException();
                    }
                    school.Remove(school[i]);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
