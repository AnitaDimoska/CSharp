using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousFunc
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }
        public Dog(string name, string color, int age, string owner)
        {
            Name = name;
            Color = color;
            Age = age;
            Owner = owner;
        }
    }
}
