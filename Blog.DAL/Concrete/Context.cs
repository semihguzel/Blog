using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.DATA.Entities;
using BlogApp.DATA.Mappings;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .; Database = Blog; uid = sa; pwd = 1234");
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Blog>(new BlogMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
