using System;

namespace ProductManagement
{
    public class Shop
    {
        public Product[] ProductList = new Product[0];
        public void AddProduct(string name, string description, double price)
        {
            Array.Resize(ref ProductList, ProductList.Length+1);
            ProductList[ProductList.Length-1] = new Product(name, description, price);
        }
        public bool RemoveProduct(string name)
        {
            int count = 0;
            for(int i = 0; i<ProductList.Length;i++)
            {
                if(name == ProductList[i].Name)
                {
                    for(int j = i;j<ProductList.Length-1;j++)
                    {
                        ProductList[j]=ProductList[j+1];
                        count++;
                    }
                    Array.Resize(ref ProductList, ProductList.Length -1);
                }
            }
            if(count>0)
            {
                return true;
            }else
            return false;  
        }
        public string IterateProductList(string name)
        {
            for(int i = 0;i<ProductList.Length;i++)
            {
                if(name==ProductList[i].Name)
                {
                    return ProductList[i].ViewInfo();
                }
            }
            return $"{name} does not exist!";
        }
        public void SearchProduct(double min, double max)
        {
            int count = 0;
            for(int i = 0;i<ProductList.Length;i++)
            {
                if(ProductList[i].Price>=min && ProductList[i].Price<=max)
                {
                    Console.WriteLine(ProductList[i].ViewInfo());
                    count++;
                }
            }
            if(count==0)
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}