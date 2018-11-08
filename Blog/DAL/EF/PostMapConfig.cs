using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Blog.DAL.EF
{
    public class PostMapConfig:EntityTypeConfiguration<Post>
    {
        public PostMapConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Title)
                .HasMaxLength(500)
                .IsRequired();

            Property(p => p.ShortDescription)
                .HasMaxLength(5000)
                .IsRequired();

            Property(p => p.Description)
                .HasMaxLength(5000)
                .IsRequired();

            Property(p => p.Published)
                .IsRequired();

            Property(p => p.PostedOn)
                .IsRequired();

            Property(p => p.Modified)
                .IsOptional();

            HasMany(p => p.Tags)
                .WithMany(t => t.Posts)
                .Map(m =>
                {
                    m.ToTable("PostTag");
                    m.MapLeftKey("PostId");
                    m.MapRightKey("TagId");
                });
        }
    }
}