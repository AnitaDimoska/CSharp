using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ManagerBonus : Employee
    {
        public ManagerBonus(int id, string firstName, string lastName, Role role, int hours, double salary) : base(id, firstName, lastName, role, hours, salary)
        {
            Role = Role.Menager;
        }
        private double Bonus { get; set; }
        public double AddBonus(double bonus)
        {
            Bonus = bonus;
            return Bonus;
        }
        public override double GetSalary()
        {
            double total = Salary + Bonus;
            return total;
        }
    }
}
