using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models;

namespace DesignPatterns.GangOfFour.Creational.Builder
{
    //Facade Class 
    public class EmployeeBuilder
    {
        //reference!
        protected Employee emp = new Employee();

        public  EmployeeAddressBuilder Address => new EmployeeAddressBuilder(emp);
        public EmployeeJobBuilder Employement => new EmployeeJobBuilder(emp);

        public static implicit operator Employee(EmployeeBuilder empJobBuilder)
        {
           return empJobBuilder.emp;
        }

    }
}
