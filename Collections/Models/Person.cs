using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Models
{
    internal class Person
    {
        public Person(string name, string description, string street, int number ) 
        { 
            this.Name = name;
            this.Description = description;
            this.Address = new Address(street, number);
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public Address(string street, int number) 
        { 
            this.Number = number;
            this.Street = street;
        }
        public int Number { get; set; }
        public string Street { get; set; }
        
    }
}
