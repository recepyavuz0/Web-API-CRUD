using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
   public class CustomersDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-R1LN2J4\\SQLEXPRESS;Initial Catalog=Customers;Integrated Security=True");
        }

        public DbSet<Customers> Customers { get; set; }

    }
}
