using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models;

namespace DesignPatterns.GangOfFour.Creational.Builder
{
    public class EmployeeJobBuilder : EmployeeBuilder
    {
        public EmployeeJobBuilder(Employee employee)
        {
            emp = employee;
        }
        public EmployeeJobBuilder WorksAt(string company)
        {
            emp.CompanyName = company;
            return this;
        }
        public EmployeeJobBuilder WorksAs(string job)
        {
            emp.Position = job;
            return this;
        }
        public EmployeeJobBuilder SetAnnualSalary(double annualSalary)
        {
            emp.AnnualIncome = annualSalary;
            return this;
        }
    }
}
