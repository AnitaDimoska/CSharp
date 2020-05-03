using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Domain
{
    public class Contractor : Employee
    {
        public Contractor(int id, string firstName, string lastName, Role role, int hours, double salary, double workHours, int payPerHour, Manager responsible) : base(id, firstName, lastName, role, hours, salary)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }
        public override double GetSalary()
        {
            var newSalary = WorkHours * PayPerHour;
            Salary = newSalary;
            return Salary;
        }
        public DepartmentType CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}
