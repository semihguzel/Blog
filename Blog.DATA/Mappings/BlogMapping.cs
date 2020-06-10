using Blog.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DATA.Mappings
{
    public class BlogMapping : IEntityTypeConfiguration<Blog.DATA.Entities.Blog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Blog.DATA.Entities.Blog> builder)
        {
            builder.ToTable("Blog");

            builder.HasKey(x => x.BlogId);
            builder.Property(x => x.BlogHeader).HasMaxLength(100);
            builder.Property(x => x.BlogText).HasMaxLength(500);
        }
    }
}
