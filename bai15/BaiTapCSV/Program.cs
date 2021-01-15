using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using System.Linq;
using System.Globalization;

namespace BaiTapCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = @"D:\codegym\Module2\bai15\BaiTapCSV";
            string data = @"Data\FileData.csv";
            string output = @"Data\Output.csv";
            List<Student> listStudents = new List<Student>();
            using(StreamReader sr = new StreamReader($@"{root}\{data}"))
            {
                var csvReader = new CsvReader(sr, CultureInfo.CurrentCulture);
                listStudents = csvReader.GetRecords<Student>().ToList();
            }
            List<Result> listResult = new List<Result>();

            Result temp;
            for (int i = 0;i<listStudents.Count;i++)
            {
                temp = new Result();
                temp.Id = listStudents[i].Id;
                temp.Dob = listStudents[i].Dob;
                temp.Math = listStudents[i].Math;
                temp.Physics = listStudents[i].Physics;
                temp.Chemistry = listStudents[i].Chemistry;
                temp.GetName(listStudents[i]);
                temp.GetGender(listStudents[i]);
                listResult.Add(temp);
            }

            using(StreamWriter sr = new StreamWriter($@"{root}\{output}"))
            {
                var csvWriter = new CsvWriter(sr, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(listResult);
            }
        }
    }
}
