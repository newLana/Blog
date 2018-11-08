using Blog.DAL.Abstracts;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.DAL.Repositories
{
    public class BlogRepository
    {
        private PostRepository postRepository;
        private CategoryRepository categoryRepository;
        private TagRepository tagRepository;

        public IRepository<Post> Posts
        {
            get
            {
                if(postRepository == null)
                {
                    postRepository = new PostRepository();
                }
                return postRepository;
            }
        }

        public IRepository<Category> Categories
        {
            get
            {
                if(categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository();
                }
                return categoryRepository;
            }
        }

        public IRepository<Tag> Tags
        {
            get
            {
                if(tagRepository == null)
                {
                    tagRepository = new TagRepository();
                }
                return tagRepository;
            }
        }
    }
}