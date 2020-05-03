using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Food : Product
    {
        public Food(int id, string name, TypeProduct type, double price, Taste taste, int calories) : base(id, name, type, price)
        {
            Taste = taste;
            Calories = calories;
        }
        public Taste Taste { get; set; }
        public int Calories { get; set; }
        public override void PrintInfoOfProduct()
        {
            base.PrintInfoOfProduct();
        }
        public override void SetPrice(double price)
        {
            base.SetPrice(price);
        }
        public void ShowCalories()
        {
            Console.WriteLine($"{Name} has {Calories} calories.");
        }
    }
}
