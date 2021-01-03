using System;
using System.Collections.Generic;
using System.Text;

namespace BT_DemergingQueue
{
    class Person
    {
        private string name;
        private bool gender;
        public bool Gender
        {
            get { return gender; }           
        }
        private DateTime dayOfBirth;
        public DateTime DayOfBirth
        {
            get { return dayOfBirth; }
}
        public Person(string _name, bool _gender, DateTime _dayOfBirth)
        {
            name = _name;
            gender = _gender;
            dayOfBirth = _dayOfBirth;
        }
        public override string ToString()
        {
            return $"Name: {name}\nGender: {ShowGender()}\nDay of birth: {dayOfBirth.ToShortDateString()}";
        }
        private string ShowGender()
        {
            if(gender)
            {
                return "Nu";
            }
            return "Nam";
        }
    }
}
