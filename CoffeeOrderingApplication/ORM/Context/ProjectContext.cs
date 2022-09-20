using CoffeeOrderingApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.ORM.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.\\SQLEXPRESS;Database=CoffeeOrderingAppDB;Integrated Security=True;";
        }
        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cashier> Cashiers { get; set; }
        public DbSet<Barista> Baristas { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
