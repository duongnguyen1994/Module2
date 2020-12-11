using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix arr = new Matrix();
            int choice = 0;
            int row =0;
            int col =0;
            bool checkChoice = true;
            bool checkCreateMatrix = false;
            bool checkCase78 = true;
            int[,] matrix = new int[row,col];
            do
            {
                Menu();
                checkChoice = int.TryParse(Console.ReadLine(), out choice);
                if(choice==1)
                {
                    checkCreateMatrix =true;
                }
                if(checkCreateMatrix)
                {
                    switch(choice)
                    {
                        case 1:
                        bool checkRow = true;
                        bool checkCol = true;
                        do
                        {
                            Console.WriteLine("Enter Row:");
                            checkRow = int.TryParse(Console.ReadLine(), out row);
                            Console.WriteLine("Enter Column:");
                            checkCol = int.TryParse(Console.ReadLine(), out col);
                        }while(!checkCol||!checkRow||row<=0||col<=0);  
                        arr = new Matrix(row, col);
                        matrix = arr.matrix;
                        break;
                        case 2:
                        arr.Display();
                        break;
                        case 3:
                        Console.WriteLine($"Total of value = {arr.GetTotalValue()}");
                        break;
                        case 4:
                        Console.WriteLine($"Total of prime = {arr.CountPrime()}");
                        break;
                        case 5:
                        Console.WriteLine($"Total of odd = {arr.CountOdd()}");
                        break;
                        case 6:
                        Console.WriteLine($"Total of border = {arr.GetTotalBorder()}");
                        break;
                        case 7:
                        int indexRow = 0;
                        do
                        {
                            Console.WriteLine("Enter index of row");
                            checkCase78 = int.TryParse(Console.ReadLine(), out indexRow);
                            if(indexRow>matrix.GetLength(0))
                            {
                                Console.WriteLine($"Index of matrix's row max = {matrix.GetLength(0)-1}");
                            }
                        }while(!checkCase78||indexRow>=matrix.GetLength(0));
                        Console.WriteLine($"Product of row = {arr.ProductRow(indexRow)}");
                        break;
                        case 8:
                        int indexCol = 0;
                        do
                        {
                            Console.WriteLine("Enter index of column");
                            checkCase78 = int.TryParse(Console.ReadLine(), out indexCol);
                            if(indexCol>matrix.GetLength(1))
                            {
                                Console.WriteLine($"Index of matrix's column max = {matrix.GetLength(1)-1}");
                            }
                        }while(!checkCase78||indexCol>=matrix.GetLength(1));
                        Console.WriteLine($"Product of row = {arr.ProductRow(indexCol)}");
                        break;
                        default:
                        Environment.Exit(0);
                        break;
                    }
                }else
                {
                    Console.WriteLine("Create matrix first!");
                }
            }while(!checkChoice||choice != 0);
        }
        static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("\n1. Create a matrix");
            Console.WriteLine("2. Display a matrix");
            Console.WriteLine("3. Get total of matrix's value");
            Console.WriteLine("4. Count Prime");
            Console.WriteLine("5. Count Odd");
            Console.WriteLine("6. Get total of border's value");
            Console.WriteLine("7. Get product of row's value");
            Console.WriteLine("8. Get product of col's value");
            Console.WriteLine("0. Exit");
        }
    }
}
