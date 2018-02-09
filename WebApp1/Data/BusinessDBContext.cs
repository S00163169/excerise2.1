using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp1.Models;

namespace WebApp1.Data

{
    public class BusinessDBContext : DbContext
    {
        public BusinessDBContext() : base("week3OrdersExample")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}


