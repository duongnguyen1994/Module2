using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 9;
            int row = 0;
            int col = 0;
            int[,] matrix = new int[row, col];
            bool checkChoice = true;
            bool checkCreateMatrix = false;
            bool checkCase78 = true;
            while (choice != 0)
            {
                do
                {
                    Menu();
                    checkChoice = int.TryParse(Console.ReadLine(), out choice);
                } while (!checkChoice || choice < 0 || choice > 9);
                if (choice == 1)
                {
                    checkCreateMatrix = true;
                }
                if (checkCreateMatrix== true && choice !=0)
                {
                    switch (choice)
                    {
                        case 1:
                            bool checkRow = true;
                            bool checkCol = true;
                            row = 0;
                            col = 0;
                            do
                            {
                                Console.WriteLine("Enter row");
                                checkRow = int.TryParse(Console.ReadLine(), out row);
                                Console.WriteLine("Enter col");
                                checkCol = int.TryParse(Console.ReadLine(), out col);
                                if (row > 10 || col > 10)
                                {
                                    Console.WriteLine("Too large");
                                }
                            } while (!checkRow || !checkCol || row > 10 || col > 10 || row < 1 || col < 1);
                            matrix = Matrix(row, col);
                            break;
                        case 2:
                            Console.WriteLine("Matrix:");
                            Display(matrix);
                            break;
                        case 3:
                            Console.WriteLine($"Sum of matrix's value = {Total(matrix)}");
                            break;
                        case 4:
                            Console.WriteLine($"Matrix has {CountPrime(matrix)} prime(s)");
                            break;
                        case 5:
                            Console.WriteLine($"Matrix has {CountOdd(matrix)} odd");
                            break;
                        case 6:
                            Console.WriteLine($"Sum of matrix's border = {SumOfBorder(matrix)}");
                            break;
                        case 7:
                            int indexRow;
                            do
                            {
                                Console.WriteLine("Enter index of row:");
                                checkCase78 = int.TryParse(Console.ReadLine(), out indexRow);
                            } while (!checkCase78 || indexRow >= matrix.GetLength(0) || indexRow < 0);
                            Console.WriteLine($"Product of matrix's row at {indexRow} = {ProductOfRow(matrix, indexRow)}");
                            break;
                        case 8:
                            int indexCol;
                            do
                            {
                                Console.WriteLine("Enter index of col:");
                                checkCase78 = int.TryParse(Console.ReadLine(), out indexCol);
                            } while (!checkCase78 || indexCol >= matrix.GetLength(1) || indexCol < 0);
                            Console.WriteLine($"Product of matrix's column at {indexCol} = {ProductOfCol(matrix, indexCol)}");
                            break;
                    }
                }
                else if(choice ==0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\n\nCreate matrix first!");
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("\n1. Create matrix");
            Console.WriteLine("2. Display matrix");
            Console.WriteLine("3. Sum of matrix's value");
            Console.WriteLine("4. Prime in matrix");
            Console.WriteLine("5. Odd in matrix");
            Console.WriteLine("6. Sum of matrix border");
            Console.WriteLine("7. Product of matrix's row");
            Console.WriteLine("8. Product of matrix's column");
            Console.WriteLine("0. Exit");
        }
        static int[,] Matrix(int row, int column)
        {
            int[,] matrix = new int[row, column];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = r.Next(10, 101);
                }
            }
            return matrix;
        }
        static void Display(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static int Total(int[,] matrix)
        {
            int total = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    total += matrix[i, j];
                }
            }
            return total;
        }
        static bool CheckPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int CountPrime(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (CheckPrime(matrix[i, j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static bool CheckOdd(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
                return true;
        }
        static int CountOdd(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (CheckOdd(matrix[i, j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int SumOfBorder(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, 0] + matrix[i,matrix.GetLength(1) - 1];
            }
            for (int j = 1; j < matrix.GetLength(1) - 1; j++)
            {
                sum += matrix[0, j] + matrix[matrix.GetLength(0) - 1, j];
            }
            return sum;
        }
        static int ProductOfRow(int[,] matrix, int RowIndex)
        {
            int product = 1;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                product *= matrix[RowIndex, i];
            }
            return product;
        }
        static int ProductOfCol(int[,] matrix, int ColumnIndex)
        {
            int product = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                product *= matrix[i, ColumnIndex];
            }
            return product;
        }
    }
}
