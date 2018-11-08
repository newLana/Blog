using Blog.DAL.Abstracts;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using Blog.DAL.EF;

namespace Blog.DAL.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        BlogContext db = new BlogContext();

        public void Create(Tag item)
        {
            db.Tags.Add(item);db.SaveChanges();
        }

        public void Delete(Tag item)
        {
            db.Tags.Remove(item);
            db.SaveChanges();
        }

        public Tag Get(int id)
        {
            return db.Tags.Find(id);
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags.ToList();
        }

        public void Update(Tag item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}