using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Infrastructure
{
    public class ToDoItemContext:DbContext
    {
        public DbSet<ToDoItem> ToDoItem { get; set; }
        public ToDoItemContext(DbContextOptions<ToDoItemContext> options) : base(options)
        {

        }
        
    }
}
