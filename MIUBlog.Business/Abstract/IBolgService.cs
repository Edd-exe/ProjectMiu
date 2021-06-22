using MIUBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MIUBlog.Business.Abstract
{
    public interface IBlogService
    {
        IQueryable<Blog> GetAll();
        IQueryable<Blog> GetCategoryId(int categoryId);
        Blog Get(int id);
        public List<Blog> GetByUserId(string userId);
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(int blogId);
    }
}
