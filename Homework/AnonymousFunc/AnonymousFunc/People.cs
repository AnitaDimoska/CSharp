using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousFunc
{
    public class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public List<Dog> Dogs { get; set; }
        public Person()
        {

        }
        public Person(string firstname, int age, List<Dog> dogs)
        {
            FirstName = firstname;
            Dogs = dogs;
            Age = age;
        }
    }
}
