using System;

namespace dayofmonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month) 
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: Console.WriteLine("This month has 31 days");
                break;
                case 2: Console.WriteLine("This month has 28 or 29 days");
                break;
                case 4:
                case 6:
                case 9:
                case 11: Console.WriteLine("This month has 30 days");
                break;
                default: Console.WriteLine($"{month} is not a month of year");
                break;
            }
        }
    }
}
