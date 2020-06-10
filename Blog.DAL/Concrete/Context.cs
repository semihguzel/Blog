using System;
using System.Collections.Generic;
using System.Text;
using Blog.DATA.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Blog.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .; Database = Blog; uid = sa; pwd = 1234");
        }

        public DbSet<Blog.DATA.Entities.Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Blog.DATA.Entities.Blog>(new BlogMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
