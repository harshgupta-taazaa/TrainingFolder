using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace codefirst
{
    public class Foocontext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Productdetails> Productdetails { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-O12SMJV\SQLEXPRESS;Initial Catalog=foo;User ID=sa;Password=harsh");
        }
    }
}
