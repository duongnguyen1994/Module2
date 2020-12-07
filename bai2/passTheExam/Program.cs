using System;

namespace passTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            double[] array;
            bool check = true;
            do
            {
                Console.WriteLine("Enter size: ");
                check = int.TryParse(Console.ReadLine(), out size);
            } while (size > 30 || !check);
            array = new double[size];
            int i = 0;
            do
            {
                Console.WriteLine($"Enter a mark for student {i + 1}:");
                check = double.TryParse(Console.ReadLine(), out array[i]);
                if (check)
                {
                    i++;
                }
            } while (i < size);
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] >= 5)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                Console.WriteLine($"{count} students pass the exam");
            }
            else
            {
                Console.WriteLine($"{count} student pass the exam");
            }
        }
    }
}
