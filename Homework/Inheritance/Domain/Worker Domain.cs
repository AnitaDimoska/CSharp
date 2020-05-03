using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Worker : Employee
    {
        public Manager Manager { get; set; }
        public static Worker[] worker { get; set; }

        public Worker() : base()
        {

        }
        public Worker(int id, string firstName, string lastName, Role role, int hours, double salary, Manager manager) : base(id, firstName, lastName, role, hours, salary)
        {
            Manager = manager;
        }
        public override string PrintInfo()
        {
            double salaryPerDay = Salary * Hours;
            return $"{FirstName} {LastName}, salary per day is {salaryPerDay}$";
        }
    }
}