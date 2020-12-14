namespace CreateClassAnimal
{
    class Cat : Animal
    {
        private string Name{get;set;}
        public Cat(string weight, string height, string name):base(weight,height)
        {
            Name = name;
        }
        public override void PrintInfo()
        {
            System.Console.WriteLine($"Weight: {weight}\nHeight: {height}\nName: {Name}");
        }
    }
}