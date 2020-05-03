using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Finance: Employee
    {
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
