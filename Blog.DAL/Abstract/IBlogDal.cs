using BlogApp.Core.DAL;
using BlogApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DAL.Abstract
{
    public interface IBlogDal : IEntityRepositoryBase<Blog>
    {
        List<Blog> SearchBlogsByHeader(string blogHeaderText);
    }
}
