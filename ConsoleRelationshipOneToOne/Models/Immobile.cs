using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRelationshipOneToOne.Models
{
    public class Immobile
    {
        public Guid ImmobileId { get; set; }
        public TypeImmobile Type { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
    }
}
