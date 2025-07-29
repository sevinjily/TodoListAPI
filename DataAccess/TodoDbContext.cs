using Entities.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TodoDbContext:DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
