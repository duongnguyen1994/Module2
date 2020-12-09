using System;

namespace QuadraticEquation
{
    public class QuadraticEquation
    {
        private double a, b, c;
        public QuadraticEquation(){}
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetterA
        {
            get{return this.a;}
            set {a = value;}
        }

        public double GetterB
        {
            get {return this.b;}
            set {b = value;}
        }

        public double GetterC
        {
            get {return this.c;}
            set {c = value;}
        }

        public double GetDiscriminant()
        {
            return Math.Pow(this.b, 2) - 4 * this.a * this.c;
        }

        public double GetRoot1()
        {
            return (-this.b + Math.Sqrt(Math.Pow(this.b, 2) - 4*this.a*this.c)) / (2 * this.a);
        }

        public double GetRoot2()
        {
            return (-this.b - Math.Sqrt(Math.Pow(this.b, 2) - 4*this.a*this.c)) / (2 * this.a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool checka = true;
            bool checkb = true;
            bool checkc = true;
            double a;
            double b;
            double c;
            double delta;
            do
            {
                Console.WriteLine("Enter a:");
                checka = double.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("Enter b:");
                checkb = double.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("Enter c:");
                checkc = double.TryParse(Console.ReadLine(), out c);
            }while(!checka||!checkb||!checkc);
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            quadraticEquation.GetterA = a;
            quadraticEquation.GetterB = b;
            quadraticEquation.GetterC = c;
            delta = quadraticEquation.GetDiscriminant();
            if(delta>0)
            {
                Console.WriteLine("This Equation has 2 roots:");
                Console.WriteLine($"Root 1 = {quadraticEquation.GetRoot1()}");
                Console.WriteLine($"Root 2 = {quadraticEquation.GetRoot2()}");
            }
            else if(delta == 0)
            {
                Console.WriteLine("This Equation has double root:");
                Console.WriteLine($"Root 1 = Root 2 = {-b/(2*a)}");
            }
            else
            {
                Console.WriteLine("This Equation has no root!");
            }
        }
    }
}
