using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BlogApp.DATA.Entities;
using BlogApp.DATA.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace BlogApp.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            optionsBuilder.UseSqlServer(configurationBuilder.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Blog>(new BlogMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
