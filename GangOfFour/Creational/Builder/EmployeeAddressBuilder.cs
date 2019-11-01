using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models;

namespace DesignPatterns.GangOfFour.Creational.Builder
{
    public class EmployeeAddressBuilder : EmployeeBuilder
    {
        public EmployeeAddressBuilder(Employee employee)
        {
            emp = employee;
        }

        public EmployeeAddressBuilder SetAddress(string company)
        {
            emp.CompanyName = company;
            return this;
        }
        public EmployeeAddressBuilder SetPostCode(string company)
        {
            emp.CompanyName = company;
            return this;
        }
        public EmployeeAddressBuilder SetCity(string company)
        {
            emp.CompanyName = company;
            return this;
        }
    }
}
