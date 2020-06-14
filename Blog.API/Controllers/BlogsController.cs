using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.BLL.Abstract;
using BlogApp.DATA.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private IBlogService _blogService;
        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("{id}")]
        public Blog GetById(int id)
        {
            return _blogService.GetById(id);
        }

        [HttpGet]
        public IEnumerable<Blog> GetAll()
        {
            return _blogService.GetAll();
        }

        [HttpPost("{action}")]
        public void Add(Blog blog)
        {
            _blogService.Add(blog);
        }

        [HttpPost]
        public void Update(Blog blog)
        {
            _blogService.Update(blog);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _blogService.Delete(id);
        }

        [HttpGet("{action}")]
        public IEnumerable<Blog> SearchByBlogHeader(string blogHeader)
        {
            return _blogService.SearchByBlogHeader(blogHeader);
        }
    }
}
