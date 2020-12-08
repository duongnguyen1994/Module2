using System;

namespace getTotalMainCross
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix;
            int size = 0;
            bool check = true;
            double sumMainCross = 0;
            Random r = new Random();
            do
            {
                Console.WriteLine("Enter size of matrix: ");
                check = int.TryParse(Console.ReadLine(), out size);
                if (size > 10)
                {
                    Console.WriteLine("Too large!");
                }
            } while (!check || size > 10);
            matrix = new double[size, size];
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(10, 51);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            for (int z = 0; z < size; z++)
            {
                sumMainCross += matrix[z, z];
            }
            Console.WriteLine($"Total of main cross is: {sumMainCross}");
            double sumSecondaryCross = getTotalSecondaryCross(matrix);
            Console.WriteLine($"Total of main cross is: {sumSecondaryCross}");

        }
        static double getTotalSecondaryCross(double[,] array)
        {
            double result = 0;
            for(int i = array.GetLength(0)-1;i>=0;i--)
            {
                result += array[i,array.GetLength(0)-1-i];
            }
            return result;
        }
    }
}
