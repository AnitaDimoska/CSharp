using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public abstract class Pet
    {
        public Pet(string name, Type type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public string Name { get; set; }
        public Type Type { get; set; }
        public int Age { get; set; }

        public abstract string PrintInfo();
    }
}
