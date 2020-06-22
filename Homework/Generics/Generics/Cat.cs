using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Cat : Pet
    {
        public Cat(string name, Type type, int age, bool lazy, int livesLeft) : base(name, type, age)
        {
            Lazy = lazy;
            Livesleft = livesLeft;
        }
        public bool Lazy { get; set; }
        public int Livesleft { get; set; }

        public override string PrintInfo()
        {
            return $"The {Type} name is {Name}, age: {Age}, is it lazy: {Lazy}, lives left: {Livesleft}";
        }
    }
}
