using System;

namespace HomeWork
{
    public class Matrix
    {
        public int[,] matrix = new int[0,0];
        public Matrix(){}
        public Matrix(int row, int col)
        {
            GetMatrix(row, col);
        }
        public void GetMatrix(int row, int col)
        {
            matrix = new int[row,col];
            Random r = new Random();
            for(int i =0; i<row;i++)
            {
                for(int j = 0; j< col;j++)
                {
                    matrix[i,j] = r.Next(10,101);
                }
            }
        }
        public void Display()
        {
            for(int i = 0; i<matrix.GetLength(0);i++)
            {
                for(int j = 0; j<matrix.GetLength(1);j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        public int GetTotalValue()
        {
            int sum = 0;
            for(int i = 0; i<matrix.GetLength(0);i++)
            {
                for(int j = 0; j<matrix.GetLength(1);j++)
                {
                    sum += matrix[i,j];
                }
            }
            return sum;
        }
        private bool CheckPrime(int number)
        {
            for(int i = 2;i<number;i++)
            {
                if(number%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        public int CountPrime()
        {
            int count = 0;
            for(int i = 0; i<matrix.GetLength(0);i++)
            {
                for(int j = 0; j<matrix.GetLength(1);j++)
                {
                    if(CheckPrime(matrix[i,j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private bool CheckOdd(int number)
        {
            if(number%2==0)
            {
                return false;
            }
            else 
            return true;
        }
        public int CountOdd()
        {
            int count = 0;
            for(int i = 0; i<matrix.GetLength(0);i++)
            {
                for(int j = 0; j<matrix.GetLength(1);j++)
                {
                    if(CheckOdd(matrix[i,j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int GetTotalBorder()
        {
            int sum = 0;
            for(int i =0;i<matrix.GetLength(0);i++)
            {
                sum += matrix[i,0]+matrix[i,matrix.GetLength(1)-1];
            }
            for(int j = 1;j<matrix.GetLength(1);j++)
            {
                sum += matrix[0,j]+matrix[matrix.GetLength(0)-1,j];
            }
            return sum;
        }
        public int ProductRow(int rowIndex)
        {
            int product = 1;
            for(int i = 0;i<matrix.GetLength(1);i++)
            {
                product *= matrix[rowIndex,i];
            }
            return product;
        }
        public int ProductCol(int colIndex)
        {
            int product = 1;
            for(int i =0;i<matrix.GetLength(0);i++)
            {
                product *= matrix[i,colIndex];
            }
            return product;
        }
    }
}