using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public class AplicationContext:DbContext
    {
         public DbSet<Book> Books { get; set; }
         public DbSet<Author> Authors { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
         if (!optionsBuilder.IsConfigured)
         {

        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Yo
        urDatabaseName;Trusted_Connection=True;");
         }
         }
    }
}
