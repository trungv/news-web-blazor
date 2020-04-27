using Microsoft.EntityFrameworkCore;
using NewsWeb.Core.Entities;

namespace NewsWeb.Core.DatabaseContext
{
    public class NewsWebContext:DbContext
    {
        public NewsWebContext(DbContextOptions<NewsWebContext> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Customers { get; set; }
        public DbSet<Post> Orders { get; set; }
        public DbSet<SubCategory> OrderDetails { get; set; }
    }
}
