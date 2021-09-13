using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfeBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EfeBlog.Data.Concrete.EntityFramework.Contexts
{
    public class EfeBlogContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=.;Database=EfeBlog;Trusted_Connection=True; MultipleActiveResultSets=True;Connect
            Timeout=30;");
        }
    }
}
