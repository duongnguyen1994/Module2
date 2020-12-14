namespace CreateClassAnimal
{
    public abstract class Animal
    {
        protected string weight{get;set;}
        protected string height{get;set;}
        public Animal(string _weight, string _height)
        {
            weight = _weight;
            height = _height;
        }
        public abstract void PrintInfo();
    }
}