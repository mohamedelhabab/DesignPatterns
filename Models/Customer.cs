using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Customer : ICloneable
    {
        public string Name;

        public Address address;

        public Customer(string name, Address address)
        {
            Name = name;
            this.address = address; 
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(address)}: {address}";
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public Customer ShallowCopy()
        {
          return (Customer) MemberwiseClone();
        }

        public Customer DeepCopy()
        {
           return new Customer(Name, new Address(address.StreetAddress, address.PostCode, address.City));
        }
    }
}
