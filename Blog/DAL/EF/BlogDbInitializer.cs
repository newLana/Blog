using System;
using System.Data.Entity;
using Blog.Models;

namespace Blog.DAL.EF
{
    public class BlogDbInitializer : CreateDatabaseIfNotExists<BlogContext>
    {        
        protected override void Seed(BlogContext context)
        {
            var cat1 = context.Categories.Add(new Category
            {
                Name = "testCategory1",
                Description = "testCategory1 description"                
            }); 

            var cat2 = context.Categories.Add(new Category
            {
                Name = "testCategory2",
                Description = "testCategory2 description"                
            });

            var tag1 = context.Tags.Add(new Tag
            {
                Name = "testTag1",
                Description = "testTag1 description"
            });

            var tag2 = context.Tags.Add(new Tag
            {
                Name = "testTag2",
                Description = "testTag2 description"
            });

            var tag3 = context.Tags.Add(new Tag
            {
                Name = "testTag3",
                Description = "testTag3 description"
            });

            var post1 = context.Posts.Add(new Post
            {
                Title = "TestPost1",
                Description = "Short description for testPost1\n" +
                                "Description for testPost1",
                PostedOn = DateTime.Now,
                Published = false,
                ShortDescription = "Short description for testPost1",
                Category = cat1
            });

            post1.Tags.Add(tag1);
            post1.Tags.Add(tag2);
            post1.Tags.Add(tag3);

            context.SaveChanges();
        }
    }
}