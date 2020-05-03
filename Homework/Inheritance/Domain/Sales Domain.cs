using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    class Sales : Employee
    {
        public Sales() : base()
        {

        }
        public Sales(int id, string firstName, string lastName, Role role, int hours, double salary, double bonus) : base(id, firstName, lastName, role, hours, salary)
        {
            Bonus = bonus;
        }
        double Bonus { get; set; }
        public override string PrintInfo()
        {
            double salaryPerDay = Salary * Hours;
            return $"{FirstName} {LastName}, salary per day is {salaryPerDay}$ and the bonus is {Bonus}";
        }
        public override double GetSalary()
        {
            return (Salary * Hours) + Bonus;
        }
    }
}
