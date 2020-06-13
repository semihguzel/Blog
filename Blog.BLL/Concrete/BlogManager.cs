﻿using BlogApp.BLL.Abstract;
using BlogApp.DAL.Abstract;
using BlogApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.BLL.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetList();
        }

        public Blog GetById(int blogId)
        {
            return _blogDal.Get(x => x.BlogId == blogId);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}