using BlogApp.Core.DAL.EntityFramework;
using BlogApp.DAL.Abstract;
using BlogApp.DAL.Concrete;
using BlogApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DAL.Concrete
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, Context>, IBlogDal
    {
    }
}
