using ConsoleRelationshipOneToOne.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRelationshipOneToOne.Map
{
    public class ImmobileMap : IEntityTypeConfiguration<Immobile>
    {
        public void Configure(EntityTypeBuilder<Immobile> builder)
        {
            builder
            .HasOne<Address>(x => x.Address).WithOne();
           


        }
    }
}
