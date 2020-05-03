using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(int id, string firstName, string lastName, Role role, int hours, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Hours = hours;
            Salary = salary;
            OnHoliday = false;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public int Hours { get; set; }
        public double Salary { get; set; } //per Hour
        public bool OnHoliday { get; set; }

        public virtual string PrintInfo()
        {
            return $"{FirstName} {LastName}, {Salary}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double salary)
        {
            Salary = salary;
            Console.WriteLine($"The new salary of the employee {FirstName} {LastName} is {salary}$");
        }
        public void GoOnHoliday()
        {
            OnHoliday = true;
            Console.WriteLine($"Employee {FirstName}{LastName} is going on a holiday.");
        }
    }
}
