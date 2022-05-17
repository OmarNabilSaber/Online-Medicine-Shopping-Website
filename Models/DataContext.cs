using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.Models
{
    public class DataContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<ProductsInOrder> ProductsInOrder { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsInOrder>().HasKey(sc => new { sc.ProductId, sc.OrderId });
        }
    }
}