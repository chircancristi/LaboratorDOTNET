using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class AplicationContext : DbContext
    {
        public AplicationContext()
         {
            Database.EnsureCreated();
        }

    public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>()
            .Property(customer => customer.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Customer>()
             .Property(customer => customer.Address)
                .IsRequired()
                .HasMaxLength(300);

            modelBuilder.Entity<Customer>()
             .Property(customer => customer.PhoneNumber)
                 .IsRequired()
                   ;
            modelBuilder.Entity<Customer>()
             .Property(customer => customer.Email)
                 .IsRequired()
                   ;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
            }
        }
    }
}
