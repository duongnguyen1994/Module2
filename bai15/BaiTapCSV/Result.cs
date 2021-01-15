using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCSV
{
    class Result
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public decimal Math { get; set; }
        public decimal Physics { get; set; }
        public decimal Chemistry { get; set; }
        public decimal AverageScore => CalAverage();

        public void GetName(Student std)
        {
            string[] fn = std.Fullname.Split();
            firstName = fn[fn.Length - 1];
            Array.Resize(ref fn, fn.Length - 1);
            lastName = "";
            foreach(string items in fn)
            {
                lastName += items +" ";
            }
            lastName = lastName.Trim();
        }

        public void GetGender(Student std)
        {
            if (std.Gender == 1)
            {
                Gender = "Male";
            }
            else
                Gender = "Female";
        }
        private decimal CalAverage()
        {
            return System.Math.Round(((Math * 2 + Physics + Chemistry) / 4), 1);
        }
    }
}
