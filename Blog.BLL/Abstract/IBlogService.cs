using BlogApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.BLL.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        Blog GetById(int blogId);
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
        void Delete(int blogId);
        List<Blog> SearchByBlogHeader(string blogHeader);
    }
}
