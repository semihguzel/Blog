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

        [HttpPost]
        public void Update([FromBody] Blog blog)
        {
            _blogService.Update(blog);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _blogService.Delete(id);
        }
    }
}
