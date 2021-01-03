using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BT_DemergingQueue
{
    class Demerging
    {
        Queue<Person> Nam = new Queue<Person>();
        Queue<Person> Nu = new Queue<Person>();
        public Demerging()
        {

        }
        public void InsertPerson(Person person)
        {
            if (person.Gender)
            {
                Nu.Enqueue(person);
            }
            else
                Nam.Enqueue(person);
        }
        public string Demerge()
        {
            if (Nu.Count > 0)
            {
                while (Nu.Count != 0)
                {
                    return Nu.Dequeue().ToString();
                }
            }
            else if (Nam.Count > 0)
            {
                while (Nam.Count != 0)
                {
                    return Nam.Dequeue().ToString();
                }
            }
            return "Danh sach trong!";
        }
    }
}
