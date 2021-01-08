using System;
using System.Collections.Generic;
using System.IO;

namespace BaiTap8thang1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"D:\codegym\Module2\bai15\BaiTap8thang1\Data";
            string input = "InputData.txt";
            string output = "OutputData.txt";
            int row = 0;
            int col = 0;
            int[,] inputMatrix;

            using (StreamWriter sw = new StreamWriter($@"{path}\{input}"))
            {
                int[,] matrix = CreateMatrix(5, 9);
                sw.Write(ShowMatrix(matrix));
            }

            using (StreamReader sr = new StreamReader($@"{path}\{input}"))
            {
                string line = sr.ReadLine();
                string[] temp = line.Trim().Split(' ');
                row = int.Parse(temp[0]);
                col = int.Parse(temp[1]);
                inputMatrix = new int[row, col];
                int count = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    temp = line.Trim().Split();
                    for (int i= 0;i<temp.Length;i++)
                    {
                        inputMatrix[count, i] = int.Parse(temp[i]);
                    }
                    count++;
                }             
            }

            using (StreamWriter sw = new StreamWriter($@"{path}\{output}"))
            {
                sw.WriteLine($"Total of even = {GetTotalOfEven(inputMatrix)}");
                sw.WriteLine($"Total of border line = {GetTotalOfBorder(inputMatrix)}");
                int[,] matrixX3Value = GetMatrixX3Value(inputMatrix);
                sw.WriteLine($"New matrix: \n{ShowMatrix(matrixX3Value)}");
                sw.WriteLine(GetNumberTimes(inputMatrix));
            }
        }
        static int[,] CreateMatrix(int row, int col)
        {
            Random r = new Random();
            int[,] matrix = new int[row, col];

            for(int i =0;i<matrix.GetLength(0);i++)
            {
                for(int j =0;j<matrix.GetLength(1);j++)
                {
                    matrix[i, j] = r.Next(1, 9);
                }
            }

            return matrix;
        }
        static string ShowMatrix(int[,] matrix)
        {
            string result = $"{matrix.GetLength(0)} {matrix.GetLength(1)}\n";
            for(int i =0;i<matrix.GetLength(0);i++)
            {
                for(int j =0;j<matrix.GetLength(1);j++)
                {
                    result += $"{matrix[i, j]} ";
                }
                result += "\n";
            }
            return result;
        }
        static int GetTotalOfEven(int[,] matrix)
        {
            int sum = 0;
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j =0;j<matrix.GetLength(1);j++)
                {
                    if(matrix[i,j]%2!=0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum; 
        }
        static int GetTotalOfBorder(int[,] matrix)
        {
            int sum = 0;
            for(int i =0;i<matrix.GetLength(0);i++)
            {
                sum += matrix[i, 0];
                sum += matrix[i, matrix.GetLength(1) - 1];
            }
            for(int i =1;i<matrix.GetLength(1)-1;i++)
            {
                sum += matrix[0, i];
                sum += matrix[matrix.GetLength(0) - 1, i];
            }
            return sum;
        }
        static int[,] GetMatrixX3Value(int[,] matrix)
        {
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            int[,] newMatrix = new int[r, c];
            for(int i =0;i<r;i++)
            {
                for(int j = 0;j<c;j++)
                {
                    newMatrix[i, j] = matrix[i, j] * 3;
                }
            }
            return newMatrix;
        }

        static int CountNumber(int number, int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0;j<matrix.GetLength(1);j++)
                {
                    if(matrix[i,j] == number)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        
        static string GetNumberTimes(int[,] matrix)
        {
            string result = "";
            SortedList<int, int> list = new SortedList<int, int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!list.ContainsKey(matrix[i,j]))
                    {
                        list.Add(matrix[i, j],CountNumber(matrix[i,j],matrix));
                    }
                }
            }
            foreach(KeyValuePair<int, int> items in list)
            {
                result+=$"So:{items.Key} xuat hien {items.Value} lan\n";
            }
            return result;
        }
    }
}
