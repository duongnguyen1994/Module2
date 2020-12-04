using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if(number<2){
                Console.WriteLine($"{number} is not a prime");
            }
            else{
                bool check = true;
                for(int i =2;i<Math.Sqrt(number);i++){
                    if(number%i==0){
                        check = false;
                        break;
                    }
                }
                if(check){
                    Console.WriteLine($"{number} is a prime");
                }
                else{
                    Console.WriteLine($"{number} is not a prime");
                }
            }
        }
    }
}