using ConsoleEFDescriminator.Map;
using ConsoleEFDescriminator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEFDescriminator.Context
{
    public class ImmobileContext : DbContext
    {
        public DbSet<Immobile> Immobiles { get; set; }
        public DbSet<Commercial> Commercials { get; set; }
        public DbSet<Residential> Residentials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ITALO\SQLNOVO; Database=EFDiscriminator;Trusted_Connection=True; MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ImmobileMap());
        }
  
    }
}
