using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Blog.Models;

namespace Blog.DAL.EF
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PostMapConfig());

            modelBuilder.Entity<Category>().HasMany(c => c.Posts)
                .WithRequired(p => p.Category);

            base.OnModelCreating(modelBuilder);
        }
    }
}