using Blog.DAL.Abstracts;
using Blog.DAL.EF;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog.DAL.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        BlogContext db = new BlogContext();

        public void Create(Post item)
        {
            db.Posts.Add(item);
            db.SaveChanges();
        }

        public void Delete(Post item)
        {
            db.Posts.Remove(item);
            db.SaveChanges();
        }

        public Post Get(int id)
        {
            return db.Posts.Find(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public void Update(Post item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}