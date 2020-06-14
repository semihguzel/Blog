using BlogApp.Core.DAL.EntityFramework;
using BlogApp.DAL.Abstract;
using BlogApp.DAL.Concrete;
using BlogApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.DAL.Concrete
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, Context>, IBlogDal
    {
        public List<Blog> SearchBlogsByHeader(string blogHeaderText)
        {
            using (var context = new Context())
            {
                var blogs = context.Set<Blog>().Where(x => x.BlogHeader.Contains(blogHeaderText));

                blogs = blogs.OrderBy(x => x.BlogHeader);

                return blogs.ToList();
            }
        }
    }
}
