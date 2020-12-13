using System;

namespace CreateClassStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1,"Duong","Hue",26);
            Student student2 = new Student();
            student2.ID = 2;
            student2.Name = "Linh";
            student2.Address = "Hue";
            student2.Age = 24;
            Console.WriteLine(student1.toString());
            Console.WriteLine(student2.toString());
            Console.Read();
        }
    }
}
