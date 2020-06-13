using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DATA.Entities
{
    public class Blog : IEntity
    {
        public int BlogId { get; set; }
        public string BlogHeader { get; set; }
        public string BlogText { get; set; }
    }
}
