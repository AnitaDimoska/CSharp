using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public class ProductServices
    {
        public ProductServices()
        {

        }
        public Food CreateFood(int id, string name, ProductType type, double price, Taste taste, int calories)
        {
            Food newFood = new Food(id, name, type, price, taste, calories);
            return newFood;
        }
        public Drink CreateDrink(int id, string name, ProductType type, double price, double liters)
        {
            Drink newDrink = new Drink(id, name, type, price, liters);
            return newDrink;
        }
        public Electronics CreateElectronics(int id, string name, ProductType type, double price, double voltage)
        {
            Electronics newElectronics = new Electronics(id, name, type, price, voltage);
            return newElectronics;
        }
        public Product[] GetproductsByType(Product[] products, ProductType type)
        {
            Product[] newproduct = new Product[0];
            foreach (var product in products)
            {
                if (product.Type == type)
                {
                    Array.Resize(ref newproduct, newproduct.Length + 1);
                    newproduct[newproduct.Length - 1] = product;
                }
            }
            return newproduct;
        }
        public void AddProductsToArray(Product[] products, Product prod)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = prod;
            Console.WriteLine("There are some new products in the list:");
            foreach(var product in products)
            {
                Console.WriteLine($"{prod.Name}");
            }
        }

        public void EditProductInArray(Product[] products, int id, string newname)
        {
            foreach(var product in products)
            {
                if (product.Id == id)
                {
                    product.Name = newname;
                }
            }
            Console.WriteLine($"The product {newname} is edited.");
        }
    }
}
