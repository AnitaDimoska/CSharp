using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Manager : Employee
    {
        public Worker[] Workers { get; set; }
        public Manager() : base()
        {

        }
        public Manager(int id, string firstName, string lastName, Role role, int hours, double salary, Worker[] workers) : base(id, firstName, lastName, role, hours, salary)
        {
            Workers = workers;
        }
        public override string PrintInfo()
        {
            double salaryPerDay = Salary * Hours;
            return $"{FirstName} {LastName}, salary per day is {salaryPerDay}$";
        }
        public override double GetSalary()
        {
            return Salary * Hours;
        }
    }
}
