﻿using Microsoft.EntityFrameworkCore;
using Shared.Common.Entities;

namespace Shared.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Company>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Client>().HasIndex(x => x.Document).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Supplier>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
        }
    }
}