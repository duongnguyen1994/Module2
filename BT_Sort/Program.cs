using System;
using System.Text;

namespace BT_Sort
{
    class Program
    {
        static int[] array = new int[0];
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice = 0;
            bool checkNumber = true;
            bool IsValidArray = false;
            while(choice!=5)
            {
                do
                {
                    Menu();
                    checkNumber = int.TryParse(Console.ReadLine(), out choice);
                } while (!checkNumber || choice < 1 || choice > 6);
                switch (choice)
                {
                    case 1:
                        int size = 0;                       
                        do
                        {
                            Console.Write("Enter size of array: ");
                            checkNumber = int.TryParse(Console.ReadLine(), out size);
                        } while (!checkNumber || size < 1 || size > 10000);
                        array = CreateArray(size);
                        Console.WriteLine("Array: ");
                        ShowArray();
                        IsValidArray = true;
                        break;

                    case 2:
                        if (IsValidArray)
                        {
                            if (IsSymmetryArray())
                            {
                                Console.WriteLine("This array is a symmetry array");
                            }
                            else
                                Console.WriteLine("This array is not a symmetry array");
                        }
                        else
                            Console.WriteLine("Create array first!");
                        break;
                    case 3:
                        if(IsValidArray)
                        {
                            SelectionSort();
                            ShowArray();
                        }
                        else
                            Console.WriteLine("Create array first!");
                        break;
                    case 4:
                        if(IsValidArray)
                        {
                            int value = 0;
                            Console.Write("Enter value: ");
                            do
                            {
                                checkNumber = int.TryParse(Console.ReadLine(), out value);
                            } while (!checkNumber);
                            Console.WriteLine(Find(value));
                        }
                        else
                            Console.WriteLine("Create array first!");
                        break;
                    case 5:
                        Environment.Exit(5);
                        break;
                }
                Console.ReadKey();
            }         
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Tạo mảng");
            Console.WriteLine("2. Kiểm tra mảng đối xứng");
            Console.WriteLine("3. Sắp xếp mảng");
            Console.WriteLine("4. Tìm kiếm mảng");
            Console.WriteLine("5. Thoát");
        }
        static int[] CreateArray(int size)
        {
            Random r = new Random();
            int[] array = new int[size];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(30, 60);
            }
            return array;
        }
        static bool IsSymmetryArray()
        {
            for(int i = 0;i<array.Length/2;i++)
            {
                if(array[i] != array[array.Length-i-1])
                {
                    return false;
                }
            }
            return true;
        }
        static void SelectionSort()
        {          
            for(int i = 0;i<array.Length-1;i++)
            { 
                int min = array[i];
                int indexOfMin = i;
                for (int j = i+1;j<array.Length;j++)
                {
                    if(array[j]<min)
                    {
                        min = array[j];
                        indexOfMin = j;
                    }
                }
                if (indexOfMin != i)
                {
                    array[indexOfMin] = array[i];
                    array[i] = min;
                }
                else
                    break;
            }
            Console.WriteLine("This array was sorted!");
        }
        static string Find(int number)
        {
            if(CheckSort())
            {
                int low = 0;
                int high = array.Length - 1;
                while (high >= low)
                {
                    int mid = (high + low) / 2;
                    if (number == array[mid])
                    {
                        return $"Index: {mid}";
                    }
                    else if (number > array[mid])
                    {
                        low = mid + 1;
                    }
                    else
                        high = mid - 1;
                }
                return "Not found!";
            }
            return "Please sort this array before find!";          
        }
        static bool CheckSort()
        {
            for(int i =0;i<array.Length-1;i++)
            {
                if(array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void ShowArray()
        {
            foreach(int items in array)
            {
                Console.Write($"{items} ");
            }    
        }
    }
}
