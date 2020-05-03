using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Product
    { 
        public Product()
        {

        }
        public Product(int id, string name, ProductType type, double price)
        {
            Id = id;
            Name = name;
            Type = type;
            Price = price;
            OnPromotion = false;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public double Price { get; set; }
        public bool OnPromotion { get; set; }

        public virtual void PrintInfoOfProduct()
        {
            Console.WriteLine($"The product is {Name}, {Type}, and the price is {Price}.");
        }
        public double GetPrice()
        {
            return Price;
        }
        public virtual void SetPrice(double price)
        {
            price = Price;
            Console.WriteLine($"The new price of the product {Name} is {price}");
        }
    }
}
