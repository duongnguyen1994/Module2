using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"D:\codegym\Module2\bai15\HomeWork\Data";
            string input = "input.txt";
            string output = "output.txt";
            int sizeMatrix = 5;
            int[,] inputMatrix = new int[sizeMatrix, sizeMatrix];

            using (StreamWriter sw = new StreamWriter($@"{path}\{input}"))
            {
                int[,] matrix = CreateMatrix(sizeMatrix);
                sw.Write(DrawMatrix(matrix));
            }

            using (StreamReader sr = new StreamReader($@"{path}\{input}"))
            {
                string line;
                string[] temp;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {           
                    temp = line.Trim().Split(' ');
                    for(int i=0;i<temp.Length;i++)
                    {
                        inputMatrix[count, i] = int.Parse(temp[i]);
                    }
                    count++;
                }
            }

            using (StreamWriter sw = new StreamWriter($@"{path}\{output}"))
            {
                sw.WriteLine($"Even count = {CountEven(inputMatrix)}");
                sw.WriteLine($"Total of main diagonal: {GetSumMainDiagonal(inputMatrix)}");
                sw.WriteLine($"Total of extra diagonal: {GetSumExtraDiagonal(inputMatrix)}");
                sw.WriteLine($"Total of border line: {GetSumOfBorder(inputMatrix)}");
                sw.WriteLine($"Show bot triangle: ");
                sw.Write(ShowBotTriangle(inputMatrix));
                sw.WriteLine($"Show top triangle: ");
                sw.Write(ShowTopTriangle(inputMatrix));
            }
        }

        static int[,] CreateMatrix(int size)
        {
            Random r = new Random();
            int[,] matrix = new int[size, size];

            for(int i =0;i<matrix.GetLength(0);i++)
            {
                for(int j =0;j<matrix.GetLength(1);j++)
                {
                    matrix[i, j] = r.Next(1, 9);
                }
            }
            return matrix;
        }

        static int CountEven(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j]%2==0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static int GetSumMainDiagonal(int[,] matrix)
        {
            int sum = 0;
            for(int i =0;i<matrix.GetLength(0);i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }

        static int GetSumExtraDiagonal(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0;i<matrix.GetLength(0);i++)
            {
                sum += matrix[matrix.GetLength(0) - i - 1, i];
            }
            return sum;
        }

        static int GetSumOfBorder(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0;i<matrix.GetLength(0);i++)
            {
                sum += matrix[i, 0];
                sum += matrix[i, matrix.GetLength(1) - 1];
            }  
            for(int i = 1;i<matrix.GetLength(1)-1;i++)
            {
                sum += matrix[0, i];
                sum += matrix[matrix.GetLength(0) - 1, i];
            }
            return sum;
        }

        static string DrawMatrix(int[,] matrix)
        {
            string result = "";
            for(int i = 0;i<matrix.GetLength(0);i++)
            {
                for(int j = 0;j<matrix.GetLength(1);j++)
                {
                    result += $"{matrix[i, j]} ";
                }
                result += "\n";
            }
            return result;
        }

        static string ShowBotTriangle(int[,] matrix)
        {
            string result = "";
            for(int i = 0;i<matrix.GetLength(0);i++)
            {
                for(int j =0;j<=i;j++)
                {
                    result+= $"{matrix[i, j]} ";
                }
                result += "\n";
            }
            return result;
        }

        static string ShowTopTriangle(int[,] matrix)
        {
            string result = "";
            for(int i =0;i<matrix.GetLength(0);i++)
            {
                for(int z = 0;z<i;z++)
                {
                    result+="  ";
                }
                for (int j = i;j<matrix.GetLength(1);j++)
                {
                    result += $"{matrix[i, j]} ";
                }
                result+="\n";
            }
            return result;
        }
    }
}
