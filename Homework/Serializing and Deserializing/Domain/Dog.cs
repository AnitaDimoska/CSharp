using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Domain
{
    public class Dog
    {
        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
    }

}
