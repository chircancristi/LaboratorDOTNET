using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.Data
{
    public sealed class DataContext: DbContext
    {
        public DataContext ( DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }
    }
}
