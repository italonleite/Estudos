using ConsoleRelationshipOneToOne.Map;
using ConsoleRelationshipOneToOne.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRelationshipOneToOne.Context
{
    public class ImmobileContext : DbContext
    {
        public DbSet<Immobile> Immobiles { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Server=DEV_ITALOLEITE\SQLEXPRESS;Database=EFRelationshipOneToOne;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ImmobileMap());

        }

    }
}
