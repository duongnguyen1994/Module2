using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\codegym\Module2\bai15\BaiTapJSON\BaiTap2\Data\";
            string input = "data.json";
            string output = "Outcome.json";
            string data;

            using (StreamReader sr = new StreamReader($@"{path}\{input}"))
            {
                data = sr.ReadToEnd();
            }
            School result = JsonConvert.DeserializeObject<School>(data);
            SchoolResult schoolResult = new SchoolResult();
            List<StudentResult> studentResults = new List<StudentResult>();
            foreach(Student student in result.students)
            {
                var item = new StudentResult()
                {
                    MaHS = student.MaHS,
                    HoTen = student.HoTen,
                    GioiTinh = student.GioiTinh,
                    Lop = student.Lop,
                    MonHoc = student.MonHoc
                };
                studentResults.Add(item);
            }
            studentResults.Sort(new SortingStudents());
            schoolResult.students = studentResults;

            using (StreamWriter sw = new StreamWriter($@"{path}\{output}"))
            {
                sw.Write(JsonConvert.SerializeObject(schoolResult));
            }
        }
    }

    public class School
    {
        public List<Student> students { get; set; }
    }

    public class SchoolResult
    {
        public List<StudentResult> students { get; set; }
    }
    
    public class Student
    {
        public int MaHS { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string Lop { get; set; }
        public List<Subject> MonHoc { get; set; }
    }

    public class Subject
    {
        public string TenMonHoc { get; set; }
        public int DiemThi { get; set; }
    }

    public class StudentResult : Student
    {
        public double DTB => CalculateDTB();
        public string XepLoai => CalculateRank();

        private double CalculateDTB()
        {
            double sum =  MonHoc[0].DiemThi*2;
            for(int i =1;i<MonHoc.Count;i++)
            {
                sum += MonHoc[i].DiemThi;
            }
            return sum / 4;
        }
        
        private string CalculateRank()
        {
            if(DTB>=9&&DTB<=10)
            {
                return "Xuat sac";
            }
            if(DTB>=8)
            {
                return "Gioi";
            }
            if(DTB>=7)
            {
                return "Kha";
            }
            if(DTB>=6.5)
            {
                return "Trung Binh Kha";
            }
            if(DTB>=5)
            {
                return "Trung Binh";
            }
            if(DTB>=3.5)
            {
                return "Yeu";
            }
            return "Kem";
        }
    }
    public class SortingStudents : IComparer<StudentResult>
    {
        public int Compare(StudentResult x, StudentResult y)
        {
            if(x == null || y == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if(x.DTB>y.DTB)
                {
                    return -1;
                }
                if (x.DTB < y.DTB)
                {
                    return +1;
                }
                else
                    return 0;
            }
        }
    }
}
