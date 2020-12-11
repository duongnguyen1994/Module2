namespace ProductManagement
{
    public class Product
    {
        private string name;
        public string Name => name;
        private string description;
        private double price;
        public double Price => price;
        private int[] rate = new int[0];
        public Product(string name, string description, double price)
        {
            this.name=name;
            this.description = description;
            this.price = price;
        }
        public string ViewInfo()
        {
            return $"{name}\t\t{description}\t\t{price}\t\t{CalculateRate()}";
        }
        private double CalculateRate()
        {
            double total = 0;
            for(int i = 0;i<rate.Length;i++)
            {
                total += rate[i];
            }
            return total;
        }
    }
}