using Blog.DAL.Abstracts;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Blog.DAL.EF;

namespace Blog.DAL.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        BlogContext db = new BlogContext();

        public void Create(Category item)
        {
            db.Categories.Add(item);
            db.SaveChanges();
        }

        public void Delete(Category item)
        {
            db.Categories.Remove(item);
            db.SaveChanges();
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public void Update(Category item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}