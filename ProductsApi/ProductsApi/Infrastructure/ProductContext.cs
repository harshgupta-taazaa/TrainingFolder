using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Infrastructure
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> ProductTable { get; set; }
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
    }
}
