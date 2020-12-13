using System;

namespace CreateClassStudent
{
    public class Student
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Student(){}
        public Student(int _id, string _name, string _address, int _age)
        {
            id = _id;
            name = _name;
            address = _address;
            age = _age;
        }
        public string toString()
        {
            return $"Id: {id}\tName: {name}\tAddress: {address}\tAge: {age}";
        }  
    }
}