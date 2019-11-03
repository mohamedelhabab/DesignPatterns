using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Address
    {
        public string StreetAddress;
        public string PostCode;
        public string City;

        public Address(string streetAddress, string postCode, string city)
        {
            StreetAddress = streetAddress;
            PostCode = postCode;
            City = city;
        }

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(PostCode)}: {PostCode}, {nameof(City)}: {City}";
        }
    }
}
