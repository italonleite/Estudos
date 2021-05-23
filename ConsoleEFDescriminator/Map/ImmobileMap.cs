using ConsoleEFDescriminator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEFDescriminator.Map
{
    public class ImmobileMap : IEntityTypeConfiguration<Immobile>
    {
        public void Configure(EntityTypeBuilder<Immobile> builder)
        {
            builder
              .HasDiscriminator<string>("imovel_descriminator_tipo")
              .HasValue<Residential>("residencial")
              .HasValue<Commercial>("comercial");
              builder.HasKey(x => x.ImmobileId);
        }
      
    }
}
