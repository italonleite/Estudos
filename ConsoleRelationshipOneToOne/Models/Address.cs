using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRelationshipOneToOne.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
