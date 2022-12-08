using Microsoft.EntityFrameworkCore;
using RazorBlog.Mapping;
using RazorBlog.Models;

namespace RazorBlog
{
    public class BlogContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
