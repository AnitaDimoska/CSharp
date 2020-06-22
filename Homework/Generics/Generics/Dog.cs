using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Dog : Pet
    {
        public Dog(string name, Type type, int age, bool goodBoy, string favouriteFood): base(name, type, age)
        {
            GoodBoi = goodBoy;
            FavouriteFood = favouriteFood;
        }
        public bool GoodBoi { get; set; }
        public string FavouriteFood { get; set; }
        public override string PrintInfo()
        {
            return $"Dog info: {Name}, {Age} years old, is it a good boy: {GoodBoi}, favourite food: {FavouriteFood}";
        } 
    }
}
