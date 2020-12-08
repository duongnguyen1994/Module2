using System;

namespace findMinInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            int row = 0;
            int col = 0;
            bool check1 = true;
            bool check2 = true;
            Random r = new Random();
            do
            {
                Console.WriteLine("Enter row: ");
                check1 = int.TryParse(Console.ReadLine(), out row);
                Console.WriteLine("Enter column: ");
                check2 = int.TryParse(Console.ReadLine(), out col);
                if(row>10||col>10)
                {
                    Console.WriteLine("Too large!");
                }
            }while(!check1||!check2||row>10||col>10);
            matrix = new int[row,col];
            Console.WriteLine("Matrix: ");
            for(int i = 0;i<matrix.GetLength(0);i++)
            {
                for(int j =0; j<matrix.GetLength(1);j++)
                {
                    matrix[i,j] = r.Next(10,100);
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
            int min = Min(matrix);
            Console.WriteLine($"Min = {min}");
        }
        static int Min(int[,] array)
        {
            int min=array[0,0];
            for(int i=0;i<array.GetLength(0);i++)
            {
                for(int j = 0;j<array.GetLength(1);j++)
                {
                    if(min>array[i,j])
                    {
                        min = array[i,j];
                    }
                }
            }
            return min;
        }
    }
}
