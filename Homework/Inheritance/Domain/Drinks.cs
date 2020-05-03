using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Drink : Product
    {
        public Drink(int id, string name, TypeProduct type, double price, double liters) : base(id, name, type, price)
        {
            Liters = liters;
            isAlcohol = false;
        }
        public double Liters { get; set; }
        public bool isAlcohol { get; set; }

        public override void PrintInfoOfProduct()
        {
            base.PrintInfoOfProduct();
        }
        public override void SetPrice(double price)
        {
            base.SetPrice(price);
        }
        public void OpenBottle(bool isOpen)
        {
            if (isOpen == true)
                Console.WriteLine($"The bottle of {Name} is opened.");
            else
                Console.WriteLine($"The bottle of {Name} is not open yet.");
        }
    }
}
