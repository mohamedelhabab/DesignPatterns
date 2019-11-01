using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Employee
    {
        //Address Information
        public string StreetAddress, PostCode, City;

        //Employment Information
        public string CompanyName, Position;
        public double AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}," +
                   $" {nameof(PostCode)}: {PostCode}," +
                   $" {nameof(City)}: {City}," +
                   $" {nameof(CompanyName)}: {CompanyName}," +
                   $" {nameof(Position)}: {Position}," +
                   $" {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }
}
