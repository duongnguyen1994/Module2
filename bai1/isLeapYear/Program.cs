using System;

namespace isLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
           int year;
           bool check = true;
           Console.WriteLine("Enter a year: ");
           year = int.Parse(Console.ReadLine());
           if(year%4==0)
           {
               if(year%100==0)
               {
                   if(year%400 ==0)
                   {
                       check = true;
                   }
               }
               else check = true;
           }
           else check = false;
           if(check)
           {
               Console.WriteLine($"{year} is a leap year");
           }
           else
           {
               Console.WriteLine($"{year} is not a leap year");
           }
        }
    }
}
