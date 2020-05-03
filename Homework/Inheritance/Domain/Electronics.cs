using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Electronics : Product
    {
        public Electronics(int id, string name, TypeProduct type, double price, double voltage) : base(id, name, type, price)
        {
            Voltage = voltage;
        }

        public double Voltage { get; set; }
        public override void PrintInfoOfProduct()
        {
            base.PrintInfoOfProduct();
        }
        public override void SetPrice(double price)
        {
            base.SetPrice(price);
        }
        public void TurnOn()
        {
            Console.WriteLine($"The product {Name} is working.");
        }
    }
}
