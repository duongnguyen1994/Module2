using System;

namespace numberToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            if(number>=0 && number<=10)
            {
                switch(number)
                {
                    case 0: Console.WriteLine("zero");
                    break;
                    case 1: Console.WriteLine("one");
                    break;
                    case 2: Console.WriteLine("two");
                    break;
                    case 3: Console.WriteLine("three");
                    break;
                    case 4: Console.WriteLine("four");
                    break;
                    case 5: Console.WriteLine("five");
                    break;
                    case 6: Console.WriteLine("six");
                    break;
                    case 7: Console.WriteLine("seven");
                    break;
                    case 8: Console.WriteLine("eight");
                    break;
                    case 9: Console.WriteLine("nine");
                    break;
                    case 10: Console.WriteLine("ten");
                    break;
                }
            }
            else if(number<20)
            {
                switch(number)
                {
                    case 11: Console.WriteLine("eleven");
                    break;
                    case 12: Console.WriteLine("twelve");
                    break;
                    case 13: Console.WriteLine("thirteen");
                    break;
                    case 14: Console.WriteLine("fourteen");
                    break;
                    case 15: Console.WriteLine("fifteen");
                    break;
                    case 16: Console.WriteLine("sixteen");
                    break;
                    case 17: Console.WriteLine("seventeen");
                    break;
                    case 18: Console.WriteLine("eighteen");
                    break;
                    case 19: Console.WriteLine("nineteen");
                    break;
                }
            }
            else if(number<100)
            {
                switch(Math.Floor(number/10))
                {
                    case 2: Console.Write("twenty ");
                    break;
                    case 3: Console.Write("thirty ");
                    break;
                    case 4: Console.Write("fourty ");
                    break;
                    case 5: Console.Write("fifty ");
                    break;
                    case 6: Console.Write("sixty ");
                    break;
                    case 7: Console.Write("seventy ");
                    break;
                    case 8: Console.Write("eighty ");
                    break;
                    case 9: Console.Write("ninety ");
                    break;
                }
                switch(number%10)
                {
                    case 1: Console.Write("one");
                    break;
                    case 2: Console.Write("two");
                    break;
                    case 3: Console.Write("three");
                    break;
                    case 4: Console.Write("four");
                    break;
                    case 5: Console.Write("five");
                    break;
                    case 6: Console.Write("six");
                    break;
                    case 7: Console.Write("seven");
                    break;
                    case 8: Console.Write("eight");
                    break;
                    case 9: Console.Write("nine");
                    break;
                }   
            }
            else if(number<1000)
            {
                switch(Math.Floor(number/100))
                {
                    case 1: Console.Write("one hundred ");
                    break;
                    case 2: Console.Write("two hundred ");
                    break;
                    case 3: Console.Write("three hundred ");
                    break;
                    case 4: Console.Write("four hundred ");
                    break;
                    case 5: Console.Write("five hundred ");
                    break;
                    case 6: Console.Write("six hundred ");
                    break;
                    case 7: Console.Write("seven hundred ");
                    break;
                    case 8: Console.Write("eight hundred ");
                    break;
                    case 9: Console.Write("nine hundred ");
                    break;
                }
                if(Math.Floor(number/10)%10 ==1)
                {
                    switch(number%10)
                    {
                        case 0: Console.Write("ten");
                        break;
                        case 1: Console.Write("eleven");
                        break;
                        case 2: Console.Write("twelve");
                        break;
                        case 3: Console.Write("thirteen");
                        break;
                        case 4: Console.Write("fourteen");
                        break;
                        case 5: Console.Write("fifteen");
                        break;
                        case 6: Console.Write("sixteen");
                        break;
                        case 7: Console.Write("seventeen");
                        break;
                        case 8: Console.Write("eighteen");
                        break;
                        case 9: Console.Write("nineteen");
                        break;
                    }
                }
                else
                {
                    switch(Math.Floor(number/10)%10)
                    {
                        case 0: Console.Write("");
                        break;
                        case 2: Console.Write("and twenty");
                        break;
                        case 3: Console.Write("and thirty");
                        break;
                        case 4: Console.Write("and fourty");
                        break;
                        case 5: Console.Write("and fifty");
                        break;
                        case 6: Console.Write("and sixty");
                        break;
                        case 7: Console.Write("and seventy");
                        break;
                        case 8: Console.Write("and eighty");
                        break;
                        case 9: Console.Write("and ninety");
                        break;
                    }
                    switch(number%10)
                    {
                        case 0: Console.Write("");
                        break;
                        case 1: Console.Write("one");
                        break;
                        case 2: Console.Write("two");
                        break;
                        case 3: Console.Write("three");
                        break;
                        case 4: Console.Write("four");
                        break;
                        case 5: Console.Write("five");
                        break;
                        case 6: Console.Write("six");
                        break;
                        case 7: Console.Write("seven");
                        break;
                        case 8: Console.Write("eight");
                        break;
                        case 9: Console.Write("nine");
                        break;
                    } 
                }   
            }
        }
    }
}
