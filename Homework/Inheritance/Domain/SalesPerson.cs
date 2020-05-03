using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Domain
{
    public class SalesPerson : Employee
    {
        public SalesPerson() : base()
        {

        }
        public SalesPerson(int id, string firstName, string lastName, Role role, int hours, double salary) : base(id, firstName, lastName, role, hours, salary)
        {
            Role = Role.Sales;
            Salary = 500.00;
        }
        private double SuccessSaleRevenue { get; set; }
        public double AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue = number;
            return SuccessSaleRevenue;
        }
        
        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                Salary += 500.00;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                Salary += 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                Salary += 1500;
            }
            return Salary;
        }
        
    }
}
