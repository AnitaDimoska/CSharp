using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
   public class Fish : Pet
    {
        public Fish(string name, Type type, int age, string color, double size) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }
        public string Color { get; set; }
        public double Size { get; set; }

        public override string PrintInfo()
        {
            return $"The {Type} {Name} is {Age} years old, is {Color}, and the size is {Size}";
        }
    }
}
